using OpenQA.Selenium;
using SpecFlowProjectMarsLanguagesSkills.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMarsLanguagesSkills.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        { //driver.Manage().Window.Maximize();
          // driver.Navigate().GoToUrl("http://localhost:5000/Home");
          //IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
          //SignInButton.Click();
          Thread.Sleep(2000);
            //Wait.waitToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 2);
            IWebElement EmailAdress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            EmailAdress.Click();
            EmailAdress.Clear();
            EmailAdress.SendKeys("smithajohnson11@gmail.com");

            IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            PasswordTextBox.Click();
            PasswordTextBox.Clear();
            PasswordTextBox.SendKeys("PraiseLord");

            IWebElement LogInButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LogInButton.Click();
            
        }
    }
}
