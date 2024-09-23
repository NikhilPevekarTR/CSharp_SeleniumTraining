using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class MediBuddyLogin
{
    static void Main2()
    {
        // Initialize the Chrome driver
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the MediBuddy login page
            driver.Navigate().GoToUrl("https://www.medibuddy.in/");

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Click on Login
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            // Wait until the "I have an Insurance/Corporate Account" button is clickable
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[text()='I have an Insurance/Corporate Account']"))).Click();

            // Click on "Login using Username & Password"
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[text()='Login using Username & Password']"))).Click();

            // Enter username
            driver.FindElement(By.Name("userName")).SendKeys("john");

            // Enter password
            driver.FindElement(By.Name("password")).SendKeys("john123");

            // Click on show password
            driver.FindElement(By.CssSelector(".password-show")).Click();

            // Click on log in
            driver.FindElement(By.XPath("//button[text()='Log in']")).Click();

            // Wait for the error message to appear
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".error-message-class"))); // Adjust the CSS selector as needed

            // Get the error message displayed and print it
            IWebElement errorMessage = driver.FindElement(By.CssSelector(".error-message-class")); // Adjust the CSS selector as needed
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