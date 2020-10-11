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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string side = radius.Text;
                double r = double.Parse(side);

                Figure circle = new Figure(r);
                double per = circle.CirclePerimeter();
                double area = circle.CircleArea();
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
