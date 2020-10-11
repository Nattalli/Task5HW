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
    public partial class Triangle2 : Form
    {
        public Triangle2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstbutton = FS.Text;
                string secondbutton = ss.Text;
                string thirdbutton = ts.Text;
                double q = double.Parse(firstbutton);
                double w = double.Parse(secondbutton);
                double v = double.Parse(thirdbutton);
                if ((q > w + v) || (w > q + v) || (v > q + w) || v <= 0 || w <= 0 || q <= 0)
                {
                    MessageBox.Show("Sides are incorrect");
                }
                else
                {
                    Figure triangle = new Figure(q, w, v);
                    double per = triangle.TrianglePerimeter();
                    double area = triangle.TriangleArea();
                    MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);
                }
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
