﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diagramme;
using Parametrierung;

namespace SerielleSchnittstelle_Projekte
{
    public partial class Form_Zeitdiagramm : Form
    {
        public delegate void USARTLesen();
        public USARTLesen USARTLesenPtr;
        private Class_Interface val_interface;

        private System.Diagnostics.Stopwatch stopwatch;

        private CDiagramme diagramm;
        private PointF[] array_points;
        int t = 0;
        int zaehler = 1;
        float alterwert = 0;
        

        public Form_Zeitdiagramm()
        {
            InitializeComponent();
            loadComboBox();

            USARTLesenPtr = new USARTLesen(serialPort_Read);
            val_interface = new Class_Interface();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            stopwatch = new System.Diagnostics.Stopwatch();

            //Aufsetzen der CDiagramme-Klasse
            diagramm = new CDiagramme(pictureBox1, "Zeitdiagramm");
            array_points = new PointF[10000];
            diagramm.PositionUrsprung = "unten-links";
            diagramm.Teilung_Y = 1;
            diagramm.Anzahl_Teilungen_Y = 5;
        }

        //Verbindung zu seriellen Port aufbauen / unterbrechen
        private void btn_connect_Click(object sender, EventArgs e)
        {
            
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
                        if(stopwatch.IsRunning)
                        {
                            stopwatch.Stop();
                        }
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

        //Daten von serieller Schnittstelle auslesen und verarbeiten
        private void serialPort_Read()
        {

            if(!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }
            //System.Diagnostics.Debug.WriteLine("drin");
            string line = serialPort1.ReadLine();
            //System.Diagnostics.Debug.WriteLine(line);
            float spannung_raw = (float) Convert.ToDouble(line);

            if(spannung_raw >= 0)
            {
                spannung_raw = (float)((0.8 * alterwert) + (0.2 * (float)spannung_raw));
            }
            


            float value_spannung =  (float) (spannung_raw * (4.77 / 1023.00));
            //updateCDiagramme(value_spannung);            
            updateChart(Convert.ToDouble(spannung_raw));
            alterwert = spannung_raw;


            t += 1;
            txtBx_output.Text += (line + "\n");
            //System.Diagnostics.Debug.WriteLine("Milliseconds" + stopwatch.ElapsedMilliseconds.ToString());
        }

        //Empfangene Daten in CDiagramme eintragen
        private void updateCDiagramme(float value_y)
        {
            array_points[zaehler].X = stopwatch.ElapsedMilliseconds/1000;
            array_points[zaehler].Y = value_y;
            array_points[0].X = zaehler;
            zaehler++;
            if (array_points[0].X > 1)
            {
                diagramm.Zeitdiagrammzeichnen(array_points, true);
            }            
        }

        //Empfangene Daten in Chart eintragen
        private void updateChart(double value_y)
        {
            chart1.Series["Messung1"].Points.AddXY((float) stopwatch.ElapsedMilliseconds/1000, value_y);
        }

        //Verfügbaren COM-Ports in der ComboBox auflisten
        private void loadComboBox()
        {
            string[] portnames = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(portnames);
        }

        //Comboboxupdate
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(USARTLesenPtr);
        }

        //Zurück zur Auswahl der Programme
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

        //Farbauswahl
        private void btn_color_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                chart1.Series["Messung1"].Color = colorDialog1.Color;
            }

        }

        //Mausposition in Diagrammwert umwandeln und anzeigen
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                double xvalue = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                double yvalue = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
                labelxvalue.Text = Math.Round(xvalue, 2).ToString();
                labelyvalue.Text = Math.Round(yvalue, 2).ToString();
            }
            catch { }
        }

        //Dickere Linie
        private void btn_strenghtp_Click(object sender, EventArgs e)
        {
            chart1.Series["Messung1"].BorderWidth++;
        }

        //Dünnere Linie
        private void btn_strenghtm_Click(object sender, EventArgs e)
        {
            if(chart1.Series["Messung1"].BorderWidth != 1)
            {
                chart1.Series["Messung1"].BorderWidth--;
            }
        }

        //Sendet Start-Befehl an Mikrocontroller
        private void btn_start_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("start");
        }

        //Sendet Stop-Befehl an Mikrocontroller
        private void btn_stop_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("stop");
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                val_interface.saveValues(chart1.Series[0].Points, folderBrowserDialog1.SelectedPath, "values.txt");
            }
        }
    }
}
