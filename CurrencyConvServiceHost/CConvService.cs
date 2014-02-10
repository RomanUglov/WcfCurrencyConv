using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using CurrencyConvServiseLibrary;
using System.ServiceModel;

namespace CurrencyConvServiceHost
{
    public partial class CConvService : ServiceBase
    {
        internal static ServiceHost myHost = null; 
        public CConvService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (myHost != null)
            {
                myHost.Close();
            }
            myHost = new ServiceHost(typeof(CurrencyConvService));
            try
            {
                myHost.Open();
            }
            catch (System.TimeoutException e)
            {
                EventLog.WriteEntry("CurrencyConvService", e.Message);
                return;
            }
        }

        protected override void OnStop()
        {
            if (myHost != null)
            {
                myHost.Close();
                myHost = null;
            }
        }
    }
}
