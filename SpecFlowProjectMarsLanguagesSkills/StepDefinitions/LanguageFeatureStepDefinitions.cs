using SpecFlowProjectMarsLanguagesSkills.Utilities;
using SpecFlowProjectMarsLanguagesSkills.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowProjectMarsLanguagesSkills.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        LanguagePage languagePageObj = new LanguagePage();


        [Given(@"User logs into Mars portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
            driver = new ChromeDriver();
            homePageObj.SignInActions(driver);
        }

        [Given(@"User navigates to Profile page")]
        public void GivenUserNavigatesToProfilePage()
        {
            loginPageObj.LoginActions(driver);
        }


        [Given(@"User selects the Language tab '([^']*)'")]
        public void GivenUserSelectsTheLanguageTab(string language)
        {
            profilePageObj.ClickLanguageTab(driver, language);

        }

        [When(@"User deletes all the records")]
        public void WhenUserDeletesAllTheRecords()
        {
            languagePageObj.deleteLanguageRecord(driver);
        }

        [Then(@"User should not be able to view the deleted language record")]
        public void ThenUserShouldNotBeAbleToViewTheDeletedLanguageRecord()
        {
            languagePageObj.assertDeleteLanguage(driver);
        }


        [When(@"User adds a new language record '([^']*)' '([^']*)'")]
        public void WhenUserAddsANewLanguageRecord(string language, string level)

        {
            
            languagePageObj.AddNewLanguage(driver, language, level);
        }



        [Then(@"Mars portal should save the new language record '([^']*)'")]
        public void ThenMarsPortalShouldSaveTheNewLanguageRecord(string language)
        {
            languagePageObj.assertAddNewLanguage(driver, language);
        }



        [When(@"User edits an existing language record '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditsAnExistingLanguageRecord(string oldlanguage, string oldlevel, string newlanguage, string newlevel)
        {
            languagePageObj.updateLanguage(driver, oldlanguage, oldlevel, newlanguage, newlevel);
        }


        [Then(@"Mars portal should save the updated language record '([^']*)' '([^']*)'")]
        public void ThenMarsPortalShouldSaveTheUpdatedLanguageRecord(string newlanguage, string newlevel)
        {
            languagePageObj.assertUpdateLanguage(driver, newlanguage, newlevel);
        }

        //[When(@"User deletes all the records")]
        //public void WhenUserDeletesAllTheRecords()
        //{
        //    languagePageObj.deleteLanguageRecord(driver);
        //}

        //[Then(@"User should not be able to view the deleted language record")]
        //public void ThenUserShouldNotBeAbleToViewTheDeletedLanguageRecord()
        //{
        //    languagePageObj.assertDeleteLanguage(driver);
        //}




        [AfterScenario]
        public void Closedriver()
        {
            driver.Close();
        }

    }
}
