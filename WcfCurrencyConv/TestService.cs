using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCurrencyConv
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in both code and config file together.
    public class TestService : ICurrencyConv
    {
        public Dictionary<String, double> GetRateByDate(DateTime dateFrom, DateTime dateTo, String currencyCode = "")
        {
            Dictionary<string,double> res = new Dictionary<string,double>();

            return res;
        }
        public double Convert(string currA, string currB, DateTime date, double value)
        {
            return 0;
        }
        public string ExportCSV(DateTime dateFrom, DateTime dateTo, string currencyCode = "")
        {
            return "";
        }
    }
}
