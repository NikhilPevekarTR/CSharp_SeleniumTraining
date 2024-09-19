using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.Formulae
{
    public class Area
    {
        public static double AreaOfCircle(int rad) //Area of circle
        {
            double area = 3.14 * rad * rad;
            return area;
        }
        public static double AreaOfRectangle(int len, int width) //Area of rectangle
        {
            double area = len * width;
            return area;
        }
        public double AreaOfTriangle(int b, int h) //Area of triangle
        {
            double area = 0.5 * (b * h);
            return area;
        }
        public string GetAuthorName()
        {
            return "Bala";
        }
        public void Quit()
        {

        }
    }
}
