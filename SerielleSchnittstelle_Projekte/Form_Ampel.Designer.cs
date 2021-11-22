
namespace SerielleSchnittstelle_Projekte
{
    partial class Form_Ampel
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
            this.pb_1r = new System.Windows.Forms.PictureBox();
            this.pb_1ge = new System.Windows.Forms.PictureBox();
            this.pb_1gr = new System.Windows.Forms.PictureBox();
            this.pb_2gr = new System.Windows.Forms.PictureBox();
            this.pb_2ge = new System.Windows.Forms.PictureBox();
            this.pb_2r = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1ge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2ge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2r)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_1r
            // 
            this.pb_1r.Location = new System.Drawing.Point(49, 57);
            this.pb_1r.Name = "pb_1r";
            this.pb_1r.Size = new System.Drawing.Size(50, 50);
            this.pb_1r.TabIndex = 0;
            this.pb_1r.TabStop = false;
            // 
            // pb_1ge
            // 
            this.pb_1ge.Location = new System.Drawing.Point(49, 113);
            this.pb_1ge.Name = "pb_1ge";
            this.pb_1ge.Size = new System.Drawing.Size(50, 50);
            this.pb_1ge.TabIndex = 1;
            this.pb_1ge.TabStop = false;
            // 
            // pb_1gr
            // 
            this.pb_1gr.Location = new System.Drawing.Point(49, 169);
            this.pb_1gr.Name = "pb_1gr";
            this.pb_1gr.Size = new System.Drawing.Size(50, 50);
            this.pb_1gr.TabIndex = 2;
            this.pb_1gr.TabStop = false;
            // 
            // pb_2gr
            // 
            this.pb_2gr.Location = new System.Drawing.Point(115, 169);
            this.pb_2gr.Name = "pb_2gr";
            this.pb_2gr.Size = new System.Drawing.Size(50, 50);
            this.pb_2gr.TabIndex = 5;
            this.pb_2gr.TabStop = false;
            // 
            // pb_2ge
            // 
            this.pb_2ge.Location = new System.Drawing.Point(115, 113);
            this.pb_2ge.Name = "pb_2ge";
            this.pb_2ge.Size = new System.Drawing.Size(50, 50);
            this.pb_2ge.TabIndex = 4;
            this.pb_2ge.TabStop = false;
            // 
            // pb_2r
            // 
            this.pb_2r.Location = new System.Drawing.Point(115, 57);
            this.pb_2r.Name = "pb_2r";
            this.pb_2r.Size = new System.Drawing.Size(50, 50);
            this.pb_2r.TabIndex = 3;
            this.pb_2r.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM10";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form_Ampel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_2gr);
            this.Controls.Add(this.pb_2ge);
            this.Controls.Add(this.pb_2r);
            this.Controls.Add(this.pb_1gr);
            this.Controls.Add(this.pb_1ge);
            this.Controls.Add(this.pb_1r);
            this.Name = "Form_Ampel";
            this.Text = "Form_Ampel";
            ((System.ComponentModel.ISupportInitialize)(this.pb_1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1ge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2ge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2r)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_1r;
        private System.Windows.Forms.PictureBox pb_1ge;
        private System.Windows.Forms.PictureBox pb_1gr;
        private System.Windows.Forms.PictureBox pb_2gr;
        private System.Windows.Forms.PictureBox pb_2ge;
        private System.Windows.Forms.PictureBox pb_2r;
        private System.IO.Ports.SerialPort serialPort1;
    }
}