namespace Mathinator.Forms
{
    partial class Temperatureconvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperatureconvert));
            this.BtnCelcuis = new System.Windows.Forms.Button();
            this.BtnFarenheit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputFromCtoF = new System.Windows.Forms.Label();
            this.OutputFromFtoC = new System.Windows.Forms.Label();
            this.TextBoxTempInC = new System.Windows.Forms.TextBox();
            this.TextBoxTempInF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCelcuis
            // 
            this.BtnCelcuis.Location = new System.Drawing.Point(12, 226);
            this.BtnCelcuis.Name = "BtnCelcuis";
            this.BtnCelcuis.Size = new System.Drawing.Size(75, 23);
            this.BtnCelcuis.TabIndex = 0;
            this.BtnCelcuis.Text = "OK";
            this.BtnCelcuis.UseVisualStyleBackColor = true;
            this.BtnCelcuis.Click += new System.EventHandler(this.BtnCelcuis_Click);
            // 
            // BtnFarenheit
            // 
            this.BtnFarenheit.Location = new System.Drawing.Point(503, 226);
            this.BtnFarenheit.Name = "BtnFarenheit";
            this.BtnFarenheit.Size = new System.Drawing.Size(75, 23);
            this.BtnFarenheit.TabIndex = 1;
            this.BtnFarenheit.Text = "OK";
            this.BtnFarenheit.UseVisualStyleBackColor = true;
            this.BtnFarenheit.Click += new System.EventHandler(this.BtnFarenheit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature in °C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature in °F";
            // 
            // OutputFromCtoF
            // 
            this.OutputFromCtoF.AutoSize = true;
            this.OutputFromCtoF.Location = new System.Drawing.Point(13, 108);
            this.OutputFromCtoF.Name = "OutputFromCtoF";
            this.OutputFromCtoF.Size = new System.Drawing.Size(35, 13);
            this.OutputFromCtoF.TabIndex = 4;
            this.OutputFromCtoF.Text = "label3";
            // 
            // OutputFromFtoC
            // 
            this.OutputFromFtoC.AutoSize = true;
            this.OutputFromFtoC.Location = new System.Drawing.Point(391, 108);
            this.OutputFromFtoC.Name = "OutputFromFtoC";
            this.OutputFromFtoC.Size = new System.Drawing.Size(35, 13);
            this.OutputFromFtoC.TabIndex = 5;
            this.OutputFromFtoC.Text = "label4";
            // 
            // TextBoxTempInC
            // 
            this.TextBoxTempInC.Location = new System.Drawing.Point(16, 51);
            this.TextBoxTempInC.MaxLength = 12;
            this.TextBoxTempInC.Name = "TextBoxTempInC";
            this.TextBoxTempInC.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTempInC.TabIndex = 6;
            // 
            // TextBoxTempInF
            // 
            this.TextBoxTempInF.Location = new System.Drawing.Point(394, 51);
            this.TextBoxTempInF.Name = "TextBoxTempInF";
            this.TextBoxTempInF.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTempInF.TabIndex = 7;
            // 
            // Temperatureconvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.TextBoxTempInF);
            this.Controls.Add(this.TextBoxTempInC);
            this.Controls.Add(this.OutputFromFtoC);
            this.Controls.Add(this.OutputFromCtoF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFarenheit);
            this.Controls.Add(this.BtnCelcuis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Temperatureconvert";
            this.Text = "Temperatureconvert";
            this.Load += new System.EventHandler(this.Temperatureconvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCelcuis;
        private System.Windows.Forms.Button BtnFarenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutputFromCtoF;
        private System.Windows.Forms.Label OutputFromFtoC;
        private System.Windows.Forms.TextBox TextBoxTempInC;
        private System.Windows.Forms.TextBox TextBoxTempInF;
    }
}