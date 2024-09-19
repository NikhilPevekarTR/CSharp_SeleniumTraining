using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver obj = new ChromeDriver();
            string browser = "Edge";

            IWebDriver obj1 = new ChromeDriver();

            obj.Url = "https://www.google.com/";
            string strTitle = obj.Title;
            Console.WriteLine(strTitle);
            obj.Quit();
            obj1.Quit();

        }
    }
}