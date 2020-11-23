using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;










namespace WindowsFormsApp3
{
    public partial class Form1 : Form 


    {

        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            double a = Controller.input(textBox1);
            double b = Controller.input(textBox2);
            double c = Controller.input(textBox3);

            double D = Controller.desc(a, b, c);
            if (D < 0)
            {
                MessageBox.Show("Не имеет корней");
            }
            else if (D == 0)
            {
                MessageBox.Show("Имеет один корень = " + Controller.x1(b, D, a));
                MessageBox.Show(a + "(x - " + Controller.x1(b, D, a) + ") ** 2");
            }
            else
            {
                MessageBox.Show(a + "(x - " + Controller.x1(b, D, a) + ")(x - " + Controller.x2(b, D, a) + ")");
                MessageBox.Show("Имеет два корня. x1 = " + Controller.x1(b, D, a) + "; x2 = " + Controller.x2(b, D, a) + "");
            }
        }

    }
}
