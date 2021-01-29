using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diagramme;

namespace SerielleSchnittstelle_Projekte
{
    public partial class Form_Zeitdiagramm : Form
    {
        public delegate void USARTLesen();
        public USARTLesen USARTLesenPtr;

        private CDiagramme diagramm;
        private PointF[] array_points;
        int t = 0;
        int zaehler = 1;
        

        public Form_Zeitdiagramm()
        {
            InitializeComponent();
            loadComboBox();

            USARTLesenPtr = new USARTLesen(serialPort_Read);
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            //Aufsetzen der CDiagramme-Klasse
            diagramm = new CDiagramme(pictureBox1, "Zeitdiagramm");
            array_points = new PointF[10000];
            diagramm.PositionUrsprung = "unten-links";
            diagramm.Teilung_Y = 30;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //Verbindung zu seriellen Port aufbauen / unterbrechen

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
                if(comboBox1.SelectedItem != null)
                {
                    if(comboBox1.SelectedItem.ToString() == serialPort1.PortName)
                    {
                        serialPort1.Close();
                        btn_connect.Text = "Verbinden";
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie den richtigen COM-Port aus");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie den richtigen COM-Port aus");
                }
                
            }

        }

        private void serialPort_Read()
        {
            //Daten von serieller Schnittstelle auslesen und verarbeiten

            string line = serialPort1.ReadLine();
            updateCDiagramme((float)Convert.ToDouble(line));
            updateChart(Convert.ToDouble(line));
            t += 1;
            txtBx_output.Text += (line + "\n");

            
        }

        private void updateCDiagramme(float value_y)
        {
            array_points[zaehler].X = t;
            array_points[zaehler].Y = value_y;
            array_points[0].X = zaehler;
            zaehler++;
            if (array_points[0].X > 1)
            {
                diagramm.Zeitdiagrammzeichnen(array_points, true);
            }
        }

        private void updateChart(double value_y)
        {
            chart1.Series["Series1"].Points.AddXY(t, value_y);
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                Form_Dashboard dashboard = new Form_Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte unterbrechen Sie zuerst die Verbindung zur seriellen Schnittstelle");
            }
        }
    }
}
