using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConvServiseLibrary
{
    [ServiceContract(Namespace="www.Sometest.com")]
    public interface ICurrencyConv
    {
        [OperationContract]
        List<string> GetRateByDate(DateTime dateFrom, DateTime dateTo, string currencyCode = "");

        [OperationContract]
        double Convert(string currA, string currB, DateTime date, double value);

        [OperationContract]
        string ExportToCSV(DateTime dateFrom, DateTime dateTo, string currencyCode = "");
    }
}
