using SpecFlow_GithubActions.Drivers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace SpecFlow_GithubActions.Pages
{
    public class AddElementsPage
    {
        public string pageHeaderXpath = "//div[@id='content']/h3";
        public string addElementButtonXpath = "//button[.='Add Element']";        
        public string createdElementsXpath = "//button[.='Delete']";
        public string expectedPageHeader = "Add/Remove Elements";
    }
}
