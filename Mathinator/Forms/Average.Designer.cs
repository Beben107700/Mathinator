namespace Mathinator.Forms
{
    partial class Average
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Average));
            this.BoxVal1 = new System.Windows.Forms.TextBox();
            this.BoxVal2 = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.Labeloutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxVal1
            // 
            this.BoxVal1.Location = new System.Drawing.Point(104, 48);
            this.BoxVal1.Name = "BoxVal1";
            this.BoxVal1.Size = new System.Drawing.Size(100, 20);
            this.BoxVal1.TabIndex = 0;
            // 
            // BoxVal2
            // 
            this.BoxVal2.Location = new System.Drawing.Point(104, 93);
            this.BoxVal2.Name = "BoxVal2";
            this.BoxVal2.Size = new System.Drawing.Size(100, 20);
            this.BoxVal2.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(13, 226);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(259, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "SUBMIT";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second value";
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(13, 188);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(78, 13);
            this.LabelOutput.TabIndex = 5;
            this.LabelOutput.Text = "The average is";
            // 
            // Labeloutput2
            // 
            this.Labeloutput2.AutoSize = true;
            this.Labeloutput2.Location = new System.Drawing.Point(13, 201);
            this.Labeloutput2.Name = "Labeloutput2";
            this.Labeloutput2.Size = new System.Drawing.Size(0, 13);
            this.Labeloutput2.TabIndex = 6;
            // 
            // Average
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Labeloutput2);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BoxVal2);
            this.Controls.Add(this.BoxVal1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Average";
            this.Text = "Average";
            this.Load += new System.EventHandler(this.Average_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxVal1;
        private System.Windows.Forms.TextBox BoxVal2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Label Labeloutput2;
    }
}