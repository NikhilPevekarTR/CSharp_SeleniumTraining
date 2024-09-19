using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo2FBSignp
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            //Click on create new account
            driver.FindElement(By.LinkText("Sign up for Facebook")).Click(); //Sign Up for Facebook
            driver.FindElement(By.Name("firstname")).SendKeys("John"); //Firstname
            driver.FindElement(By.Name("lastname")).SendKeys("Barny"); //Lastname
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("John123"); //Password
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day"))); //Day
            selectDay.SelectByText("21");
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month"))); //Month
            selectMonth.SelectByText("Apr");
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year"))); //Year
            selectYear.SelectByText("1995");
            driver.FindElement(By.XPath("//input[@value='2']")).Click(); //radio button
            driver.FindElement(By.Name("websubmit")).Click(); //SignUp
        }
    }
}
