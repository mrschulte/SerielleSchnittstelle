
namespace SerielleSchnittstelle_Projekte
{
    partial class DigitalerRegler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.comboBox_regler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txtBx_Kp = new System.Windows.Forms.TextBox();
            this.txtBx_Kr = new System.Windows.Forms.TextBox();
            this.txtBx_Tn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cmd = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_sollwert = new System.Windows.Forms.TextBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_resetall = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(556, 504);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dashboard.Location = new System.Drawing.Point(723, 12);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(75, 23);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // comboBox_regler
            // 
            this.comboBox_regler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_regler.Enabled = false;
            this.comboBox_regler.FormattingEnabled = true;
            this.comboBox_regler.Location = new System.Drawing.Point(677, 137);
            this.comboBox_regler.Name = "comboBox_regler";
            this.comboBox_regler.Size = new System.Drawing.Size(121, 21);
            this.comboBox_regler.TabIndex = 2;
            this.comboBox_regler.SelectedIndexChanged += new System.EventHandler(this.comboBox_regler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(760, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regler";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(677, 164);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(27, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Enabled = false;
            this.btn_remove.Location = new System.Drawing.Point(710, 164);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(27, 23);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "-";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txtBx_Kp
            // 
            this.txtBx_Kp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_Kp.Enabled = false;
            this.txtBx_Kp.Location = new System.Drawing.Point(677, 238);
            this.txtBx_Kp.Name = "txtBx_Kp";
            this.txtBx_Kp.Size = new System.Drawing.Size(121, 20);
            this.txtBx_Kp.TabIndex = 6;
            // 
            // txtBx_Kr
            // 
            this.txtBx_Kr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_Kr.Enabled = false;
            this.txtBx_Kr.Location = new System.Drawing.Point(677, 288);
            this.txtBx_Kr.Name = "txtBx_Kr";
            this.txtBx_Kr.Size = new System.Drawing.Size(121, 20);
            this.txtBx_Kr.TabIndex = 7;
            // 
            // txtBx_Tn
            // 
            this.txtBx_Tn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_Tn.Enabled = false;
            this.txtBx_Tn.Location = new System.Drawing.Point(677, 332);
            this.txtBx_Tn.Name = "txtBx_Tn";
            this.txtBx_Tn.Size = new System.Drawing.Size(121, 20);
            this.txtBx_Tn.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(778, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kp";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(778, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kr";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(775, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tn";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(680, 424);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 43);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Parameter updaten";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cmd
            // 
            this.btn_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmd.Enabled = false;
            this.btn_cmd.Location = new System.Drawing.Point(680, 473);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(118, 43);
            this.btn_cmd.TabIndex = 13;
            this.btn_cmd.Text = "Regler starten";
            this.btn_cmd.UseVisualStyleBackColor = true;
            this.btn_cmd.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "COM-Port";
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(677, 63);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ports.TabIndex = 14;
            this.comboBox_ports.DropDown += new System.EventHandler(this.comboBox_ports_DropDown);
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connect.Location = new System.Drawing.Point(677, 87);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(121, 22);
            this.btn_connect.TabIndex = 16;
            this.btn_connect.Text = "Verbinden";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(751, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sollwert";
            // 
            // txtBx_sollwert
            // 
            this.txtBx_sollwert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_sollwert.Enabled = false;
            this.txtBx_sollwert.Location = new System.Drawing.Point(677, 398);
            this.txtBx_sollwert.Name = "txtBx_sollwert";
            this.txtBx_sollwert.Size = new System.Drawing.Size(121, 20);
            this.txtBx_sollwert.TabIndex = 17;
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.Enabled = false;
            this.btn_settings.Location = new System.Drawing.Point(748, 164);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(47, 23);
            this.btn_settings.TabIndex = 19;
            this.btn_settings.Text = "Einst.";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.Enabled = false;
            this.btn_reset.Location = new System.Drawing.Point(677, 193);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(60, 23);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_resetall
            // 
            this.btn_resetall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resetall.Enabled = false;
            this.btn_resetall.Location = new System.Drawing.Point(738, 193);
            this.btn_resetall.Name = "btn_resetall";
            this.btn_resetall.Size = new System.Drawing.Size(60, 23);
            this.btn_resetall.TabIndex = 21;
            this.btn_resetall.Text = "Reset all";
            this.btn_resetall.UseVisualStyleBackColor = true;
            this.btn_resetall.Click += new System.EventHandler(this.btn_resetall_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(581, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 43);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Regler speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_import
            // 
            this.btn_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_import.Enabled = false;
            this.btn_import.Location = new System.Drawing.Point(581, 424);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(93, 43);
            this.btn_import.TabIndex = 23;
            this.btn_import.Text = "Regler importieren";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // DigitalerRegler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 528);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_resetall);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_sollwert);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_ports);
            this.Controls.Add(this.btn_cmd);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_Tn);
            this.Controls.Add(this.txtBx_Kr);
            this.Controls.Add(this.txtBx_Kp);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_regler);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.chart1);
            this.MinimumSize = new System.Drawing.Size(826, 567);
            this.Name = "DigitalerRegler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalerRegler";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.ComboBox comboBox_regler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txtBx_Kp;
        private System.Windows.Forms.TextBox txtBx_Kr;
        private System.Windows.Forms.TextBox txtBx_Tn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cmd;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBx_sollwert;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_resetall;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_import;
    }
}