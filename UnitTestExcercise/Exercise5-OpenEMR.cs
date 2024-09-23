using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ThomsonReuters.SeleniumConceptUnitTestProject
{
    class OpenEMR
    {
        [Test]
        public void OpenEMRTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Navigate to OpenEMR demo site
            driver.Navigate().GoToUrl("http://demo.openemr.io/b/openemr/");

            // Update username
            driver.FindElement(By.Id("authUser")).SendKeys("admin");

            // Update password
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            // Select language as English (Indian)
            SelectElement languageDropdown = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            languageDropdown.SelectByText("English (Indian)");

            // Click on the login button
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            // Click on Patient -> New/Search
            driver.FindElement(By.XPath("//div[text()='Patient']")).Click();
            driver.FindElement(By.XPath("//div[text()='New/Search']")).Click();

            // Switch to the new frame
            driver.SwitchTo().Frame("pat");

            // Add first name and last name
            driver.FindElement(By.Id("form_fname")).SendKeys("John");
            driver.FindElement(By.Id("form_lname")).SendKeys("Doe");

            // Update DOB as today's date
            driver.FindElement(By.Id("form_DOB")).SendKeys(DateTime.Now.ToString("yyyy-MM-dd"));

            // Update the gender
            var genderDropdown = new SelectElement(driver.FindElement(By.Id("form_sex")));
            genderDropdown.SelectByText("Male");

            // Click on the create new patient button above the form
            driver.FindElement(By.Id("create")).Click();

            // Click on confirm create new patient button
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("modalframe");
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();

            // Print the text from alert box
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert Text: " + alert.Text);
            alert.Accept();

            // Close the Happy Birthday popup
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.XPath("//div[@class='closeDlgIframe']")).Click();

            // Get the added patient name and print in the console
            driver.SwitchTo().Frame("pat");
            string patientName = driver.FindElement(By.XPath("//span[@data-bind='text: pname']")).Text;
            Console.WriteLine("Added Patient Name: " + patientName);
        }
    }
}