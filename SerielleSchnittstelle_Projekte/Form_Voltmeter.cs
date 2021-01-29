using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerielleSchnittstelle_Projekte
{
    public partial class Form_Voltmeter : Form
    {

        public delegate void SerialRead();
        public SerialRead SerialReadPointer;

        private int spannung1_raw = 0;
        private int spannung2_raw = 0;
        private Boolean state; //Spannung 1 = true; Spannung 2 = false;

        public Form_Voltmeter()
        {
            InitializeComponent();
            txtBx_data.Hide();
            state = false;
            SerialReadPointer = new SerialRead(serialRead);
            

            string[] portnames = SerialPort.GetPortNames();
            comboBox_ports.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ports.Items.AddRange(portnames);           


        }

        private void comboBox_ports_DropDown(object sender, EventArgs e)
        {
            comboBox_ports.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            comboBox_ports.Items.AddRange(portnames);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(comboBox_ports.Text.Length == 0)
            {
                MessageBox.Show("Bitte wählen Sie den gewünschten COM-PORT aus");
            }
            else
            {
                if (!(serialPort1.IsOpen))
                {
                    try
                    {
                        serialPort1.PortName = comboBox_ports.Text;
                        serialPort1.Open();
                        btn_connect.Text = "Verbindung unterbrechen";

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    serialPort1.Close();
                    btn_connect.Text = "Verbinden";
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(SerialReadPointer);
        }


        private void serialRead()
        {

            string recieved = serialPort1.ReadLine();
            
            if(recieved[recieved.Length-2] == '!')
            {
                spannung1_raw = Convert.ToInt32(recieved.Substring(0, recieved.Length - 2));
            }
            else
            {
                spannung2_raw = Convert.ToInt32(recieved);
            }

            txtBx_data.Text += "Spannung 1: " + spannung1_raw.ToString() + "\r\n";
            txtBx_data.Text += "Spannung 2: " + spannung2_raw.ToString() + "\r\n";
            txtBx_data.ScrollToCaret();

            value_voltage1.Text = ((4.77 / 1023) * spannung1_raw).ToString("0.00");
            value_voltage2.Text = ((4.77 / 1023) * spannung2_raw).ToString("0.00");
        }

        private void checkBox_console_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_console.Checked)
            {
                txtBx_data.Show();
            }
            else
            {
                txtBx_data.Hide();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                Form_Dashboard dashboard = new Form_Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte unterbrechen Sie die Verbindung zur seriellen Schnittstelle");
            }
        }
    }
}
