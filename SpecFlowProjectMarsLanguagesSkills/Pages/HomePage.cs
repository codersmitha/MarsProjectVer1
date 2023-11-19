using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProjectMarsLanguagesSkills.Utilities;


namespace SpecFlowProjectMarsLanguagesSkills.Pages
{
    public class HomePage
    {
        public void SignInActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            Thread.Sleep(2000);
           // Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);
            IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignInButton.Click();
            
        }
    }
}