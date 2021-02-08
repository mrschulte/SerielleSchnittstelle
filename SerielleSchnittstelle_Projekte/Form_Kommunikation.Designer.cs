namespace SerielleSchnittstelle_Projekte
{
    partial class Form_Kommunikation
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
            this.combobx_ports = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txtbx_command = new System.Windows.Forms.TextBox();
            this.rb_d = new System.Windows.Forms.RadioButton();
            this.rb_c = new System.Windows.Forms.RadioButton();
            this.rb_b = new System.Windows.Forms.RadioButton();
            this.cbio_7 = new System.Windows.Forms.CheckBox();
            this.cbio_6 = new System.Windows.Forms.CheckBox();
            this.cbio_4 = new System.Windows.Forms.CheckBox();
            this.cbio_5 = new System.Windows.Forms.CheckBox();
            this.cbio_0 = new System.Windows.Forms.CheckBox();
            this.cbio_1 = new System.Windows.Forms.CheckBox();
            this.cbio_2 = new System.Windows.Forms.CheckBox();
            this.cbio_3 = new System.Windows.Forms.CheckBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.cbstate_0 = new System.Windows.Forms.CheckBox();
            this.cbstate_1 = new System.Windows.Forms.CheckBox();
            this.cbstate_2 = new System.Windows.Forms.CheckBox();
            this.cbstate_3 = new System.Windows.Forms.CheckBox();
            this.cbstate_4 = new System.Windows.Forms.CheckBox();
            this.cbstate_5 = new System.Windows.Forms.CheckBox();
            this.cbstate_6 = new System.Windows.Forms.CheckBox();
            this.cbstate_7 = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // combobx_ports
            // 
            this.combobx_ports.FormattingEnabled = true;
            this.combobx_ports.Location = new System.Drawing.Point(12, 28);
            this.combobx_ports.Name = "combobx_ports";
            this.combobx_ports.Size = new System.Drawing.Size(121, 21);
            this.combobx_ports.TabIndex = 0;
            this.combobx_ports.DropDown += new System.EventHandler(this.combobx_ports_DropDown);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 55);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(121, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Verbinden";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txtbx_command
            // 
            this.txtbx_command.Location = new System.Drawing.Point(12, 125);
            this.txtbx_command.Name = "txtbx_command";
            this.txtbx_command.Size = new System.Drawing.Size(429, 20);
            this.txtbx_command.TabIndex = 2;
            // 
            // rb_d
            // 
            this.rb_d.AutoSize = true;
            this.rb_d.Location = new System.Drawing.Point(142, 28);
            this.rb_d.Name = "rb_d";
            this.rb_d.Size = new System.Drawing.Size(57, 17);
            this.rb_d.TabIndex = 3;
            this.rb_d.TabStop = true;
            this.rb_d.Text = "DDRD";
            this.rb_d.UseVisualStyleBackColor = true;
            this.rb_d.CheckedChanged += new System.EventHandler(this.rb_d_CheckedChanged);
            // 
            // rb_c
            // 
            this.rb_c.AutoSize = true;
            this.rb_c.Location = new System.Drawing.Point(267, 28);
            this.rb_c.Name = "rb_c";
            this.rb_c.Size = new System.Drawing.Size(56, 17);
            this.rb_c.TabIndex = 4;
            this.rb_c.TabStop = true;
            this.rb_c.Text = "DDRC";
            this.rb_c.UseVisualStyleBackColor = true;
            this.rb_c.CheckedChanged += new System.EventHandler(this.rb_c_CheckedChanged);
            // 
            // rb_b
            // 
            this.rb_b.AutoSize = true;
            this.rb_b.Location = new System.Drawing.Point(205, 28);
            this.rb_b.Name = "rb_b";
            this.rb_b.Size = new System.Drawing.Size(56, 17);
            this.rb_b.TabIndex = 5;
            this.rb_b.TabStop = true;
            this.rb_b.Text = "DDRB";
            this.rb_b.UseVisualStyleBackColor = true;
            this.rb_b.CheckedChanged += new System.EventHandler(this.rb_b_CheckedChanged);
            // 
            // cbio_7
            // 
            this.cbio_7.AutoSize = true;
            this.cbio_7.Location = new System.Drawing.Point(142, 59);
            this.cbio_7.Name = "cbio_7";
            this.cbio_7.Size = new System.Drawing.Size(32, 17);
            this.cbio_7.TabIndex = 6;
            this.cbio_7.Text = "0";
            this.cbio_7.UseVisualStyleBackColor = true;
            this.cbio_7.CheckedChanged += new System.EventHandler(this.cbio_7_CheckedChanged);
            // 
            // cbio_6
            // 
            this.cbio_6.AutoSize = true;
            this.cbio_6.Location = new System.Drawing.Point(180, 59);
            this.cbio_6.Name = "cbio_6";
            this.cbio_6.Size = new System.Drawing.Size(32, 17);
            this.cbio_6.TabIndex = 7;
            this.cbio_6.Text = "0";
            this.cbio_6.UseVisualStyleBackColor = true;
            this.cbio_6.CheckedChanged += new System.EventHandler(this.cbio_6_CheckedChanged);
            // 
            // cbio_4
            // 
            this.cbio_4.AutoSize = true;
            this.cbio_4.Location = new System.Drawing.Point(256, 59);
            this.cbio_4.Name = "cbio_4";
            this.cbio_4.Size = new System.Drawing.Size(32, 17);
            this.cbio_4.TabIndex = 9;
            this.cbio_4.Text = "0";
            this.cbio_4.UseVisualStyleBackColor = true;
            this.cbio_4.CheckedChanged += new System.EventHandler(this.cbio_4_CheckedChanged);
            // 
            // cbio_5
            // 
            this.cbio_5.AutoSize = true;
            this.cbio_5.Location = new System.Drawing.Point(218, 59);
            this.cbio_5.Name = "cbio_5";
            this.cbio_5.Size = new System.Drawing.Size(32, 17);
            this.cbio_5.TabIndex = 8;
            this.cbio_5.Text = "0";
            this.cbio_5.UseVisualStyleBackColor = true;
            this.cbio_5.CheckedChanged += new System.EventHandler(this.cbio_5_CheckedChanged);
            // 
            // cbio_0
            // 
            this.cbio_0.AutoSize = true;
            this.cbio_0.Location = new System.Drawing.Point(405, 59);
            this.cbio_0.Name = "cbio_0";
            this.cbio_0.Size = new System.Drawing.Size(32, 17);
            this.cbio_0.TabIndex = 13;
            this.cbio_0.Text = "0";
            this.cbio_0.UseVisualStyleBackColor = true;
            this.cbio_0.CheckedChanged += new System.EventHandler(this.cbio_0_CheckedChanged);
            // 
            // cbio_1
            // 
            this.cbio_1.AutoSize = true;
            this.cbio_1.Location = new System.Drawing.Point(367, 59);
            this.cbio_1.Name = "cbio_1";
            this.cbio_1.Size = new System.Drawing.Size(32, 17);
            this.cbio_1.TabIndex = 12;
            this.cbio_1.Text = "0";
            this.cbio_1.UseVisualStyleBackColor = true;
            this.cbio_1.CheckedChanged += new System.EventHandler(this.cbio_1_CheckedChanged);
            // 
            // cbio_2
            // 
            this.cbio_2.AutoSize = true;
            this.cbio_2.Location = new System.Drawing.Point(329, 59);
            this.cbio_2.Name = "cbio_2";
            this.cbio_2.Size = new System.Drawing.Size(32, 17);
            this.cbio_2.TabIndex = 11;
            this.cbio_2.Text = "0";
            this.cbio_2.UseVisualStyleBackColor = true;
            this.cbio_2.CheckedChanged += new System.EventHandler(this.cbio_2_CheckedChanged);
            // 
            // cbio_3
            // 
            this.cbio_3.AutoSize = true;
            this.cbio_3.Location = new System.Drawing.Point(291, 59);
            this.cbio_3.Name = "cbio_3";
            this.cbio_3.Size = new System.Drawing.Size(32, 17);
            this.cbio_3.TabIndex = 10;
            this.cbio_3.Text = "0";
            this.cbio_3.UseVisualStyleBackColor = true;
            this.cbio_3.CheckedChanged += new System.EventHandler(this.cbio_3_CheckedChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 151);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(89, 23);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cbstate_0
            // 
            this.cbstate_0.AutoSize = true;
            this.cbstate_0.Location = new System.Drawing.Point(405, 82);
            this.cbstate_0.Name = "cbstate_0";
            this.cbstate_0.Size = new System.Drawing.Size(32, 17);
            this.cbstate_0.TabIndex = 22;
            this.cbstate_0.Text = "0";
            this.cbstate_0.UseVisualStyleBackColor = true;
            this.cbstate_0.CheckedChanged += new System.EventHandler(this.cbstate_0_CheckedChanged);
            // 
            // cbstate_1
            // 
            this.cbstate_1.AutoSize = true;
            this.cbstate_1.Location = new System.Drawing.Point(367, 82);
            this.cbstate_1.Name = "cbstate_1";
            this.cbstate_1.Size = new System.Drawing.Size(32, 17);
            this.cbstate_1.TabIndex = 21;
            this.cbstate_1.Text = "0";
            this.cbstate_1.UseVisualStyleBackColor = true;
            this.cbstate_1.CheckedChanged += new System.EventHandler(this.cbstate_1_CheckedChanged);
            // 
            // cbstate_2
            // 
            this.cbstate_2.AutoSize = true;
            this.cbstate_2.Location = new System.Drawing.Point(329, 82);
            this.cbstate_2.Name = "cbstate_2";
            this.cbstate_2.Size = new System.Drawing.Size(32, 17);
            this.cbstate_2.TabIndex = 20;
            this.cbstate_2.Text = "0";
            this.cbstate_2.UseVisualStyleBackColor = true;
            this.cbstate_2.CheckedChanged += new System.EventHandler(this.cbstate_2_CheckedChanged);
            // 
            // cbstate_3
            // 
            this.cbstate_3.AutoSize = true;
            this.cbstate_3.Location = new System.Drawing.Point(291, 82);
            this.cbstate_3.Name = "cbstate_3";
            this.cbstate_3.Size = new System.Drawing.Size(32, 17);
            this.cbstate_3.TabIndex = 19;
            this.cbstate_3.Text = "0";
            this.cbstate_3.UseVisualStyleBackColor = true;
            this.cbstate_3.CheckedChanged += new System.EventHandler(this.cbstate_3_CheckedChanged);
            // 
            // cbstate_4
            // 
            this.cbstate_4.AutoSize = true;
            this.cbstate_4.Location = new System.Drawing.Point(256, 82);
            this.cbstate_4.Name = "cbstate_4";
            this.cbstate_4.Size = new System.Drawing.Size(32, 17);
            this.cbstate_4.TabIndex = 18;
            this.cbstate_4.Text = "0";
            this.cbstate_4.UseVisualStyleBackColor = true;
            this.cbstate_4.CheckedChanged += new System.EventHandler(this.cbstate_4_CheckedChanged);
            // 
            // cbstate_5
            // 
            this.cbstate_5.AutoSize = true;
            this.cbstate_5.Location = new System.Drawing.Point(218, 82);
            this.cbstate_5.Name = "cbstate_5";
            this.cbstate_5.Size = new System.Drawing.Size(32, 17);
            this.cbstate_5.TabIndex = 17;
            this.cbstate_5.Text = "0";
            this.cbstate_5.UseVisualStyleBackColor = true;
            this.cbstate_5.CheckedChanged += new System.EventHandler(this.cbstate_5_CheckedChanged);
            // 
            // cbstate_6
            // 
            this.cbstate_6.AutoSize = true;
            this.cbstate_6.Location = new System.Drawing.Point(180, 82);
            this.cbstate_6.Name = "cbstate_6";
            this.cbstate_6.Size = new System.Drawing.Size(32, 17);
            this.cbstate_6.TabIndex = 16;
            this.cbstate_6.Text = "0";
            this.cbstate_6.UseVisualStyleBackColor = true;
            this.cbstate_6.CheckedChanged += new System.EventHandler(this.cbstate_6_CheckedChanged);
            // 
            // cbstate_7
            // 
            this.cbstate_7.AutoSize = true;
            this.cbstate_7.Location = new System.Drawing.Point(142, 82);
            this.cbstate_7.Name = "cbstate_7";
            this.cbstate_7.Size = new System.Drawing.Size(32, 17);
            this.cbstate_7.TabIndex = 15;
            this.cbstate_7.Text = "0";
            this.cbstate_7.UseVisualStyleBackColor = true;
            this.cbstate_7.CheckedChanged += new System.EventHandler(this.cbstate_7_CheckedChanged);
            // 
            // Form_Kommunikation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 186);
            this.Controls.Add(this.cbstate_0);
            this.Controls.Add(this.cbstate_1);
            this.Controls.Add(this.cbstate_2);
            this.Controls.Add(this.cbstate_3);
            this.Controls.Add(this.cbstate_4);
            this.Controls.Add(this.cbstate_5);
            this.Controls.Add(this.cbstate_6);
            this.Controls.Add(this.cbstate_7);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.cbio_0);
            this.Controls.Add(this.cbio_1);
            this.Controls.Add(this.cbio_2);
            this.Controls.Add(this.cbio_3);
            this.Controls.Add(this.cbio_4);
            this.Controls.Add(this.cbio_5);
            this.Controls.Add(this.cbio_6);
            this.Controls.Add(this.cbio_7);
            this.Controls.Add(this.rb_b);
            this.Controls.Add(this.rb_c);
            this.Controls.Add(this.rb_d);
            this.Controls.Add(this.txtbx_command);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.combobx_ports);
            this.Name = "Form_Kommunikation";
            this.Text = "Form_Kommunikation";
            this.Load += new System.EventHandler(this.Form_Kommunikation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobx_ports;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txtbx_command;
        private System.Windows.Forms.RadioButton rb_d;
        private System.Windows.Forms.RadioButton rb_c;
        private System.Windows.Forms.RadioButton rb_b;
        private System.Windows.Forms.CheckBox cbio_7;
        private System.Windows.Forms.CheckBox cbio_6;
        private System.Windows.Forms.CheckBox cbio_4;
        private System.Windows.Forms.CheckBox cbio_5;
        private System.Windows.Forms.CheckBox cbio_0;
        private System.Windows.Forms.CheckBox cbio_1;
        private System.Windows.Forms.CheckBox cbio_2;
        private System.Windows.Forms.CheckBox cbio_3;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.CheckBox cbstate_0;
        private System.Windows.Forms.CheckBox cbstate_1;
        private System.Windows.Forms.CheckBox cbstate_2;
        private System.Windows.Forms.CheckBox cbstate_3;
        private System.Windows.Forms.CheckBox cbstate_4;
        private System.Windows.Forms.CheckBox cbstate_5;
        private System.Windows.Forms.CheckBox cbstate_6;
        private System.Windows.Forms.CheckBox cbstate_7;
        private System.IO.Ports.SerialPort serialPort1;
    }
}