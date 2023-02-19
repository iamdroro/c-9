using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Triangle
    {
        public int per(int d, int g, int f)
        {
            if (d > 0 && g > 0 && f > 0)
            {

                d = d + g + f;
            }
            else { MessageBox.Show("Стороны не могут быть меньше нуля", "Сообщение", MessageBoxButtons.OK); }
            return d;
        }



        public double S(double d, double g, double f)
        {
            if (d > 0 && g > 0 && f > 0)
            {
                f = Math.Sqrt(((d + g + f) / 2) * (((d + g + f) / 2) - d) * (((d + g + f) / 2) - g) * (((d + g + f) / 2) - f));
            }
            else
            {
                MessageBox.Show("Стороны не могут быть меньше нуля", "Сообщение", MessageBoxButtons.OK);


            }
            return f;
        }

    }
}
