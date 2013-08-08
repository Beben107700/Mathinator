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
    public partial class Temperatureconvert : Form
    {
        public Temperatureconvert()
        {
            InitializeComponent();
        }

        private void BtnCelcuis_Click(object sender, EventArgs e)
        {
            string strtemp = TextBoxTempInC.Text;
            double answer = MathFunctions.celctofaren(strtemp);
            OutputFromCtoF.Text = "Temperature in Farenheit is " + answer + "°F";

        }

        private void BtnFarenheit_Click(object sender, EventArgs e)
        {
            string strtemp = TextBoxTempInF.Text;
            double Answer = MathFunctions.farentocelc(strtemp);
            OutputFromFtoC.Text = "The temperature in Celcuis is " + Answer + "°C";
        }

        private void Temperatureconvert_Load(object sender, EventArgs e)
        {
            OutputFromFtoC.Text = "";
            OutputFromCtoF.Text = "";
        }
    }
}
