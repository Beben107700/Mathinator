using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathinator.Forms
{
    public partial class Average : Form
    {
        public Average()
        {
            InitializeComponent();
        }

        private void Average_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BoxVal2.Text) || !string.IsNullOrEmpty(BoxVal1.Text))//check if boxes are not empty
            {

                double dblval1 = MathFunctions.StringToDouble(BoxVal1.Text);//converting string to double,
                double dblval2 = MathFunctions.StringToDouble(BoxVal2.Text);//with function i've created.

                double dbloutput = MathFunctions.AverageCalc(dblval1, dblval2);//calculating average
                int intoutput = Convert.ToInt32(dbloutput);//taking average, putting into round number (if 1.223 ==> 1 || if 1.65 ==> 2)
                string Output = "The average is " + intoutput;
                LabelOutput.Text = Output;
                if (intoutput != dbloutput)//checking if output (precise) is equals to round number of output (intoutput)
                {
                    Labeloutput2.Text = "Precisely you will get " + dbloutput;
                }

            }
            else
            {
                LabelOutput.Text = "Hey, you have to fill the boxes";
            }
        }
    }
}
