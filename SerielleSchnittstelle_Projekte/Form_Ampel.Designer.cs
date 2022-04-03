
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Ampel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_1r;
        private System.Windows.Forms.PictureBox pb_1ge;
        private System.Windows.Forms.PictureBox pb_1gr;
        private System.Windows.Forms.PictureBox pb_2gr;
        private System.Windows.Forms.PictureBox pb_2ge;
        private System.Windows.Forms.PictureBox pb_2r;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}