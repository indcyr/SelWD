﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.PageObjects
{
    internal class RediffHomePage
    {
        IWebDriver? driver = null;
        public RediffHomePage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        //Arrange
        [FindsBy(How = How.LinkText, Using = "Create Account")]
        public IWebElement? CreateAccountLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sign in")]
        public IWebElement? SignInLink { get; set; }

        //Act
        public void CreateAccountClick()
        {
            CreateAccountLink?.Click();
        }
        public void SignInClick() 
        {
            SignInLink?.Click(); 
        }
    }
}
