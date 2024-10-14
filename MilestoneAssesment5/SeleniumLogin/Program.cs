using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selenium Login started");
            IWebDriver driver = new ChromeDriver();
            string userName = "student";
            string password = "Password123";

            //Navigating to the url
            Console.WriteLine("Navigating to the test url");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");      
            

            //Typing user name and password
            Console.WriteLine("Typing user name and password");
            IWebElement UsernameField = driver.FindElement(By.Id("username"));
            IWebElement PasswordField = driver.FindElement(By.Id("password"));
            UsernameField.SendKeys(userName);
            PasswordField.SendKeys(password);

            //Using jQuery to locate submit button, click
            Console.WriteLine("Using jQuery to locate submit button");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string script = "document.getElementById('submit').click();";
  
            //Clicking login button jQuery
            Console.WriteLine("Clicking login button");
            IWebElement LoginButton = (IWebElement)js.ExecuteScript(script);

            //Check login success or not
            Console.WriteLine("Checking login success or not by element(XPath)");
            //Using xpath to locate element - Success login label
            IWebElement LoginSuccessLable = driver.FindElement(By.XPath("//h1[@class='post-title']"));

            if(LoginSuccessLable.Text == "Logged In Successfully")
            {
                Console.WriteLine("Successfully logged in");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
            
            Console.WriteLine("Selenium Login completed");
        }
    }
}