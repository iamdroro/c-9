using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Circle
    {
       
        public double per(double r)
        {if (r > 0)
            {
                r = 2 * 3.14 * r;
            }
            else { MessageBox.Show("Радиус не может быть меньше нуля", "Сообщение", MessageBoxButtons.OK); }
            return r;
        }
        public double S (double r)
        {
            if (r > 0)
            {
                r = 3.14 * (r * r);
                
            }
            else { MessageBox.Show("Радиус не может быть меньше нуля", "Сообщение", MessageBoxButtons.OK); }
            return r;
        }
    }
}
