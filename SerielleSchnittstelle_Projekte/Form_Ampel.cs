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
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
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
            }
        }
    }
}
