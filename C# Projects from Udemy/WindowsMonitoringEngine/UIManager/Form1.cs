using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UIManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("CsMonitorEngine2");

            labelStart.Text = service.Status.ToString();

            if (labelStart.Text.ToLower() == "running")
            {
                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
            }


            // TODO: This line of code loads data into the 'dataSet1.DataCollected' table. You can move, or remove it, as needed.
            this.dataCollectedTableAdapter.Fill(this.dataSet1.DataCollected);

            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yy" + System.Environment.NewLine + "hh:mm:ss";

            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yy" + System.Environment.NewLine + "hh:mm:ss";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("CsMonitorEngine2");

            if (labelStart.Text.ToLower() == "running")
            {
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped);

            }
            else
            {
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running);
            }

            labelStart.Text = service.Status.ToString();

            if (labelStart.Text.ToLower() == "running")
            {
                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
            }

        }
    }
}
