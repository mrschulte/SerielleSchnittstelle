
namespace SerielleSchnittstelle_Projekte
{
    partial class Form_NewRegler
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtn_p = new System.Windows.Forms.RadioButton();
            this.radioBtn_pi = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_sollwert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_Tn = new System.Windows.Forms.TextBox();
            this.txtBx_Kr = new System.Windows.Forms.TextBox();
            this.txtBx_Kp = new System.Windows.Forms.TextBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_abbr = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // radioBtn_p
            // 
            this.radioBtn_p.AutoSize = true;
            this.radioBtn_p.Location = new System.Drawing.Point(12, 67);
            this.radioBtn_p.Name = "radioBtn_p";
            this.radioBtn_p.Size = new System.Drawing.Size(66, 17);
            this.radioBtn_p.TabIndex = 2;
            this.radioBtn_p.TabStop = true;
            this.radioBtn_p.Text = "P-Regler";
            this.radioBtn_p.UseVisualStyleBackColor = true;
            this.radioBtn_p.CheckedChanged += new System.EventHandler(this.radioBtn_p_CheckedChanged);
            // 
            // radioBtn_pi
            // 
            this.radioBtn_pi.AutoSize = true;
            this.radioBtn_pi.Location = new System.Drawing.Point(12, 90);
            this.radioBtn_pi.Name = "radioBtn_pi";
            this.radioBtn_pi.Size = new System.Drawing.Size(69, 17);
            this.radioBtn_pi.TabIndex = 3;
            this.radioBtn_pi.TabStop = true;
            this.radioBtn_pi.Text = "PI-Regler";
            this.radioBtn_pi.UseVisualStyleBackColor = true;
            this.radioBtn_pi.CheckedChanged += new System.EventHandler(this.radioBtn_pi_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sollwert";
            // 
            // txtBx_sollwert
            // 
            this.txtBx_sollwert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBx_sollwert.Location = new System.Drawing.Point(12, 283);
            this.txtBx_sollwert.Name = "txtBx_sollwert";
            this.txtBx_sollwert.Size = new System.Drawing.Size(157, 20);
            this.txtBx_sollwert.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tn";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kr";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kp";
            // 
            // txtBx_Tn
            // 
            this.txtBx_Tn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBx_Tn.Location = new System.Drawing.Point(12, 235);
            this.txtBx_Tn.Name = "txtBx_Tn";
            this.txtBx_Tn.Size = new System.Drawing.Size(157, 20);
            this.txtBx_Tn.TabIndex = 21;
            // 
            // txtBx_Kr
            // 
            this.txtBx_Kr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBx_Kr.Location = new System.Drawing.Point(12, 191);
            this.txtBx_Kr.Name = "txtBx_Kr";
            this.txtBx_Kr.Size = new System.Drawing.Size(157, 20);
            this.txtBx_Kr.TabIndex = 20;
            // 
            // txtBx_Kp
            // 
            this.txtBx_Kp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBx_Kp.Location = new System.Drawing.Point(12, 144);
            this.txtBx_Kp.Name = "txtBx_Kp";
            this.txtBx_Kp.Size = new System.Drawing.Size(157, 20);
            this.txtBx_Kp.TabIndex = 19;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(12, 309);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(69, 23);
            this.btn_color.TabIndex = 27;
            this.btn_color.Text = "Farbe";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(100, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(69, 23);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_abbr
            // 
            this.btn_abbr.Location = new System.Drawing.Point(56, 338);
            this.btn_abbr.Name = "btn_abbr";
            this.btn_abbr.Size = new System.Drawing.Size(69, 23);
            this.btn_abbr.TabIndex = 29;
            this.btn_abbr.Text = "Abbrechen";
            this.btn_abbr.UseVisualStyleBackColor = true;
            this.btn_abbr.Click += new System.EventHandler(this.btn_abbr_Click);
            // 
            // Form_NewRegler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 370);
            this.Controls.Add(this.btn_abbr);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_sollwert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_Tn);
            this.Controls.Add(this.txtBx_Kr);
            this.Controls.Add(this.txtBx_Kp);
            this.Controls.Add(this.radioBtn_pi);
            this.Controls.Add(this.radioBtn_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NewRegler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NewRegler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtn_p;
        private System.Windows.Forms.RadioButton radioBtn_pi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBx_sollwert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_Tn;
        private System.Windows.Forms.TextBox txtBx_Kr;
        private System.Windows.Forms.TextBox txtBx_Kp;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_abbr;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}