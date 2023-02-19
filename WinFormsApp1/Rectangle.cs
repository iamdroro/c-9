using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Rectangle
    {
        
        public int per(int a,int c)
        {if (a > 0 && c > 0)
            {
                a = a + a + c + c;
            }
            else { MessageBox.Show("Стороны не могут быть меньше нуля", "Сообщение", MessageBoxButtons.OK); }
            return a;    
        }

        public int S ( int a, int c)
        {if (a > 0 && c > 0)
            {
                c = a * c;
            }
            else { MessageBox.Show("Стороны не могут быть меньше нуля", "Сообщение", MessageBoxButtons.OK); }
            return c;
        }
    }
}
