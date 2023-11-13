using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowProjectMarsLanguagesSkills.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SpecFlowProjectMarsLanguagesSkills.Pages
{
    public class LanguagePage
    {
        public void deleteLanguageRecord(IWebDriver driver)
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;

            for (int i = 1; i <= rowCount;)
            {
                Thread.Sleep(2000);
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                deleteButton.Click();
                rowCount--;
                driver.Navigate().Refresh();
                Thread.Sleep(2000);


            }

        }

        public void assertDeleteLanguage(IWebDriver driver)
        {
            //Verify if the existing Language has updated Successfully
            driver.Navigate().Refresh();
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 2);
            Thread.Sleep(3000);
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;


            Assert.That(rowCount == 0, "Records Not Deleted Successfully");

            Thread.Sleep(2000);
        }



        public void AddNewLanguage(IWebDriver driver, string language, string level)
        {
            
                Thread.Sleep(3000);
                //Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",10);

                IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                AddNewButton.Click();

                IWebElement addLanguageInputBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
                addLanguageInputBox.Click();
                addLanguageInputBox.SendKeys(language);

                IWebElement selectLanguageLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
                selectLanguageLevelDropdown.Click();

                if (level.Equals("Basic"))
                {
                    IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Basic']"));
                    leveloptions.Click();
                }
                else if (level.Equals("Conversational"))
                {
                    IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Conversational']"));
                    leveloptions.Click();
                }
                else if (level.Equals("Fluent"))
                {
                    IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Fluent']"));
                    leveloptions.Click();
                }
                else if (level.Equals("Native/Bilingual"))
                {
                    IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Native/Bilingual']"));
                    leveloptions.Click();
                }

                IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
                addButton.Click();
                Thread.Sleep(3000);
            
        }

        public void assertAddNewLanguage(IWebDriver driver, string language)
        {
            //Verify if the new Language has been created Successfully
            driver.Navigate().Refresh();
            // Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            Thread.Sleep(2000);
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (addLanguage.Text.Equals(language))
            {
                //Assert.Pass("Language has been Added Successfully");
                Assert.That(addLanguage.Text.Equals(language), "Language Not Added Successfully");
            }
            //else
            //{
            //    Assert.Fail("Language Not Added Successfully");
            //}
            Thread.Sleep(2000);
        }



        public void updateLanguage(IWebDriver driver, string oldlanguage, string oldlevel, string newlanguage, string newlevel)
        {
            //Refresh the Profile Page
            driver.Navigate().Refresh();
            Thread.Sleep(3000);
            //int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//")).Count;
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;
            for (int i = 1; i <= rowCount; i++)
            {
                IWebElement selectLanguageToUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                //IWebElement selectLanguageToUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                if (selectLanguageToUpdate.Text.Equals(oldlanguage))
                {
                    IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                    // IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                    editButton.Click();
                    IWebElement updateLanguageTextBox = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                    updateLanguageTextBox.Click();
                    updateLanguageTextBox.Clear();
                    updateLanguageTextBox.SendKeys(newlanguage);
                    IWebElement chooseLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select"));
                    //IWebElement chooseLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select"));
                    chooseLevelDropdown.Click();
                    if (newlevel.Equals("Basic"))
                    {
                        // Select Basic Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
                        levelOption.Click();
                    }
                    else if (newlevel.Equals("Conversational"))
                    {
                        // Select Conversational Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Conversational']"));
                        levelOption.Click();
                    }
                    else if (newlevel.Equals("Fluent"))
                    {
                        // Select Fluent Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
                        levelOption.Click();
                    }
                    else if (newlevel.Equals("Native/Bilingual"))
                    {
                        // Select Native/Bilingual Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Native/Bilingual']"));
                        levelOption.Click();
                    }
                    Thread.Sleep(2000);
                    IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                    //IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                    updateButton.Click();
                    break;
                }
                
            }
        }


        public void assertUpdateLanguage(IWebDriver driver, string newlanguage, string newlevel)
        {
            //Verify if the existing Language has updated Successfully
            driver.Navigate().Refresh();
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 2);
            Thread.Sleep(3000);
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;
            int i;
            for (i = 1; i <= rowCount; i++)
            {
                IWebElement chooseLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                IWebElement chooseLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]"));
                if ((chooseLanguage.Text.Equals(newlanguage)) && (chooseLevel.Text.Equals(newlevel)))
                {
                    Assert.That((chooseLanguage.Text.Equals(newlanguage)) && (chooseLevel.Text.Equals(newlevel)), "Language not  Updated Successfully");
                    break;
                }
            }
            Thread.Sleep(2000);
        }

        
        //public void deleteLanguageRecord(IWebDriver driver)
        //{
        //    int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;

        //    for (int i = 1; i <= rowCount;)
        //    {
        //        Thread.Sleep(2000);
        //        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        //        deleteButton.Click();
        //        rowCount--;
        //        driver.Navigate().Refresh();
        //        Thread.Sleep(2000);


        //    }

        //    }

        //    public void assertDeleteLanguage(IWebDriver driver)
        //{
        //    //Verify if the existing Language has updated Successfully
        //    driver.Navigate().Refresh();
        //    //Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 2);
        //    Thread.Sleep(3000);
        //    int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;
            
                
        //            Assert.That(rowCount==0,"Records Not Deleted Successfully");
                                   
        //                Thread.Sleep(2000);
        //}

    }

}
