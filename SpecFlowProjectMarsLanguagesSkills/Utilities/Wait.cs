using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
//using MyProject1.Utilities;

//namespace SpecFlowProjectMarsLanguagesSkills.Utilities
//{
//    public class Wait
//    {
//        public static void waitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
//        {
//            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
//            if (locatorType == "Xpath")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
//            }

//            if (locatorType == "Id")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
//            }

//            if (locatorType == "CssSelector")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
//            }

//            if (locatorType == "Name")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
//            }

//        }
//        public static void waitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
//        {
//            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
//            if (locatorType == "Xpath")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
//            }

//            if (locatorType == "Id")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
//            }

//            if (locatorType == "CssSelector")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
//            }

//            if (locatorType == "Name")
//            {
//                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
//            }


//        }


//    }
//}

