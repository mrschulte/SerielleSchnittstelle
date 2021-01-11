namespace SerielleSchnittstelle_Projekte
{
    partial class Form_Voltmeter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_data = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.checkBox_console = new System.Windows.Forms.CheckBox();
            this.label_voltage1 = new System.Windows.Forms.Label();
            this.label_voltage2 = new System.Windows.Forms.Label();
            this.value_voltage1 = new System.Windows.Forms.Label();
            this.value_voltage2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(41, 56);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(173, 21);
            this.comboBox_ports.Sorted = true;
            this.comboBox_ports.TabIndex = 0;
            this.comboBox_ports.DropDown += new System.EventHandler(this.comboBox_ports_DropDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM-Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBx_data
            // 
            this.txtBx_data.Location = new System.Drawing.Point(417, 56);
            this.txtBx_data.Multiline = true;
            this.txtBx_data.Name = "txtBx_data";
            this.txtBx_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_data.Size = new System.Drawing.Size(288, 356);
            this.txtBx_data.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_connect.FlatAppearance.BorderSize = 2;
            this.btn_connect.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_connect.Location = new System.Drawing.Point(41, 95);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(173, 30);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Verbinden";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // checkBox_console
            // 
            this.checkBox_console.AutoSize = true;
            this.checkBox_console.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBox_console.Location = new System.Drawing.Point(596, 418);
            this.checkBox_console.Name = "checkBox_console";
            this.checkBox_console.Size = new System.Drawing.Size(109, 20);
            this.checkBox_console.TabIndex = 4;
            this.checkBox_console.Text = "Show Console";
            this.checkBox_console.UseVisualStyleBackColor = true;
            this.checkBox_console.CheckedChanged += new System.EventHandler(this.checkBox_console_CheckedChanged);
            // 
            // label_voltage1
            // 
            this.label_voltage1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltage1.Location = new System.Drawing.Point(38, 175);
            this.label_voltage1.Name = "label_voltage1";
            this.label_voltage1.Size = new System.Drawing.Size(100, 23);
            this.label_voltage1.TabIndex = 5;
            this.label_voltage1.Text = "Spannung 1";
            this.label_voltage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_voltage2
            // 
            this.label_voltage2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_voltage2.Location = new System.Drawing.Point(38, 243);
            this.label_voltage2.Name = "label_voltage2";
            this.label_voltage2.Size = new System.Drawing.Size(100, 29);
            this.label_voltage2.TabIndex = 6;
            this.label_voltage2.Text = "Spannung 2";
            this.label_voltage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // value_voltage1
            // 
            this.value_voltage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.value_voltage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_voltage1.Location = new System.Drawing.Point(38, 201);
            this.value_voltage1.Name = "value_voltage1";
            this.value_voltage1.Size = new System.Drawing.Size(100, 23);
            this.value_voltage1.TabIndex = 7;
            this.value_voltage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // value_voltage2
            // 
            this.value_voltage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.value_voltage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_voltage2.Location = new System.Drawing.Point(38, 272);
            this.value_voltage2.Name = "value_voltage2";
            this.value_voltage2.Size = new System.Drawing.Size(100, 23);
            this.value_voltage2.TabIndex = 8;
            this.value_voltage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "[V]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "[V]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Location = new System.Drawing.Point(630, 12);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(75, 23);
            this.btn_dashboard.TabIndex = 11;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // Form_Voltmeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_voltage2);
            this.Controls.Add(this.value_voltage1);
            this.Controls.Add(this.label_voltage2);
            this.Controls.Add(this.label_voltage1);
            this.Controls.Add(this.checkBox_console);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txtBx_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ports);
            this.Name = "Form_Voltmeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Voltmeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_data;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.CheckBox checkBox_console;
        private System.Windows.Forms.Label label_voltage1;
        private System.Windows.Forms.Label label_voltage2;
        private System.Windows.Forms.Label value_voltage1;
        private System.Windows.Forms.Label value_voltage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dashboard;
    }
}

