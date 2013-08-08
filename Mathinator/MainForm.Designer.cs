namespace Mathinator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnaverage = new System.Windows.Forms.Button();
            this.btnpercents = new System.Windows.Forms.Button();
            this.btntemperature = new System.Windows.Forms.Button();
            this.labelcopyrights = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaverage
            // 
            this.btnaverage.Location = new System.Drawing.Point(13, 243);
            this.btnaverage.Name = "btnaverage";
            this.btnaverage.Size = new System.Drawing.Size(612, 93);
            this.btnaverage.TabIndex = 0;
            this.btnaverage.Text = "Average";
            this.btnaverage.UseVisualStyleBackColor = true;
            this.btnaverage.Click += new System.EventHandler(this.btnaverage_Click);
            // 
            // btnpercents
            // 
            this.btnpercents.Location = new System.Drawing.Point(12, 12);
            this.btnpercents.Name = "btnpercents";
            this.btnpercents.Size = new System.Drawing.Size(612, 102);
            this.btnpercents.TabIndex = 1;
            this.btnpercents.Text = "Percents";
            this.btnpercents.UseVisualStyleBackColor = true;
            this.btnpercents.Click += new System.EventHandler(this.btnpercents_Click);
            // 
            // btntemperature
            // 
            this.btntemperature.Location = new System.Drawing.Point(12, 123);
            this.btntemperature.Name = "btntemperature";
            this.btntemperature.Size = new System.Drawing.Size(612, 102);
            this.btntemperature.TabIndex = 2;
            this.btntemperature.Text = "T°";
            this.btntemperature.UseVisualStyleBackColor = true;
            this.btntemperature.Click += new System.EventHandler(this.btntemperature_Click);
            // 
            // labelcopyrights
            // 
            this.labelcopyrights.AutoSize = true;
            this.labelcopyrights.Location = new System.Drawing.Point(12, 337);
            this.labelcopyrights.Name = "labelcopyrights";
            this.labelcopyrights.Size = new System.Drawing.Size(92, 13);
            this.labelcopyrights.TabIndex = 4;
            this.labelcopyrights.Text = "By Delcoigne Ben";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 359);
            this.Controls.Add(this.labelcopyrights);
            this.Controls.Add(this.btntemperature);
            this.Controls.Add(this.btnpercents);
            this.Controls.Add(this.btnaverage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaverage;
        private System.Windows.Forms.Button btnpercents;
        private System.Windows.Forms.Button btntemperature;
        private System.Windows.Forms.Label labelcopyrights;
    }
}

