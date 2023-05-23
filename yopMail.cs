using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    [TestClass]
    public class yopMail
    {
        IWebDriver driver;

        [TestInitialize]
        public void OpenBrowser() 
        {
            Console.WriteLine("setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path+"/driver/chromedriver.exe");
            driver.Navigate().GoToUrl("https://yopmail.com/es");
        }

        [TestCleanup]
        public void CloseBrowser() 
        {
            Console.WriteLine("clean");
            driver.Quit();
        }

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly()
        {
            // insert/create new email

            driver.FindElement(By.ClassName("ycptinput")).Click();
            driver.FindElement(By.ClassName("ycptinput")).SendKeys("patito123");
            driver.FindElement(By.XPath("//*[@id=\"refreshbut\"]/button/i")).Click();


            // send email to himself
            
            driver.FindElement(By.Id("newmail")).Click();

            driver.SwitchTo().Frame("ifmail");

            driver.FindElement(By.Id("msgto")).Click();
            driver.FindElement(By.Id("msgto")).SendKeys("patito123");

            driver.FindElement(By.Id("msgsubject")).Click();
            driver.FindElement(By.Id("msgsubject")).SendKeys("asunto");

            driver.FindElement(By.ClassName("hc")).Click();
            driver.FindElement(By.ClassName("hc")).SendKeys("Hola, esta es una prueba");

            driver.FindElement(By.Id("msgsend")).Click();

            // cambiar el iframe
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.Id("refresh")).Click();

            Thread.Sleep(2000);

            driver.SwitchTo().Frame("ifinbox");

            Assert.IsTrue(driver.FindElement(By.ClassName("lmfd")).Displayed, 
                "ERROR !! the verification was not successfully, review new emails");

        }
    }
}