using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5HW
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstbutton = FS.Text;
                string secondbutton = ss.Text;
                double a = double.Parse(firstbutton);
                double b = double.Parse(secondbutton);
                
                    Figure rectangle = new Figure(a, b);
                    double per = rectangle.RectanglePerimeter();
                    double area = rectangle.RectangleArea();
                    MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);
                
                this.Hide();

                Form1 change = new Form1();
                change.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
