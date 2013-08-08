using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathinator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            
        }        

        private void btnpercents_Click(object sender, EventArgs e)
        {
            
            Forms.Percent percentform = new Forms.Percent();
            percentform.Show();
        }

        private void btnaverage_Click(object sender, EventArgs e)
        {
            Forms.Average averageform = new Forms.Average();
            averageform.Show();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {        

        }

        private void btntemperature_Click(object sender, EventArgs e)
        {
            Forms.Temperatureconvert tempform = new Forms.Temperatureconvert();
            tempform.Show();
        }
    }
}
