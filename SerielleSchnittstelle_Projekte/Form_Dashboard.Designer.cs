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
            this.btn_zeitdiagramm.Location = new System.Drawing.Point(15, 35);
            this.btn_zeitdiagramm.Name = "btn_zeitdiagramm";
            this.btn_zeitdiagramm.Size = new System.Drawing.Size(105, 23);
            this.btn_zeitdiagramm.TabIndex = 0;
            this.btn_zeitdiagramm.Text = "Programm starten";
            this.btn_zeitdiagramm.UseVisualStyleBackColor = true;
            this.btn_zeitdiagramm.Click += new System.EventHandler(this.btn_zeitdiagramm_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zeitdiagramm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voltmeter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_voltmeter
            // 
            this.btn_voltmeter.Location = new System.Drawing.Point(194, 35);
            this.btn_voltmeter.Name = "btn_voltmeter";
            this.btn_voltmeter.Size = new System.Drawing.Size(105, 23);
            this.btn_voltmeter.TabIndex = 2;
            this.btn_voltmeter.Text = "Programm starten";
            this.btn_voltmeter.UseVisualStyleBackColor = true;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltmeter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_zeitdiagramm);
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

