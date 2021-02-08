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
    public partial class Form_Kommunikation : Form
    {
        private string register { get; set; }
        private string registerIO { get; set; }
        private string registerBits { get; set; }

        public Form_Kommunikation()
        {
            InitializeComponent();
        }

        private void Form_Kommunikation_Load(object sender, EventArgs e)
        {
            rb_d.Checked = true;
            combobx_ports.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            combobx_ports.SelectedIndex = 0;
        }

        private void combobx_ports_DropDown(object sender, EventArgs e)
        {
            combobx_ports.Items.Clear();
            combobx_ports.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void rb_d_CheckedChanged(object sender, EventArgs e)
        {
            updateCommand();
        }

        private void rb_b_CheckedChanged(object sender, EventArgs e)
        {
            updateCommand();
        }

        private void rb_c_CheckedChanged(object sender, EventArgs e)
        {
            updateCommand();
        }

        private int BoolToInt(Boolean varbool)
        {
            if(varbool)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private void updateRegisterValue()
        {
            if(rb_d.Checked)
            {
                register = "D";
            }
            else
            if(rb_b.Checked)
            {
                register = "B";
            }
            else
            {
                register = "C";
            }
        }
        private void updateRegisterIOValues()
        {
            registerIO = BoolToInt(cbio_7.Checked).ToString();
            registerIO += BoolToInt(cbio_6.Checked).ToString();
            registerIO += BoolToInt(cbio_5.Checked).ToString();
            registerIO += BoolToInt(cbio_4.Checked).ToString();
            registerIO += BoolToInt(cbio_3.Checked).ToString();
            registerIO += BoolToInt(cbio_2.Checked).ToString();
            registerIO += BoolToInt(cbio_1.Checked).ToString();
            registerIO += BoolToInt(cbio_0.Checked).ToString();
        }

        private void updateRegisterBitsValues()
        {
            registerBits = BoolToInt(cbstate_7.Checked).ToString();
            registerBits += BoolToInt(cbstate_6.Checked).ToString();
            registerBits += BoolToInt(cbstate_5.Checked).ToString();
            registerBits += BoolToInt(cbstate_4.Checked).ToString();
            registerBits += BoolToInt(cbstate_3.Checked).ToString();
            registerBits += BoolToInt(cbstate_2.Checked).ToString();
            registerBits += BoolToInt(cbstate_1.Checked).ToString();
            registerBits += BoolToInt(cbstate_0.Checked).ToString();
        }

        private void updateCommand()
        {
            updateRegisterValue();
            updateRegisterIOValues();
            updateRegisterBitsValues();
            txtbx_command.Text = register + "|" + registerIO + "|" + registerBits;
        }

        private void cbio_7_CheckedChanged(object sender, EventArgs e)
        {
            cbio_7.Text = BoolToInt(cbio_7.Checked).ToString();
            updateCommand();
        }

        private void cbio_6_CheckedChanged(object sender, EventArgs e)
        {
            cbio_6.Text = BoolToInt(cbio_6.Checked).ToString();
            updateCommand();
        }

        private void cbio_5_CheckedChanged(object sender, EventArgs e)
        {
            cbio_5.Text = BoolToInt(cbio_5.Checked).ToString();
            updateCommand();
        }

        private void cbio_4_CheckedChanged(object sender, EventArgs e)
        {
            cbio_4.Text = BoolToInt(cbio_4.Checked).ToString();
            updateCommand();
        }

        private void cbio_3_CheckedChanged(object sender, EventArgs e)
        {
            cbio_3.Text = BoolToInt(cbio_3.Checked).ToString();
            updateCommand();
        }

        private void cbio_2_CheckedChanged(object sender, EventArgs e)
        {
            cbio_2.Text = BoolToInt(cbio_2.Checked).ToString();
            updateCommand();
        }

        private void cbio_1_CheckedChanged(object sender, EventArgs e)
        {
            cbio_1.Text = BoolToInt(cbio_1.Checked).ToString();
            updateCommand();
        }

        private void cbio_0_CheckedChanged(object sender, EventArgs e)
        {
            cbio_0.Text = BoolToInt(cbio_0.Checked).ToString();
            updateCommand();
        }

        private void cbstate_7_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_7.Text = BoolToInt(cbstate_7.Checked).ToString();
            updateCommand();
        }

        private void cbstate_6_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_6.Text = BoolToInt(cbstate_6.Checked).ToString();
            updateCommand();
        }

        private void cbstate_5_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_5.Text = BoolToInt(cbstate_5.Checked).ToString();
            updateCommand();
        }

        private void cbstate_4_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_4.Text = BoolToInt(cbstate_4.Checked).ToString();
            updateCommand();
        }

        private void cbstate_3_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_3.Text = BoolToInt(cbstate_3.Checked).ToString();
            updateCommand();
        }

        private void cbstate_2_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_2.Text = BoolToInt(cbstate_2.Checked).ToString();
            updateCommand();
        }

        private void cbstate_1_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_1.Text = BoolToInt(cbstate_1.Checked).ToString();
            updateCommand();
        }

        private void cbstate_0_CheckedChanged(object sender, EventArgs e)
        {
            cbstate_0.Text = BoolToInt(cbstate_0.Checked).ToString();
            updateCommand();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(txtbx_command.Text.Length != 0)
            {
                if(serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.WriteLine(txtbx_command.Text);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    btn_connect.Text = "Verbinden";
                }
                else
                {
                    serialPort1.PortName = combobx_ports.Text;
                    serialPort1.Open();
                    btn_connect.Text = "Trennen";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
