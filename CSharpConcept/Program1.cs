using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.CSharpConcept
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            String[] colors = new string[3];
            colors[0]="Red";
            colors[1] = "Green";
            colors[2] = "Yellow";

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);
            Console.WriteLine(String.Join(",",colors));
        }
    }
}
