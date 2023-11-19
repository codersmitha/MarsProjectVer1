using OpenQA.Selenium;
using SpecFlowProjectMarsLanguagesSkills.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMarsLanguagesSkills.Pages
{
    public class ProfilePage
    {
        public void ClickLanguageTab(IWebDriver driver ,string clickAppropriatetab)
        {
            Thread.Sleep(2000);
            //Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 2);
            if (clickAppropriatetab == "language")
            {
                IWebElement LanguageTabs = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
                LanguageTabs.Click();
            }

            else if (clickAppropriatetab == "Skill")
            {
                IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                skillTab.Click();
            }

        }
    }
}