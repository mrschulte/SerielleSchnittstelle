namespace SerielleSchnittstelle_Projekte
{
    partial class Form_Dashboard
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
            this.label_zeitdiagramm = new System.Windows.Forms.Label();
            this.label_voltmeter = new System.Windows.Forms.Label();
            this.label_seriellekom = new System.Windows.Forms.Label();
            this.label_ampel = new System.Windows.Forms.Label();
            this.label_regler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_zeitdiagramm
            // 
            this.label_zeitdiagramm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_zeitdiagramm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_zeitdiagramm.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zeitdiagramm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label_zeitdiagramm.Location = new System.Drawing.Point(64, 48);
            this.label_zeitdiagramm.Name = "label_zeitdiagramm";
            this.label_zeitdiagramm.Size = new System.Drawing.Size(133, 35);
            this.label_zeitdiagramm.TabIndex = 1;
            this.label_zeitdiagramm.Text = "Zeitdiagramm";
            this.label_zeitdiagramm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_zeitdiagramm.Click += new System.EventHandler(this.label_zeitdiagramm_Click);
            // 
            // label_voltmeter
            // 
            this.label_voltmeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_voltmeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_voltmeter.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltmeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label_voltmeter.Location = new System.Drawing.Point(246, 48);
            this.label_voltmeter.Name = "label_voltmeter";
            this.label_voltmeter.Size = new System.Drawing.Size(130, 35);
            this.label_voltmeter.TabIndex = 3;
            this.label_voltmeter.Text = "Voltmeter";
            this.label_voltmeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_voltmeter.Click += new System.EventHandler(this.label_voltmeter_Click);
            // 
            // label_seriellekom
            // 
            this.label_seriellekom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_seriellekom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_seriellekom.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seriellekom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label_seriellekom.Location = new System.Drawing.Point(423, 48);
            this.label_seriellekom.Name = "label_seriellekom";
            this.label_seriellekom.Size = new System.Drawing.Size(130, 35);
            this.label_seriellekom.TabIndex = 5;
            this.label_seriellekom.Text = "Serielle Kommunikation";
            this.label_seriellekom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_seriellekom.Click += new System.EventHandler(this.label_seriellekom_Click);
            // 
            // label_ampel
            // 
            this.label_ampel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ampel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ampel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ampel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label_ampel.Location = new System.Drawing.Point(604, 48);
            this.label_ampel.Name = "label_ampel";
            this.label_ampel.Size = new System.Drawing.Size(130, 35);
            this.label_ampel.TabIndex = 7;
            this.label_ampel.Text = "Ampel";
            this.label_ampel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ampel.Click += new System.EventHandler(this.label_ampel_Click);
            // 
            // label_regler
            // 
            this.label_regler.BackColor = System.Drawing.Color.White;
            this.label_regler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_regler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_regler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_regler.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_regler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label_regler.Location = new System.Drawing.Point(64, 117);
            this.label_regler.Name = "label_regler";
            this.label_regler.Size = new System.Drawing.Size(130, 35);
            this.label_regler.TabIndex = 9;
            this.label_regler.Text = "Digitaler Regler";
            this.label_regler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_regler.Click += new System.EventHandler(this.label_regler_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 416);
            this.Controls.Add(this.label_regler);
            this.Controls.Add(this.label_ampel);
            this.Controls.Add(this.label_seriellekom);
            this.Controls.Add(this.label_voltmeter);
            this.Controls.Add(this.label_zeitdiagramm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_zeitdiagramm;
        private System.Windows.Forms.Label label_voltmeter;
        private System.Windows.Forms.Label label_seriellekom;
        private System.Windows.Forms.Label label_ampel;
        private System.Windows.Forms.Label label_regler;
    }
}

