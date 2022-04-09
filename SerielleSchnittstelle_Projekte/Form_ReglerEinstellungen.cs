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
    public partial class Form_ReglerEinstellungen : Form
    {
        DigitalerRegler DR_instance { get; set; }
        string displayname { get; set; }
        public Form_ReglerEinstellungen(DigitalerRegler regler, string name)
        {
            InitializeComponent();
            DR_instance = regler;
            displayname = name;

            if(DR_instance.getChart().Series[displayname].Enabled)
            {
                checkBx_show.Checked = true;
            }
            else
            {
                checkBx_show.Checked = false;
            }

        }

        private void btn_dicker_Click(object sender, EventArgs e)
        {
            DR_instance.getChart().Series[displayname].BorderWidth++;
        }

        private void btn_duenner_Click(object sender, EventArgs e)
        {
            if (DR_instance.getChart().Series[displayname].BorderWidth > 1)
                DR_instance.getChart().Series[displayname].BorderWidth--;
        }

        private void checkBx_show_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBx_show.Checked)
            {
                DR_instance.getChart().Series[displayname].Enabled = true;
            }
            else
            {
                DR_instance.getChart().Series[displayname].Enabled = false;
            }
        }
    }
}
