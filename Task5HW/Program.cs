using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5HW
{
    public class Figure
    {
        public double FirstSide, SecondSide, ThirdSide, R;
        public Figure() { }
        public Figure(double r)
        {
            R = r;
        }
        public Figure (double a, double b)
        {
            FirstSide = a;
            SecondSide = b;
        }
        public Figure(double a, double b, double c)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;
        }
        public void SetFirstSide(double side)
        {
            FirstSide = side;
        }
        public void SetSecondSide(double side)
        {
            SecondSide = side;
        }
        public void SetThirdSide(double side)
        {
            ThirdSide = side;
        }
        public void SetR(double r)
        {
            R = r;
        }
        public virtual double TrianglePerimeter()
        {
            return FirstSide + SecondSide + ThirdSide;
        }
        public virtual double TriangleArea()
        {
            double per = TrianglePerimeter()/2;
            return Math.Sqrt(per * (per - FirstSide) * (per - SecondSide) * (per - ThirdSide));
        }
        public virtual double CirclePerimeter()
        {
            return 2*3.14*R;
        }
        public virtual double CircleArea()
        {
            return 3.14 * R * R;
        }
        public virtual double SquarePerimeter()
        {
            return 4*R;
        }
        public virtual double SquareArea()
        {
            return R*R;
        }
        public virtual double RectanglePerimeter()
        {
            return 2 * (FirstSide + SecondSide);
        }
        public virtual double RectangleArea()
        {
            return FirstSide * SecondSide;
        }
        public virtual double DiamondPerimeter()
        {
            return 4 * FirstSide;
        }
        public virtual double DiamondArea()
        {
            return Math.Sin(SecondSide) * FirstSide * FirstSide;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
