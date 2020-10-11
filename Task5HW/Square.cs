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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string side = text.Text;
                double a = double.Parse(side);
                
                    Figure square = new Figure(a);
                    double per = square.SquarePerimeter();
                    double area = square.SquareArea();
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
