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
    public partial class Form_Zeitdiagramm : Form
    {
        public delegate void USARTLesen();
        public USARTLesen USARTLesenPtr;

        public Form_Zeitdiagramm()
        {
            InitializeComponent();
            loadComboBox();

            USARTLesenPtr = new USARTLesen(serialPort_Read);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //Verbindung zu serielle Port aufbauen / unterbrechen

            if(!serialPort1.IsOpen)
            {
                if(comboBox1.SelectedItem != null)
                {
                    try
                    {
                        serialPort1.PortName = comboBox1.SelectedItem.ToString();
                        serialPort1.Open();
                        btn_connect.Text = "Verbindung unterbrechen";

                    }catch(Exception ex)
                    {
                        MessageBox.Show("Ein Fehler ist auggetreten: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie einen COM-Port aus");
                }
            }
            else
            {
                serialPort1.Close();
                btn_connect.Text = "Verbinden";
            }

        }

        private void serialPort_Read()
        {
            //Daten von serieller Schnittstelle auslesen und verarbeiten

            string line = serialPort1.ReadLine();

            txtBx_output.Text += line + "\n";
        }

        private void loadComboBox()
        {
            //Verfügbaren COM-Ports in der ComboBox auflisten

            string[] portnames = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();

            foreach(string portname in portnames)
            {
                comboBox1.Items.Add(portname);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(USARTLesenPtr);
        }
    }
}
