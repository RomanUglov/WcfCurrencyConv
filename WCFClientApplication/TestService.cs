using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFClientApplication.ServiceReference;

namespace WCFClientApplication
{
    class TestService
    {
        #region Variables
        // прокси для взаимодействия с WCF-службой
        private CurrencyConvClient proxy;
        #endregion

        public TestService()
        {
            CreateProxy();
        }
        #region Properties
        /// <summary>
        /// Communication State of proxy
        /// </summary>
        public bool ProxyReady
        {
            get { return proxy.State == System.ServiceModel.CommunicationState.Opened; }
        }
        #endregion
        #region UserMethods
        /// <summary>
        /// Создаем прокси для взаимодействия с WCF-службой
        /// </summary>
        private void CreateProxy()
        {
            proxy = new CurrencyConvClient();
            proxy.Open();
        }
        /// <summary>
        /// returns list of currency and rates
        /// </summary>
        /// <param name="dtFrom">range date from</param>
        /// <param name="dtTo">range date to</param>
        /// <param name="currCode">Optional, currency code</param>
        /// <returns></returns>
        public List<string> GetRateByDt(DateTime dtFrom, DateTime dtTo, string currCode)
        {
            List<string> res = new List<string>();
            if (this.ProxyReady)
            {
                try
                {
                    res = proxy.GetRateByDate(dtFrom, dtTo, currCode).ToList<string>();
                }
                catch (System.ServiceModel.CommunicationObjectFaultedException e)
                {
                    EventLog.WriteEntry("WCFClientApplication", e.Message);
                }
            }
            return res;
        }
        /// <summary>
        /// Convert input value in "codeCurrFrom" to output value in "codeCurrTo"
        /// </summary>
        /// <param name="codeCurrFrom">Code of input currency</param>
        /// <param name="codeCurrTo">Code of output currency</param>
        /// <param name="date">Operation date</param>
        /// <param name="valToConvert">a value, which should be converted</param>
        /// <returns></returns>
        public double ConvertToCurrency(string codeCurrFrom, string codeCurrTo, DateTime date, double valToConvert)
        {
            double res = 0;
            if (this.ProxyReady)
            {
                try
                {
                    res = proxy.Convert(codeCurrFrom, codeCurrTo, date, valToConvert);
                }
                catch (System.ServiceModel.CommunicationObjectFaultedException e)
                {
                    EventLog.WriteEntry("WCFClientApplication", e.Message);
                }
            }
            return res;
        }
        /// <summary>
        /// returns string-based representation of XML values
        /// </summary>
        /// <param name="dtFrom">date range from</param>
        /// <param name="dtTo">date range to</param>
        /// <param name="currCode">Optional, currency code</param>
        /// <returns></returns>
        public string ExportToCSV(DateTime dtFrom, DateTime dtTo, string currCode)
        {
            string res = "";
            if (this.ProxyReady)
            {
                try
                {
                    res = proxy.ExportToCSV(dtFrom, dtTo, currCode);
                }
                catch (System.ServiceModel.CommunicationObjectFaultedException e)
                {
                    EventLog.WriteEntry("WCFClientApplication", e.Message);
                }
            }
            return res;
        }
        #endregion
    }
}
