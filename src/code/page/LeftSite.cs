using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.HeapProfiler;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LeftSite
    {
        public Button addNewProjectButton = new Button(By.XPath("//div[@id='left_menu']//button[@class='_8313bd46 f169a390 _8b7f1a82 _8644eccb _2a3b75a1']"));
        public TextBox mailNameTxtBox = new TextBox(By.ClassName("ycptinput"));
        public Button accesButton = new Button(By.XPath("//*[@id=\"refreshbut\"]/button/i"));

        public Button newMailButton = new Button(By.Id("newmail"));
        public TextBox newMailToText = new TextBox(By.Id("msgto"));
        public Button newMailSubjectText = new Button(By.Id("msgsubject"));
        public Button newMailContentText = new Button(By.ClassName("hc"));
        public Button SendNewMailButton = new Button(By.Id("msgsend"));


       
        public Boolean ProjectNameIsDisplayed(String nameValue) 
        {
            Label nameProject = new Label(By.XPath("(//div[@class='_2a3b75a1']//span[text()='"+nameValue+"'])[last()]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//div[@class='_2a3b75a1']//span[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }

    }
}
