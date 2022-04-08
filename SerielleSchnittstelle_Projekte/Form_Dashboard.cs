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
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        //Zeitdiagrammprojekt starten
        private void btn_zeitdiagramm_Click(object sender, EventArgs e)
        {
            Form_Zeitdiagramm zeitdiagramm = new Form_Zeitdiagramm();
            this.Hide();
            zeitdiagramm.ShowDialog();
            this.Close();
        }

        //Voltmeterprojekt starten
        private void btn_voltmeter_Click(object sender, EventArgs e)
        {
            Form_Voltmeter voltmeter = new Form_Voltmeter();
            this.Hide();
            voltmeter.ShowDialog();
            this.Close();
        }

        //SerielleKommunikationprojekt starten
        private void btn_seriellekommunikation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Kommunikation().ShowDialog();
            this.Close();
        }

        private void btn_ampel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Ampel().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DigitalerRegler().ShowDialog();
            this.Close();
        }

        private void label_zeitdiagramm_Click(object sender, EventArgs e)
        {
            Form_Zeitdiagramm zeitdiagramm = new Form_Zeitdiagramm();
            this.Hide();
            zeitdiagramm.ShowDialog();
            this.Close();
        }

        private void label_voltmeter_Click(object sender, EventArgs e)
        {
            Form_Voltmeter voltmeter = new Form_Voltmeter();
            this.Hide();
            voltmeter.ShowDialog();
            this.Close();
        }

        private void label_seriellekom_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Kommunikation().ShowDialog();
            this.Close();
        }

        private void label_ampel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Ampel().ShowDialog();
            this.Close();
        }

        private void label_regler_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DigitalerRegler().ShowDialog();
            this.Close();
        }
    }
}
