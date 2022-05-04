﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWendriver.ComponentHelper;
using SeleniumWendriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWendriver.TestScript.JavaScript
{
    [TestClass]
    public class TestJavaScriptClass
    {
        [TestMethod]
        public void TestJavaScript()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/bdd-with-selenium-webdriver-and-speckflow-using-c/");
            //Thread.Sleep(1000);
            //IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//button[contains(text(),'OK')]"));
            //element.Click();
            //Thread.Sleep(10000);

            //LinkHelper.ClickLink(By.LinkText("File a Bug"));
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.Driver);
            //executor.ExecuteScript("document.getElementById('Bugzilla_login').value='rahul@bugzila.com'");
            //executor.ExecuteScript("document.getElementById('Bugzilla_password').value='rathore'");
            //executor.ExecuteScript("document.getElementById('log_in').click()");

            IWebElement elemen = ObjectRepository.Driver.FindElement(By.XPath("/html//body[@id='udemy']/div[@class='main-content-wrapper']/div[@class='main-content']//div[@class='ud-component--course-landing-page-udlite--course-landing-page']//div[@class='report-abuse--report-abuse-full-width--hCrJe']/button[@type='button']/span[.='Report abuse']"));
            executor.ExecuteScript("window.scrollTo(0," + elemen.Location.Y + ")");
            elemen.Click();

        }
    }
}
