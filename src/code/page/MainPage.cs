using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public  class MainPage
    {
        public Button loginButton = new Button(By.XPath("//ul/li/a[text()='Iniciar sesión']"));
    }
}
