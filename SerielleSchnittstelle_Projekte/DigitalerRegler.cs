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
    public partial class DigitalerRegler : Form
    {
        public delegate void USARTLesen();
        public USARTLesen USARTLesenPtr;


        private int currentRegler; // 0=keiner, 1=PRegler, 2=PIRegler
        double seconds;

        public List<Regler> reglerList;
        public DigitalerRegler()
        {
            InitializeComponent();
            reglerList = new List<Regler>();
            USARTLesenPtr = new USARTLesen(serialPort_Read);
            currentRegler = 0;
            seconds = 0.1;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            getPorts();
            
        }

        private void getPorts()
        {
            string[] portnames = System.IO.Ports.SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(portnames);
        }

        private void getProgrammedRegler()
        {
            serialPort1.WriteLine("getvalues");
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            this.Hide();
            new Form_Dashboard().ShowDialog();
            this.Close();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(comboBox_ports.SelectedItem != null)
            {
                if(!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.PortName = comboBox_ports.SelectedItem.ToString();
                        serialPort1.Open();
                        btn_connect.Text = "Verbindung trennen";
                        getProgrammedRegler();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        serialPort1.Close();
                        btn_connect.Text = "Verbinden";
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void comboBox_ports_DropDown(object sender, EventArgs e)
        {
            getPorts();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(USARTLesenPtr);
        }

        private void serialPort_Read()
        {
            string line = serialPort1.ReadLine();

            if(line.Contains("#") && line.Contains("*") && line.Contains("!"))
            {
                int pos1 = line.IndexOf("#");
                int pos2 = line.IndexOf("*");
                int pos3 = line.IndexOf("!");
                /*System.Diagnostics.Debug.WriteLine(line);
                System.Diagnostics.Debug.WriteLine(line.Length -1);
                System.Diagnostics.Debug.WriteLine(pos1 + " " + pos2 + " " + pos3);*/
                int kp = Convert.ToInt32(line.Substring(1, (line.IndexOf("#") - 1)));
                int kr = Convert.ToInt32(line.Substring(pos1 + 1, pos2 - pos1 - 1));
                int tn = Convert.ToInt32(line.Substring(pos2 + 1, pos3 - pos2 - 1));
                int sollwert = Convert.ToInt32(line.Substring(pos3 + 1, line.Length - pos3 - 1));

                //System.Diagnostics.Debug.WriteLine(kp + " " + kr + " " + tn + " " + sollwert);

                
                reglerList.Add(new P_Regler(kp, sollwert, "P-Beispiel", Color.Orange));
                reglerList.Add(new PI_Regler(kr, tn, sollwert, "PI-Beispiel", Color.Green));
                foreach(Regler r in reglerList)
                {
                    comboBox_regler.Items.Add(r.displayName);
                }
                updateChartSeries();
                
            }
            else
            {
                try
                {
                    chart1.Series[comboBox_regler.SelectedItem.ToString()].Points.AddXY(seconds, Convert.ToDouble(line));
                    seconds += 0.1;
                }
                catch (Exception ex) { }
            }
        }

        private void comboBox_regler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string displayname = comboBox_regler.SelectedItem.ToString();
            chart1.Series[displayname].Points.Clear();
            seconds = 0;
            Regler selectedRegler = null;
            foreach(Regler r in reglerList)
            {
                if(r.displayName == displayname)
                {
                    selectedRegler = r;
                    break;
                }
            }

            if (selectedRegler.GetType() == new P_Regler(1,1,"",Color.Black).GetType())
            {
                P_Regler regler = (P_Regler)selectedRegler;
                txtBx_Kp.Enabled = true;
                txtBx_Kr.Enabled = false;
                txtBx_Tn.Enabled = false;
                currentRegler = 1;
                txtBx_Kp.Text = regler.Kp.ToString();
                txtBx_Kr.Text = "";
                txtBx_Tn.Text = "";
                txtBx_sollwert.Text = regler.sollwert.ToString();
            }
            else
            if(selectedRegler.GetType() == new PI_Regler(1, 1, 1 , "", Color.Black).GetType())
            {
                PI_Regler regler = (PI_Regler)selectedRegler;
                txtBx_Kp.Enabled = false;
                txtBx_Kr.Enabled = true;
                txtBx_Tn.Enabled = true;
                currentRegler = 2;
                txtBx_Kp.Text = "";
                txtBx_Kr.Text = regler.Kr.ToString();
                txtBx_Tn.Text = regler.Tn.ToString();
                txtBx_sollwert.Text = regler.sollwert.ToString();
            }
            else
            {
                currentRegler = 0;
            }

        }

        private void updateChartSeries()
        {
            chart1.Series.Clear();
            foreach(Regler r in reglerList)
            {
                chart1.Series.Add(r.displayName);
                chart1.Series.FindByName(r.displayName).Color = r.displayColor;
                chart1.Series.FindByName(r.displayName).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
        }

        public void updateReglerList()
        {
            comboBox_regler.Items.Clear();
            foreach (Regler r in reglerList)
            {
                comboBox_regler.Items.Add(r.displayName);
            }
            updateChartSeries();
        }

        public void updateReglerList(int index)
        {
            comboBox_regler.Items.Clear();
            foreach (Regler r in reglerList)
            {
                comboBox_regler.Items.Add(r.displayName);
            }
            updateChartSeries();
            if (comboBox_regler.Items.Count > 0)
            {
                comboBox_regler.SelectedIndex = index;
                Regler selectedRegler = null;
                foreach (Regler r in reglerList)
                {
                    if (r.displayName == comboBox_regler.SelectedItem.ToString())
                    {
                        selectedRegler = r;
                        break;
                    }
                }

                if (selectedRegler.GetType() == new P_Regler(1, 1, "", Color.Black).GetType())
                {
                    currentRegler = 1;
                }
                else
                {
                    currentRegler = 2;
                }
            }
            else
            {
                comboBox_regler.Text = "";
                txtBx_Kp.Text = "";
                txtBx_Kr.Text = "";
                txtBx_sollwert.Text = "";
                txtBx_Tn.Text = "";
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new Form_NewRegler(this).ShowDialog();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(reglerList.Count > 0)
            {
                DialogResult result = MessageBox.Show("Regler wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string name = comboBox_regler.SelectedItem.ToString();
                    foreach (Regler r in reglerList)
                    {
                        if (r.displayName == name)
                        {
                            reglerList.Remove(r);
                            break;
                        }
                    }
                    updateReglerList(0);
                }
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Regler selectedRegler = null;

            if(currentRegler != 0)
            {
                foreach (Regler r in reglerList)
                {
                    if (r.displayName == comboBox_regler.SelectedItem.ToString())
                    {
                        selectedRegler = r;
                    }
                }
            }

            if(currentRegler == 1)
            {
                P_Regler regler = (P_Regler)selectedRegler;
                
                if(regler.Kp != Convert.ToInt32(txtBx_Kp.Text))
                {
                    regler.Kp = Convert.ToInt32(txtBx_Kp.Text);
                    serialPort1.WriteLine("p" + regler.Kp + "e");
                }

                if(regler.sollwert != Convert.ToInt32(txtBx_sollwert.Text))
                {
                    regler.sollwert = Convert.ToInt32(txtBx_sollwert.Text);
                    serialPort1.WriteLine("w" + regler.sollwert + "e");
                }
            }
            else
            if(currentRegler == 2)
            {
                PI_Regler regler = (PI_Regler)selectedRegler;

                if (regler.Kr != Convert.ToInt32(txtBx_Kr.Text))
                {
                    regler.Kr = Convert.ToInt32(txtBx_Kp.Text);
                    serialPort1.WriteLine("k" + regler.Kr + "e");
                }

                if (regler.Tn != Convert.ToInt32(txtBx_Tn.Text))
                {
                    regler.Tn = Convert.ToInt32(txtBx_Tn.Text);
                    serialPort1.WriteLine("t" + regler.Tn + "e");
                }

                if (regler.sollwert != Convert.ToInt32(txtBx_sollwert.Text))
                {
                    regler.sollwert = Convert.ToInt32(txtBx_sollwert.Text);
                    serialPort1.WriteLine("w" + regler.sollwert + "e");
                }
            }
            else
            {
                MessageBox.Show("Es ist momentan kein Regler ausgewählt");
            }
        }

        private void btn_cmd_Click(object sender, EventArgs e)
        {
            if (btn_cmd.Text == "Regler starten")
            {
                Regler selectedRegler = null;

                if (currentRegler != 0)
                {
                    foreach (Regler r in reglerList)
                    {
                        if (r.displayName == comboBox_regler.SelectedItem.ToString())
                        {
                            selectedRegler = r;
                        }
                    }
                }

                if (currentRegler == 1)
                {
                    P_Regler regler = (P_Regler)selectedRegler;

                    if (regler.Kp != Convert.ToInt32(txtBx_Kp.Text))
                    {
                        regler.Kp = Convert.ToInt32(txtBx_Kp.Text);
                    }

                    if (regler.sollwert != Convert.ToInt32(txtBx_sollwert.Text))
                    {
                        regler.sollwert = Convert.ToInt32(txtBx_sollwert.Text);
                    }
                    serialPort1.WriteLine("p" + regler.Kp + "e");
                    serialPort1.WriteLine("w" + regler.sollwert + "e");
                    serialPort1.WriteLine("pstart");
                }
                else
                if (currentRegler == 2)
                {
                    PI_Regler regler = (PI_Regler)selectedRegler;

                    if (regler.Kr != Convert.ToInt32(txtBx_Kr.Text))
                    {
                        regler.Kr = Convert.ToInt32(txtBx_Kp.Text);
                    }

                    if (regler.Tn != Convert.ToInt32(txtBx_Tn.Text))
                    {
                        regler.Tn = Convert.ToInt32(txtBx_Tn.Text);
                    }

                    if (regler.sollwert != Convert.ToInt32(txtBx_sollwert.Text))
                    {
                        regler.sollwert = Convert.ToInt32(txtBx_sollwert.Text);
                    }
                    serialPort1.WriteLine("k" + regler.Kr + "e");
                    serialPort1.WriteLine("t" + regler.Tn + "e");
                    serialPort1.WriteLine("w" + regler.sollwert + "e");
                    serialPort1.WriteLine("pistart");
                }
                else
                {
                    MessageBox.Show("Es ist momentan kein Regler ausgewählt");
                }
                btn_cmd.Text = "Regler stoppen";
            }
            else
            {
                serialPort1.WriteLine("stop");
                serialPort1.DiscardOutBuffer();
                serialPort1.DiscardInBuffer();
                btn_cmd.Text = "Regler starten";
            }
        }
    }
}
