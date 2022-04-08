using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerielleSchnittstelle_Projekte
{
    public partial class Form_Ampel : Form
    {
        public Form_Ampel()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            System.Diagnostics.Debug.WriteLine(line);
            /*
            System.Diagnostics.Debug.WriteLine(line);

            int a1 = Convert.ToInt32(line[0].ToString());
            int a2 = Convert.ToInt32(line[2].ToString());

            System.Diagnostics.Debug.WriteLine(a1 + " : " + a2);

            if (a1 == 0)
            {
                pb_1r.BackColor = Color.Red;
                pb_1ge.BackColor = Color.Gray;
                pb_1gr.BackColor = Color.Gray;
            }
            else
            if(a1 == 1)
            {
                pb_1r.BackColor = Color.Gray;
                pb_1ge.BackColor = Color.Yellow;
                pb_1gr.BackColor = Color.Gray;
            }
            else
            if(a1 == 2)
            {
                pb_1r.BackColor = Color.Gray;
                pb_1ge.BackColor = Color.Gray;
                pb_1gr.BackColor = Color.Green;
            }

            if (a2 == 0)
            {
                pb_2r.BackColor = Color.Red;
                pb_2ge.BackColor = Color.Gray;
                pb_2gr.BackColor = Color.Gray;
            }
            else
            if (a2 == 1)
            {
                pb_2r.BackColor = Color.Gray;
                pb_2ge.BackColor = Color.Yellow;
                pb_2gr.BackColor = Color.Gray;
            }
            else
            if (a2 == 2)
            {
                pb_2r.BackColor = Color.Gray;
                pb_2ge.BackColor = Color.Gray;
                pb_2gr.BackColor = Color.Green;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Add("Test");
            chart1.Series["Test"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series["Test"].Points.AddXY(0, 0);
            chart1.Series["Test"].Points.AddXY(1, 1);
            chart1.Series["Test"].Points.AddXY(2, 2);
            chart1.Series["Test"].Points.AddXY(3, 3);
            chart1.Series["Test"].Points.AddXY(4, 4);
            chart1.Series["Test"].Points.AddXY(5, 5);
            chart1.Series["Test"].Points.AddXY(6, 6);
            chart1.Series["Test"].Points.AddXY(7, 7);
            chart1.Series["Test"].Points.AddXY(8, 7);
            chart1.Series["Test"].Points.AddXY(9, 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series.Add("Test2");
        }
    }
}
