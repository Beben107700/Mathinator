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
    public partial class Percent : Form
    {
        public Percent()
        {
            InitializeComponent();
        }

        private void BoxHowMuch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxOnHowMuch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submitpercent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BoxOnHowMuch.Text) || !string.IsNullOrEmpty(BoxHowMuch.Text))
            {
                Labeloutput.Text = "Hey, i can't divide a number by 0...";
                string stronhowmuch = BoxOnHowMuch.Text;
                string strhowmuch = BoxHowMuch.Text;
                double onhowmuch = MathFunctions.StringToDouble(stronhowmuch);
                double howmuch = MathFunctions.StringToDouble(strhowmuch);


                if (onhowmuch != 0 && howmuch != 0)
                {
                    double dblOutput = MathFunctions.PercentCalc(onhowmuch, howmuch);
                    int Output = Convert.ToInt32(dblOutput);

                    string FinalOutputString = "You have achieved " + Convert.ToString(Output) + " percent.";
                    Labeloutput.Text = FinalOutputString;

                    if (dblOutput != Convert.ToInt32(dblOutput)) 
                    { 

                        LabelOutput2.Text = "Precisely, you will get " + dblOutput + " percent";
                    }
                }
                

            }
            else
            {
                Labeloutput.Text = "Hey! you didn't fill all boxes";

            }

        }

        private void Percent_Load(object sender, EventArgs e)
        {

        }
    }
}
