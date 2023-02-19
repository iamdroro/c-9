
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1

{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { Rectangle form = new Rectangle();
            Triangle form1 = new Triangle();
            Circle form2 = new Circle();
            int a = int.Parse(textBox1.Text);
            int c = int.Parse(textBox2.Text);
            int d = int.Parse(textBox3.Text);
            int g = int.Parse(textBox4.Text);
            int f = int.Parse(textBox5.Text);
            int r=int.Parse(textBox6.Text);
            label7.Text = Convert.ToString(form.per(a , c));
            label6.Text = Convert.ToString(form.S(a,c));
            label9.Text = Convert.ToString(form1.per(d,g,f));
            label10.Text = Convert.ToString(form1.S(d, g, f));
            label19.Text= Convert.ToString(form2.per(r));
            label20.Text= Convert.ToString(form2.S(r));

            /**  label9.Text = form;
              label10.Text = form;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}