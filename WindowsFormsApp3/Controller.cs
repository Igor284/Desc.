using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Controller
    {
        public static double input(TextBox t)
        {
            double x = 0;
            if (double.TryParse(t.Text, out x))
            {
                return x;
            }
            else
            {
                t.Text = "input type error, try again";
            }

            return x;
        }

        public static double desc(double a, double b, double c)
        {
            return (b * b - 4 * a * c);
        }


        public static double x1(double b, double D, double a)

        {
            return (b * -1) + Math.Sqrt(D) / 2 * a;

        }
        public static double x2(double b, double D, double a)

        {
            return (b * -1) - Math.Sqrt(D) / 2 * a;

        }
    }
}
