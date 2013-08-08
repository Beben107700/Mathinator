using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathinator
{
    static class Hey
    {
    }
    static class MathFunctions
    {
        //Percentcalculating
        public static double PercentCalc(double onhowmuch, double howmuch)
        {
                double divideby = 100 / onhowmuch;
                double Output = divideby * howmuch;
                return Output;
            
        }
        //Average
        public static double AverageCalc(double value1, double value2)
        {
            double output = (value1 + value2) / 2;
            return output;
        }
        //String to double
        public static double StringToDouble(string thestring)
        {
            double converted;
            bool possible = double.TryParse(thestring, out converted);
            if (possible == true)
            {
                converted = Convert.ToDouble(thestring);
            }
            return converted;
        }
        //Celcuis to Farenheit
        public static double celctofaren(string tempincelc)
        {
            double thetemp = StringToDouble(tempincelc);
            double Output = thetemp * 1.8 + 32;
            return Output;
        }
        //Farenheit to Celcuis
        public static double farentocelc(string tempinfarenh)
        {
            double thetemp = StringToDouble(tempinfarenh);
            double Output = (thetemp - 32) / 1.8;
            return Output;
        }
    }
}
