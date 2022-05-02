
namespace SerielleSchnittstelle_Projekte
{
    partial class Form_ReglerEinstellungen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dicker = new System.Windows.Forms.Button();
            this.btn_duenner = new System.Windows.Forms.Button();
            this.checkBx_show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linienbreite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dicker
            // 
            this.btn_dicker.Location = new System.Drawing.Point(15, 25);
            this.btn_dicker.Name = "btn_dicker";
            this.btn_dicker.Size = new System.Drawing.Size(30, 30);
            this.btn_dicker.TabIndex = 1;
            this.btn_dicker.Text = "+";
            this.btn_dicker.UseVisualStyleBackColor = true;
            this.btn_dicker.Click += new System.EventHandler(this.btn_dicker_Click);
            // 
            // btn_duenner
            // 
            this.btn_duenner.Location = new System.Drawing.Point(51, 25);
            this.btn_duenner.Name = "btn_duenner";
            this.btn_duenner.Size = new System.Drawing.Size(30, 30);
            this.btn_duenner.TabIndex = 2;
            this.btn_duenner.Text = "-";
            this.btn_duenner.UseVisualStyleBackColor = true;
            this.btn_duenner.Click += new System.EventHandler(this.btn_duenner_Click);
            // 
            // checkBx_show
            // 
            this.checkBx_show.AutoSize = true;
            this.checkBx_show.Location = new System.Drawing.Point(15, 74);
            this.checkBx_show.Name = "checkBx_show";
            this.checkBx_show.Size = new System.Drawing.Size(79, 17);
            this.checkBx_show.TabIndex = 3;
            this.checkBx_show.Text = "Einblenden";
            this.checkBx_show.UseVisualStyleBackColor = true;
            this.checkBx_show.CheckedChanged += new System.EventHandler(this.checkBx_show_CheckedChanged);
            // 
            // Form_ReglerEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(103, 114);
            this.Controls.Add(this.checkBx_show);
            this.Controls.Add(this.btn_duenner);
            this.Controls.Add(this.btn_dicker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ReglerEinstellungen";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dicker;
        private System.Windows.Forms.Button btn_duenner;
        private System.Windows.Forms.CheckBox checkBx_show;
    }
}