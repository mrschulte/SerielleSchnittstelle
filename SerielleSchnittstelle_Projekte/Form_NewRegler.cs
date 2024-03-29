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
    public partial class Form_NewRegler : Form
    {
        Color displayColor;
        DigitalerRegler digReglerInstance;
        public Form_NewRegler(DigitalerRegler digRegler)
        {
            InitializeComponent();
            digReglerInstance = digRegler;
        }

        private void btn_abbr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                displayColor = colorDialog1.Color;
            }
            else
            {
                displayColor = Color.Gainsboro;
            }
        }

        private void radioBtn_p_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtn_p.Checked)
            {
                txtBx_Kp.Enabled = true;
                txtBx_Kr.Enabled = false;
                txtBx_Tn.Enabled = false;
                txtBx_sollwert.Enabled = true;
            }
        }

        private void radioBtn_pi_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtn_pi.Checked)
            {
                txtBx_Kp.Enabled = false;
                txtBx_Kr.Enabled = true;
                txtBx_Tn.Enabled = true;
                txtBx_sollwert.Enabled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(radioBtn_p.Checked)
            {
                try
                {
                    int ok = 1;
                    int kp = Convert.ToInt32(txtBx_Kp.Text);
                    int sollwert = Convert.ToInt32(txtBx_sollwert.Text);
                    string displayname = txt_name.Text;

                    foreach(Regler r in digReglerInstance.reglerList)
                    {
                        if(r.displayName == displayname)
                        {
                            MessageBox.Show("Es gibt bereits einen Regler mit diesem Namen");
                            ok = 0;
                            break;
                        }

                        if(r.displayColor == displayColor || displayColor == Color.Gainsboro)
                        {
                            MessageBox.Show("Diese Farbe ist nicht verfügbar");
                            ok = 0;
                            break;
                        }

                    }

                    if(ok == 1)
                    {
                        P_Regler r = new P_Regler(kp, sollwert, displayname, displayColor);
                        digReglerInstance.reglerList.Add(r);
                        digReglerInstance.addRegler(r);
                        digReglerInstance.setIndex(r);
                        this.Close();
                    }


                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            if (radioBtn_pi.Checked)
            {
                try
                {
                    int ok = 1;
                    int kr = Convert.ToInt32(txtBx_Kr.Text);
                    int tn = Convert.ToInt32(txtBx_Tn.Text);
                    int sollwert = Convert.ToInt32(txtBx_sollwert.Text);
                    string displayname = txt_name.Text;

                    foreach (Regler r in digReglerInstance.reglerList)
                    {
                        if (r.displayName == displayname)
                        {
                            MessageBox.Show("Es gibt bereits einen Regler mit diesem Namen");
                            ok = 0;
                            break;
                        }

                        if (r.displayColor == displayColor || displayColor == Color.Gainsboro)
                        {
                            MessageBox.Show("Diese Farbe ist nicht verfügbar");
                            ok = 0;
                            break;
                        }

                    }

                    if (ok == 1)
                    {
                        PI_Regler r = new PI_Regler(kr, tn, sollwert, displayname, displayColor);
                        digReglerInstance.reglerList.Add(r);
                        digReglerInstance.addRegler(r);
                        digReglerInstance.setIndex(r);
                        this.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            if(radioBt_sa.Checked)
            {
                try
                {
                    int ok = 1;
                    string displayname = txt_name.Text;

                    foreach (Regler r in digReglerInstance.reglerList)
                    {
                        if (r.displayName == displayname)
                        {
                            MessageBox.Show("Es gibt bereits einen Regler mit diesem Namen");
                            ok = 0;
                            break;
                        }

                        if (r.displayColor == displayColor || displayColor == Color.Gainsboro)
                        {
                            MessageBox.Show("Diese Farbe ist nicht verfügbar");
                            ok = 0;
                            break;
                        }

                    }

                    if (ok == 1)
                    {
                        Sprungantwort sa = new Sprungantwort(displayname, displayColor);
                        digReglerInstance.reglerList.Add(sa);
                        digReglerInstance.addRegler(sa);
                        digReglerInstance.setIndex(sa);
                        this.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioBt_sa_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBt_sa.Checked)
            {
                txtBx_Kp.Enabled = false;
                txtBx_Kr.Enabled = false;
                txtBx_sollwert.Enabled = false;
                txtBx_Tn.Enabled = false;
            }
        }
    }
}
