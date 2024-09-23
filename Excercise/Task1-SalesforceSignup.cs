using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class SalesforceSignup
{
    static void Main()
    {
        // Initialize the Chrome driver
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the Salesforce signup page
            driver.Navigate().GoToUrl("https://www.salesforce.com/in/form/signup/freetrial-sales/");

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Enter first name
            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");

            // Enter last name
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");

            // Enter work email
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            // Select Job title
            SelectElement jobTitleSelect = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            jobTitleSelect.SelectByText("IT Manager");

            // Select Employees
            SelectElement employeesSelect = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            employeesSelect.SelectByText("101 - 500 employees");

            // Select country
            SelectElement countrySelect = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            countrySelect.SelectByText("United Kingdom");

            // Click on the check box
            driver.FindElement(By.XPath("//div[@class='checkbox-ui']")).Click();

            // Click on "start my free trial" button
            driver.FindElement(By.Name("start my free trial")).Click();

            // Get the error message displayed for the phone number
            IWebElement errorMessage = driver.FindElement(By.XPath("//span[contains(text(),'Enter a valid phone number')]"));
            Console.WriteLine("Error Message: " + errorMessage.Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}