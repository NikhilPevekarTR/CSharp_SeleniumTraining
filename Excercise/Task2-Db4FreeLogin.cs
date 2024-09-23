using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Db4FreeLogin
{
    static void Main1()
    {
        // Initialize the Chrome driver
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the db4free phpMyAdmin login page
            driver.Navigate().GoToUrl("https://www.db4free.net/phpMyAdmin/");

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Enter username
            driver.FindElement(By.Id("input_username")).SendKeys("Admin");

            // Enter password
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");

            // Click on the Login button
            driver.FindElement(By.Id("input_go")).Click();

            // Wait for the error message to appear
            System.Threading.Thread.Sleep(2000); // Adjust sleep time as needed

            // Get the error message displayed
            IWebElement errorMessage = driver.FindElement(By.CssSelector(".alert.alert-danger"));
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