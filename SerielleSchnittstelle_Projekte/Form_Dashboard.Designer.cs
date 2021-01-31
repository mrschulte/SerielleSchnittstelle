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
            this.SuspendLayout();
            // 
            // btn_zeitdiagramm
            // 
            this.btn_zeitdiagramm.BackColor = System.Drawing.Color.DarkGray;
            this.btn_zeitdiagramm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zeitdiagramm.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zeitdiagramm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_zeitdiagramm.Location = new System.Drawing.Point(67, 74);
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
            this.btn_voltmeter.Location = new System.Drawing.Point(246, 74);
            this.btn_voltmeter.Name = "btn_voltmeter";
            this.btn_voltmeter.Size = new System.Drawing.Size(130, 30);
            this.btn_voltmeter.TabIndex = 2;
            this.btn_voltmeter.Text = "Programm starten";
            this.btn_voltmeter.UseVisualStyleBackColor = false;
            this.btn_voltmeter.Click += new System.EventHandler(this.btn_voltmeter_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

