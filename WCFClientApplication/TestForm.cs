using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFClientApplication
{
    public partial class WcfTestForm : Form
    {
        // вспомогательный класс для управления сервисом
        TestService ts;

        public WcfTestForm()
        {
            InitializeComponent();
            ts = new TestService();
        }
        #region FormsEvents
        private void WcfTestForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbxRateCode;
            timerCheckState.Start();
        }

        private void timerCheckState_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelState.Text = ts.ProxyReady ? "Готов" : "Сервис не доступен";
        }
        

        private void btnTestRate_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            switch (((Button)sender).Tag.ToString())
            {
                case "rate":
                    List<string> res = ts.GetRateByDt(dtpRateFrom.Value, dtpRateTo.Value, tbxRateCode.Text);                    
                    foreach (var item in res)
                        lbxOutput.Items.Add(item);
                    break;
                case "conv":
                    double param;
                    if (double.TryParse(tbxConvSum.Text, out param))
                        lbxOutput.Items.Add(ts.ConvertToCurrency(tbxRateACode.Text, tbxRateBCode.Text, dtpConv.Value, param).ToString());
                    else
                        lbxOutput.Items.Add("Неверное значение суммы..");
                    break;
                case "exp":
                    lbxOutput.Items.Add(ts.ExportToCSV(dtpExpCSVFrom.Value, dtpExpCSVTo.Value, tbxExpCsvCode.Text));
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
