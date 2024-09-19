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
    public class SalesForceAssignment
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            //2.Enter first name as “John”
            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");

            //3.Enter last name as “wick”
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");

            //4.Enter work email as “john @gmail.com”
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Atos");

            //5.Select Job title as “IT Manager”
            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByText("IT Manager");

            //6.Select Employees as “101 - 500 employees”
            SelectElement selectEmployeeCount = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployeeCount.SelectByText("101 - 500 employees");

            //7.Select country as “United Kingdom”
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");

            //8.Do not fill the phone number
            driver.FindElement(By.Name("UserPhone")).SendKeys("123");

            //9.Click on check box
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();

            //10.Click on start my free trial
            driver.FindElement(By.Name("start my free trial")).Click();

            string actualHeader = driver.FindElement(By.TagName("h1")).Text;
            Console.WriteLine(actualHeader);

            //11.Get the error message displayed “Enter a valid phone number”
            string actualError = driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]")).Text;
            Console.WriteLine(actualError);
        }
    }
}