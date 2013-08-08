namespace Mathinator.Forms
{
    partial class Percent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Percent));
            this.OnHowMuch = new System.Windows.Forms.Label();
            this.HowMuch = new System.Windows.Forms.Label();
            this.Submitpercent = new System.Windows.Forms.Button();
            this.BoxOnHowMuch = new System.Windows.Forms.TextBox();
            this.BoxHowMuch = new System.Windows.Forms.TextBox();
            this.Labeloutput = new System.Windows.Forms.Label();
            this.LabelOutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OnHowMuch
            // 
            this.OnHowMuch.AutoSize = true;
            this.OnHowMuch.Location = new System.Drawing.Point(92, 79);
            this.OnHowMuch.Name = "OnHowMuch";
            this.OnHowMuch.Size = new System.Drawing.Size(27, 13);
            this.OnHowMuch.TabIndex = 0;
            this.OnHowMuch.Text = "On?";
            // 
            // HowMuch
            // 
            this.HowMuch.AutoSize = true;
            this.HowMuch.Location = new System.Drawing.Point(92, 36);
            this.HowMuch.Name = "HowMuch";
            this.HowMuch.Size = new System.Drawing.Size(119, 13);
            this.HowMuch.TabIndex = 1;
            this.HowMuch.Text = "How much did you get?";
            // 
            // Submitpercent
            // 
            this.Submitpercent.Location = new System.Drawing.Point(12, 228);
            this.Submitpercent.Name = "Submitpercent";
            this.Submitpercent.Size = new System.Drawing.Size(491, 21);
            this.Submitpercent.TabIndex = 3;
            this.Submitpercent.Text = "Submit";
            this.Submitpercent.UseVisualStyleBackColor = true;
            this.Submitpercent.Click += new System.EventHandler(this.Submitpercent_Click);
            // 
            // BoxOnHowMuch
            // 
            this.BoxOnHowMuch.Location = new System.Drawing.Point(243, 79);
            this.BoxOnHowMuch.Name = "BoxOnHowMuch";
            this.BoxOnHowMuch.Size = new System.Drawing.Size(100, 20);
            this.BoxOnHowMuch.TabIndex = 2;
            this.BoxOnHowMuch.TextChanged += new System.EventHandler(this.BoxOnHowMuch_TextChanged);
            // 
            // BoxHowMuch
            // 
            this.BoxHowMuch.Location = new System.Drawing.Point(243, 36);
            this.BoxHowMuch.Name = "BoxHowMuch";
            this.BoxHowMuch.Size = new System.Drawing.Size(100, 20);
            this.BoxHowMuch.TabIndex = 1;
            this.BoxHowMuch.TextChanged += new System.EventHandler(this.BoxHowMuch_TextChanged);
            // 
            // Labeloutput
            // 
            this.Labeloutput.AutoSize = true;
            this.Labeloutput.Location = new System.Drawing.Point(16, 186);
            this.Labeloutput.Name = "Labeloutput";
            this.Labeloutput.Size = new System.Drawing.Size(0, 13);
            this.Labeloutput.TabIndex = 5;
            // 
            // LabelOutput2
            // 
            this.LabelOutput2.AutoSize = true;
            this.LabelOutput2.Location = new System.Drawing.Point(240, 118);
            this.LabelOutput2.Name = "LabelOutput2";
            this.LabelOutput2.Size = new System.Drawing.Size(0, 13);
            this.LabelOutput2.TabIndex = 6;
            // 
            // Percent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 261);
            this.Controls.Add(this.LabelOutput2);
            this.Controls.Add(this.Labeloutput);
            this.Controls.Add(this.BoxHowMuch);
            this.Controls.Add(this.BoxOnHowMuch);
            this.Controls.Add(this.Submitpercent);
            this.Controls.Add(this.HowMuch);
            this.Controls.Add(this.OnHowMuch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Percent";
            this.Text = "Percent";
            this.Load += new System.EventHandler(this.Percent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OnHowMuch;
        private System.Windows.Forms.Label HowMuch;
        private System.Windows.Forms.Button Submitpercent;
        private System.Windows.Forms.TextBox BoxOnHowMuch;
        private System.Windows.Forms.TextBox BoxHowMuch;
        private System.Windows.Forms.Label Labeloutput;
        private System.Windows.Forms.Label LabelOutput2;
    }
}