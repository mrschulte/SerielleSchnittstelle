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
            this.btn_zeitdiagramm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltmeter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_seriellekommunikation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ampel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zeitdiagramm
            // 
            this.btn_zeitdiagramm.BackColor = System.Drawing.Color.DarkGray;
            this.btn_zeitdiagramm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zeitdiagramm.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zeitdiagramm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_zeitdiagramm.Location = new System.Drawing.Point(67, 86);
            this.btn_zeitdiagramm.Name = "btn_zeitdiagramm";
            this.btn_zeitdiagramm.Size = new System.Drawing.Size(130, 30);
            this.btn_zeitdiagramm.TabIndex = 0;
            this.btn_zeitdiagramm.Text = "Programm starten";
            this.btn_zeitdiagramm.UseVisualStyleBackColor = false;
            this.btn_zeitdiagramm.Click += new System.EventHandler(this.btn_zeitdiagramm_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zeitdiagramm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(246, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voltmeter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_voltmeter
            // 
            this.btn_voltmeter.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltmeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltmeter.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltmeter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_voltmeter.Location = new System.Drawing.Point(246, 86);
            this.btn_voltmeter.Name = "btn_voltmeter";
            this.btn_voltmeter.Size = new System.Drawing.Size(130, 30);
            this.btn_voltmeter.TabIndex = 2;
            this.btn_voltmeter.Text = "Programm starten";
            this.btn_voltmeter.UseVisualStyleBackColor = false;
            this.btn_voltmeter.Click += new System.EventHandler(this.btn_voltmeter_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(423, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serielle Kommunikation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_seriellekommunikation
            // 
            this.btn_seriellekommunikation.BackColor = System.Drawing.Color.DarkGray;
            this.btn_seriellekommunikation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seriellekommunikation.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seriellekommunikation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_seriellekommunikation.Location = new System.Drawing.Point(423, 86);
            this.btn_seriellekommunikation.Name = "btn_seriellekommunikation";
            this.btn_seriellekommunikation.Size = new System.Drawing.Size(130, 30);
            this.btn_seriellekommunikation.TabIndex = 4;
            this.btn_seriellekommunikation.Text = "Programm starten";
            this.btn_seriellekommunikation.UseVisualStyleBackColor = false;
            this.btn_seriellekommunikation.Click += new System.EventHandler(this.btn_seriellekommunikation_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(604, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ampel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ampel
            // 
            this.btn_ampel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ampel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ampel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ampel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ampel.Location = new System.Drawing.Point(604, 86);
            this.btn_ampel.Name = "btn_ampel";
            this.btn_ampel.Size = new System.Drawing.Size(130, 30);
            this.btn_ampel.TabIndex = 6;
            this.btn_ampel.Text = "Programm starten";
            this.btn_ampel.UseVisualStyleBackColor = false;
            this.btn_ampel.Click += new System.EventHandler(this.btn_ampel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.label5.Location = new System.Drawing.Point(64, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digitaler Regler";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(64, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Programm starten";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ampel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_seriellekommunikation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltmeter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_zeitdiagramm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zeitdiagramm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_voltmeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_seriellekommunikation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ampel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

