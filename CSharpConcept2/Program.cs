using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.Formulae;

namespace ThomsonReuters.CSharpConcept2
{
    public class Program
    {
        //Static method call
       
        static void Main(string[] args)
        {
            double result;
            string authorName;

            //load all non-static fields in memory
            Area obj = new Area();

            result = Area.AreaOfCircle(10);
            Console.WriteLine("Area of circle: "+result);

            result = Area.AreaOfRectangle(10,20);
            Console.WriteLine("Area of rectangle: " + result);

            result = obj.AreaOfTriangle(25, 1);
            Console.WriteLine("Area of triangle: " + result);

            authorName = obj.GetAuthorName();
            Console.WriteLine("Athor Name: " + authorName);

            obj.Quit();

            //int radius = 10;
            //float pie = 3.14f;
            //double area;

            //area = pie * radius * radius;
            //Console.WriteLine(area);
        }
    }
}