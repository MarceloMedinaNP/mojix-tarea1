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
    public class IntentoYopMail : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite(); 



        [TestMethod]
        public void VerifyCRUDProject()
        {
            leftSite.mailNameTxtBox.Click();
            leftSite.mailNameTxtBox.SetText("patito");
            leftSite.accesButton.Click();
 
            leftSite.newMailButton.Click();

  //          driver.SwitchTo().Frame("ifmail");

            leftSite.newMailToText.SetText("patito");

            // add verificacion
            Assert.IsTrue(driver.FindElement(By.ClassName("lmfd")).Displayed, "ERROR!The project was not created");

 

        }

    }
}
