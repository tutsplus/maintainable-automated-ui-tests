﻿using MvcMusicStore.FunctionalTests.Framework;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests
{
    public class BrittleTest
    {
        [Test]
        public void Can_buy_an_Album_when_registered()
        {
            var driver = Host.Instance.WebDriver;
            driver.Navigate().GoToUrl(driver.Url);
            driver.FindElement(By.LinkText("Admin")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("UserName")).Clear();
            driver.FindElement(By.Id("UserName")).SendKeys("HJSimpson");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("chunkylover53@aol.com");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("!2345Qwert");
            driver.FindElement(By.Id("ConfirmPassword")).Clear();
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("!2345Qwert");
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            driver.FindElement(By.LinkText("Disco")).Click();
            driver.FindElement(By.CssSelector("img[alt=\"Le Freak\"]")).Click();
            driver.FindElement(By.LinkText("Add to cart")).Click();
            driver.FindElement(By.LinkText("Checkout >>")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("Homer");
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("Simpson");
            driver.FindElement(By.Id("Address")).Clear();
            driver.FindElement(By.Id("Address")).SendKeys("742 Evergreen Terrace");
            driver.FindElement(By.Id("City")).Clear();
            driver.FindElement(By.Id("City")).SendKeys("Springfield");
            driver.FindElement(By.Id("State")).Clear();
            driver.FindElement(By.Id("State")).SendKeys("Kentucky");
            driver.FindElement(By.Id("PostalCode")).Clear();
            driver.FindElement(By.Id("PostalCode")).SendKeys("123456");
            driver.FindElement(By.Id("Country")).Clear();
            driver.FindElement(By.Id("Country")).SendKeys("United States");
            driver.FindElement(By.Id("Phone")).Clear();
            driver.FindElement(By.Id("Phone")).SendKeys("2341231241");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("chunkylover53@aol.com");
            driver.FindElement(By.Id("PromoCode")).Clear();
            driver.FindElement(By.Id("PromoCode")).SendKeys("FREE");
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();

            Assert.IsTrue(driver.PageSource.Contains("Checkout Complete"));
        }
    }
}