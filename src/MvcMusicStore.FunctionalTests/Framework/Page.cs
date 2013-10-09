using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace MvcMusicStore.FunctionalTests.Framework
{
    public class Page
    {
        protected RemoteWebDriver WebDriver
        {
            get { return Host.Instance.WebDriver; }
        }

        public string Title { get { return WebDriver.Title; }}

        public TPage NavigateTo<TPage>(By by) where TPage:Page, new()
        {
            WebDriver.FindElement(by).Click();
            return Activator.CreateInstance<TPage>();
        }

        public void Execute(By by, Action<IWebElement> action)
        {
            var element = WebDriver.FindElement(by);
            action(element);
        }

        public void SetText(string elementName, string newText)
        {
            Execute(By.Name(elementName), e =>
                {
                    e.Clear();
                    e.SendKeys(newText);
                } );
        }
    }
}
