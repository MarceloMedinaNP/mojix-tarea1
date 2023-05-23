using OpenQA.Selenium;
using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();



        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly2()
        {
            mainPage.loginButton.Click();
            loginSection.emailTxtBox.SetText("bootcamp2@mojix.com");
            loginSection.pwdTxtBox.SetText("12345");
            loginSection.loginButton.Click();

            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");
        }

    }
}
