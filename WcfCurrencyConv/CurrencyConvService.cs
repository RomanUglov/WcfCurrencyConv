using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace CurrencyConvServiseLibrary
{
    public class CurrencyConvService : ICurrencyConv
    {
        #region Variables
        // переменная для полученного документа
        XElement doc;
        // переменная для пространства имен XML
        XNamespace aw;
        #endregion
        public CurrencyConvService()
        {
            GetXmlDocument();
        }
        #region UserMethods
        /// <summary>
        /// Get document by http request.
        /// Creates local copy
        /// </summary>
        private void GetXmlDocument()
        {         
                // создаем запрос для xml
            HttpWebResponse resp;
            HttpWebRequest req =
            (HttpWebRequest)WebRequest.Create("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml");
            try
            {                
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException e)
            {
                EventLog.WriteEntry("CurrencyConvService", e.Message);
                return;
            }
            using (StreamReader streamreader = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(1251)))
            {
                doc = XElement.Load(streamreader);
                // получаем xmlns
                aw = doc.Attribute("xmlns").Value;
            }          
        }
        /// <summary>
        /// returns list of currency and rates
        /// </summary>
        /// <param name="dateFrom">range date from</param>
        /// <param name="dateTo">range date to</param>
        /// <param name="currencyCode">Optional, currency code</param>
        /// <returns></returns>
        public List<string> GetRateByDate(DateTime dateFrom, DateTime dateTo, String currencyCode = "")
        {
            List<string> res = new List<string>();
            if (doc == null) return res;
            // linq-запрос для даты от и до
            IEnumerable<XElement> cube =
                from el in doc.Element(aw + "Cube").Elements(aw + "Cube")
                where (dateFrom.AddDays(-1) < DateTime.Parse((string)el.Attribute("time").Value) && dateTo.AddDays(1) > DateTime.Parse((string)el.Attribute("time").Value))
                select el;
            foreach (XElement c in cube)
            {
                // извлекаем из дочерних елементов нужные нам данные
                foreach (XElement d in c.Descendants())
                {
                    if (d.Attribute("currency").Value == currencyCode.ToUpper() || currencyCode == "")
                        res.Add(String.Format("Cur: {0} rate: {1}", d.Attribute("currency").Value, d.Attribute("rate").Value));
                }
            }
            return res;
        }
        /// <summary>
        /// Convert input value in "codeCurrFrom" to output value in "codeCurrTo"
        /// </summary>
        /// <param name="currA">Code of input currency</param>
        /// <param name="currB">Code of output currency</param>
        /// <param name="date">Operation date</param>
        /// <param name="value">a value, which should be converted</param>
        /// <returns></returns>
        public double Convert(string currA, string currB, DateTime date, double value)
        {
            if (doc == null) return 0;
            double rateFrom = 0;
            double rateTo = 0;
            double res;
            string divider = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            IEnumerable<XElement> cube =
            from el in doc.Element(aw + "Cube").Elements(aw + "Cube")
            where (string)el.Attribute("time").Value == date.ToString("yyyy-MM-dd")
            select el;
            foreach (XElement c in cube)
            {
                // извлекаем из дочерних елементов нужные нам данные
                foreach (XElement d in c.Descendants())
                {
                    if (d.Attribute("currency").Value == currA.ToUpper())
                        Double.TryParse(d.Attribute("rate").Value.Replace(".", divider), out rateFrom);
                    if (d.Attribute("currency").Value == currB.ToUpper())
                        Double.TryParse(d.Attribute("rate").Value.Replace(".", divider), out rateTo);                    
                }
            }
            return rateFrom == 0 ? 0 : Math.Round(res = value * (rateTo / rateFrom), 2);
        }
        /// <summary>
        /// returns string-based representation of XML values
        /// </summary>
        /// <param name="dateFrom">range date from</param>
        /// <param name="dateTo">range date to</param>
        /// <param name="currencyCode">Optional, currency code</param>
        /// <returns></returns>
        public string ExportToCSV(DateTime dateFrom, DateTime dateTo, string currencyCode = "")
        {
            if (doc == null) return "";
            string csv = "";
            IEnumerable < XElement > cube =
                from el in doc.Element(aw + "Cube").Elements(aw + "Cube")
                where (dateFrom.AddDays(-1) < 
                    DateTime.Parse((string)el.Attribute("time").Value) && dateTo.AddDays(1) > 
                        DateTime.Parse((string)el.Attribute("time").Value))
                select el;
            foreach (XElement c in cube)
            {
                csv = c.Attribute("time").Value + ",";
                // извлекаем из дочерних елементов нужные нам данные
                foreach (XElement d in c.Descendants())
                {
                    if (d.Attribute("currency").Value == currencyCode.ToUpper() || currencyCode == "")
                        csv += String.Format("{0},{1},", d.Attribute("currency").Value, d.Attribute("rate").Value);
                }
            }
            if (csv.Length > 0)
                csv = csv.Remove(csv.Length - 1, 1);
            return csv;
        }
        #endregion
    }
}
