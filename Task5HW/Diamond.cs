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
    public partial class Diamond : Form
    {
        public Diamond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Side = side.Text;
                string Angle = angle.Text;
                double a = double.Parse(Side);
                double b = double.Parse(Angle);
                if(b < 180 && b > 0)
                {
                    Figure diamond = new Figure(a, b);
                    double per = diamond.DiamondPerimeter();
                    double area = diamond.DiamondArea();
                    MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);

                    this.Hide();

                    Form1 change = new Form1();
                    change.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect format of angle!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
