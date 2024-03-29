﻿using System;
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

        


        private int currentRegler; // 0=keiner, 1=PRegler, 2=PIRegler, 3=Sprungantwort ( Kein Regler ) 
        double seconds;
        float rpm = 0;
        float rpm_alt = 0;

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
            if(comboBox_ports.Items.Count > 0)
                comboBox_ports.SelectedIndex = 0;
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
                        foreach(Control c in this.Controls)
                        {
                            c.Enabled = true;
                        }
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
                        foreach (Control c in this.Controls)
                        {
                            if(c != sender && c != comboBox_ports && c != btn_dashboard)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                    catch(Exception ex)
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

                System.Diagnostics.Debug.WriteLine(kp + " " + kr + " " + tn + " " + sollwert);

                reglerList.Clear();
                reglerList.Add(new P_Regler(kp, sollwert, "P-Beispiel", Color.Orange));
                reglerList.Add(new PI_Regler(kr, tn, sollwert, "PI-Beispiel", Color.GreenYellow));
                reglerList.Add(new Sprungantwort("Sprungantwort", Color.Red));
                loadRegler();
                
            }
            else
            {
                try
                {
                    /*System.Diagnostics.Debug.WriteLine("Line: " + line);
                    System.Diagnostics.Debug.WriteLine("Länge: " + line.Length);
                    System.Diagnostics.Debug.WriteLine("Next");*/

                    rpm = Convert.ToInt32(line);

                    if (line.Length > 0)
                    {
                        rpm = 0.8f * rpm_alt + 0.2f * rpm;
                        System.Diagnostics.Debug.WriteLine(rpm.ToString());
                        chart1.Series[comboBox_regler.SelectedItem.ToString()].Points.AddXY(seconds, rpm);
                        seconds += 0.1;
                        rpm_alt = rpm;
                    }
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }


        private void updateValues(Regler selectedRegler)
        {
            if (selectedRegler.GetType() == new P_Regler(1, 1, "", Color.Black).GetType())
            {
                P_Regler regler = (P_Regler)selectedRegler;
                txtBx_Kp.Enabled = true;
                txtBx_Kr.Enabled = false;
                txtBx_Tn.Enabled = false;
                txtBx_sollwert.Enabled = true;
                currentRegler = 1;
                txtBx_Kp.Text = regler.Kp.ToString();
                txtBx_Kr.Text = "";
                txtBx_Tn.Text = "";
                txtBx_sollwert.Text = regler.sollwert.ToString();
            }
            else
            if (selectedRegler.GetType() == new PI_Regler(1, 1, 1, "", Color.Black).GetType())
            {
                PI_Regler regler = (PI_Regler)selectedRegler;
                txtBx_Kp.Enabled = false;
                txtBx_Kr.Enabled = true;
                txtBx_Tn.Enabled = true;
                txtBx_sollwert.Enabled = true;
                currentRegler = 2;
                txtBx_Kp.Text = "";
                txtBx_Kr.Text = regler.Kr.ToString();
                txtBx_Tn.Text = regler.Tn.ToString();
                txtBx_sollwert.Text = regler.sollwert.ToString();
            }
            else
            if(selectedRegler.GetType().Name == "Sprungantwort")
            {
                currentRegler = 3;
                txtBx_Kp.Enabled = false;
                txtBx_Kr.Enabled = false;
                txtBx_Tn.Enabled = false;
                txtBx_sollwert.Enabled = false;
                txtBx_Kp.Text = "";
                txtBx_Kr.Text = "";
                txtBx_Tn.Text = "";
                txtBx_sollwert.Text = "";
            }
            else
            {
                currentRegler = 0;
            }
        }

        private void comboBox_regler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string displayname = comboBox_regler.SelectedItem.ToString();
            Regler selectedRegler = null;
            foreach(Regler r in reglerList)
            {
                if(r.displayName == displayname)
                {
                    selectedRegler = r;
                    break;
                }
            }
            System.Diagnostics.Debug.WriteLine(selectedRegler.GetType().Name);
            if (selectedRegler.GetType().Name == "P_Regler")
            {
                currentRegler = 1;
                btn_cmd.Text = "Regler starten";
            }
            else
            if (selectedRegler.GetType().Name == "PI_Regler")
            {
                currentRegler = 2;
                btn_cmd.Text = "Regler starten";
            }
            else
            if(selectedRegler.GetType().Name == "Sprungantwort")
            {
                currentRegler = 3;
                btn_cmd.Text = "Sprungantwort messen";
            }
            else
            {
                currentRegler = 0;
            }

            seconds = 0;
            rpm = 0;
            rpm_alt = 0;
            updateValues(selectedRegler);

        }

        /// <summary>
        /// Lädt alle Regler neu
        /// </summary>
        private void loadRegler()
        {
            chart1.Series.Clear();
            comboBox_regler.Items.Clear();

            foreach(Regler r in reglerList)
            {
                addRegler(r);
            }
            comboBox_regler.SelectedIndex = 0;
        }

        public void setIndex(Regler r)
        {
            comboBox_regler.SelectedIndex = comboBox_regler.Items.IndexOf(r.displayName);
        }

        public void addRegler(Regler r)
        {
            comboBox_regler.Items.Add(r.displayName);
            chart1.Series.Add(r.displayName);
            chart1.Series.FindByName(r.displayName).Color = r.displayColor;
            chart1.Series.FindByName(r.displayName).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series.FindByName(r.displayName).BorderWidth = 2;
        }

        private void removeRegler(Regler r)
        {
            comboBox_regler.Items.Remove(r.displayName);
            chart1.Series.Remove(chart1.Series.FindByName(r.displayName));
            reglerList.Remove(r);
            if(comboBox_regler.Items.Count > 0)
            {
                comboBox_regler.SelectedIndex = 0;
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
            if(reglerList.Count > 0 && comboBox_regler.SelectedItem.ToString().Length > 0)
            {
                DialogResult result = MessageBox.Show("Regler wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string name = comboBox_regler.SelectedItem.ToString();
                    foreach (Regler r in reglerList)
                    {
                        if (r.displayName == name)
                        {
                            removeRegler(r);
                            break;
                        }
                    }
                    rpm = 0;
                    rpm_alt = 0;
                    seconds = 0;
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
                    regler.Kr = Convert.ToInt32(txtBx_Kr.Text);
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
            if(currentRegler == 3)
            {
                serialPort1.WriteLine("s");
            }
            else
            {
                MessageBox.Show("Es ist momentan kein Regler ausgewählt");
            }
        }

        private void btn_cmd_Click(object sender, EventArgs e)
        {
            if (btn_cmd.Text == "Regler starten" || btn_cmd.Text == "Sprungantwort messen")
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
                    System.Diagnostics.Debug.WriteLine("P");
                    btn_cmd.Text = "Regler stoppen";
                }
                else
                if (currentRegler == 2)
                {
                    PI_Regler regler = (PI_Regler)selectedRegler;

                    if (regler.Kr != Convert.ToInt32(txtBx_Kr.Text))
                    {
                        regler.Kr = Convert.ToInt32(txtBx_Kr.Text);
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
                    System.Diagnostics.Debug.WriteLine("PI");
                    btn_cmd.Text = "Regler stoppen";
                }
                else
                if(currentRegler == 3)
                {
                    serialPort1.WriteLine("sastart");
                    btn_cmd.Text = "Messung stoppen";
                    System.Diagnostics.Debug.WriteLine("d");
                }
                else
                {
                    MessageBox.Show("Es ist momentan kein Regler ausgewählt");
                }
                
            }
            else
            {
                serialPort1.WriteLine("stop");
                serialPort1.DiscardOutBuffer();
                serialPort1.DiscardInBuffer();
                if (currentRegler != 3)
                {
                    btn_cmd.Text = "Regler starten";
                }
                else
                {
                    btn_cmd.Text = "Sprungantwort messen";
                }
            }
        }

        ///TODO
        private void btn_settings_Click(object sender, EventArgs e)
        {
            new Form_ReglerEinstellungen(this, comboBox_regler.Text).ShowDialog();
        }

        public void dicker()
        {
            chart1.Series[comboBox_regler.Text].BorderWidth++;
        }

        public void duenner()
        {
            if (chart1.Series[comboBox_regler.Text].BorderWidth > 1)
                chart1.Series[comboBox_regler.Text].BorderWidth--;
        }

        public System.Windows.Forms.DataVisualization.Charting.Chart getChart()
        {
            return chart1;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(comboBox_regler.SelectedItem.ToString().Length > 0)
            {
                DialogResult result = MessageBox.Show("Wollen Sie Wirklich die aufgenommenen Werte des ausgewählten Reglers löschen?", "Werte löschen", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    chart1.Series[comboBox_regler.SelectedItem.ToString()].Points.Clear();
                    rpm = 0;
                    rpm_alt = 0;
                    seconds = 0;
                }
            }
            
        }

        private void btn_resetall_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Wollen Sie Wirklich die aufgenommenen Werte aller Regler löschen?", "Werte löschen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach(Regler r in reglerList)
                {
                    chart1.Series[r.displayName].Points.Clear();
                }
                rpm = 0;
                rpm_alt = 0;
                seconds = 0;
            }
        }

        private void saveRegler()
        {
            if(!System.IO.File.Exists("regler"))
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("regler");

                foreach (Regler r in reglerList)
                {
                    writer.WriteLine(constructString(r));
                }
                writer.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Es gibt bereits eine gespeicherte Liste. Überschreiben?", "Liste überschreiben?", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("regler");

                    foreach (Regler r in reglerList)
                    {
                        writer.WriteLine(constructString(r));
                    }
                    writer.Close();
                }
            }
            
        }

        private string constructString(Regler r)
        {
            string reglerParameters = "";
            if (r.GetType().Name == "P_Regler")
            {
                P_Regler pr = (P_Regler)r;
                reglerParameters = "[1;" + pr.displayName + ";" + pr.displayColor.ToArgb() + ";" + pr.Kp + ";" + pr.sollwert + "]";
            }
            else
            if(r.GetType().Name == "PI_Regler")
            {
                PI_Regler pir = (PI_Regler)r;
                reglerParameters = "[2;" + pir.displayName + ";" + pir.displayColor.ToArgb() + ";" + pir.Kr + ";" + pir.Tn + ";" + pir.sollwert + "]";
            }
            else
            {
                Sprungantwort sa = (Sprungantwort)r;
                reglerParameters = "[3;" + sa.displayName + ";" + sa.displayColor.ToArgb() + "]";
            }
            return reglerParameters;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveRegler();
        }

        private void importRegler()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("regler");
            string line = null;
            int count = 0;
            while(true)
            {
                line = reader.ReadLine();
                if(line == null)
                {
                    break;
                }
                else
                {
                    if(count == 0)
                    {
                        reglerList.Clear();
                    }
                    count++;
                    Regler r = constructRegler(line);
                    reglerList.Add(r);
                }
            }
            loadRegler();
            reader.Close();
        }

        private Regler constructRegler(string line)
        {
            int kp = 0;
            int kr = 0;
            int tn = 0;
            int sollwert = 0;
            string displayname = "";
            Color displayColor;
            int[] indexlist = new int[5];
            
            if(line[1].ToString() == "1")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        indexlist[i] = line.IndexOf(";");
                    }
                    else
                    {
                        indexlist[i] = line.IndexOf(";", indexlist[i - 1]+1);
                    }
                }
                displayname = line.Substring(indexlist[0] + 1, indexlist[1] - indexlist[0] -1);
                displayColor = Color.FromArgb(Convert.ToInt32(line.Substring(indexlist[1] + 1, indexlist[2] - indexlist[1] - 1)));
                kp = Convert.ToInt32(line.Substring(indexlist[2] + 1, indexlist[3] - indexlist[2] - 1));
                sollwert = Convert.ToInt32(line.Substring(indexlist[3] + 1, line.Length - indexlist[3] - 2));
                return new P_Regler(kp, sollwert, displayname, displayColor);
            }
            else
            if(line[1].ToString() == "2")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                    {
                        indexlist[i] = line.IndexOf(";");
                    }
                    else
                    {
                        indexlist[i] = line.IndexOf(";", indexlist[i - 1] + 1);
                    }
                }
                displayname = line.Substring(indexlist[0] + 1, indexlist[1] - indexlist[0] - 1);
                displayColor = Color.FromArgb(Convert.ToInt32(line.Substring(indexlist[1] + 1, indexlist[2] - indexlist[1] - 1)));
                kr = Convert.ToInt32(line.Substring(indexlist[2] + 1, indexlist[3] - indexlist[2] - 1));
                tn = Convert.ToInt32(line.Substring(indexlist[3] + 1, indexlist[4] - indexlist[3] - 1));
                sollwert = Convert.ToInt32(line.Substring(indexlist[4] + 1, line.Length - indexlist[4] - 2));
                return new PI_Regler(kr, tn, sollwert, displayname, displayColor);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        indexlist[i] = line.IndexOf(";");
                    }
                    else
                    {
                        indexlist[i] = line.IndexOf(";", indexlist[i - 1] + 1);
                    }
                }
                displayname = line.Substring(indexlist[0] + 1, indexlist[1] - indexlist[0] - 1);
                displayColor = Color.FromArgb(Convert.ToInt32(line.Substring(indexlist[1] + 1, indexlist[2] - indexlist[1] - 1)));
                return new Sprungantwort(displayname, displayColor);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            importRegler();
        }

        private void btn_savePoints_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                System.IO.StreamWriter writer = new System.IO.StreamWriter(path);
                foreach (Regler r in reglerList)
                {
                    string constructedString = constructString(r);
                    string line = "{" + constructedString + "}:{";
                    for(int i = 0; i < chart1.Series[r.displayName].Points.Count; i++)
                    {
                        line += "[" + chart1.Series[r.displayName].Points[i].XValue + ";" + chart1.Series[r.displayName].Points[i].YValues[0] + "]";
                    }
                    line += "}";
                    writer.WriteLine(line);
                }
                writer.Close();
                MessageBox.Show("Die aufgenommenen Werte wurden gespeichert. Pfad: " + path);
            }
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            

            DialogResult result = saveFileDialog2.ShowDialog();

            if(result == DialogResult.OK)
            {
                string path = saveFileDialog2.FileName;
                chart1.SaveImage(path + ".jpeg", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
            }

        }
    }
}
