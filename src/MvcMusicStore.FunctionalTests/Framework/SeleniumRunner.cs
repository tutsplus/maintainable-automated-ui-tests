using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace MvcMusicStore.FunctionalTests.Framework
{
    internal class SeleniumApplication
    {
        private IisExpressWebServer _webServer;
        private RemoteWebDriver _webDriver;

        public RemoteWebDriver WebDriver { get { return _webDriver; } }
        public IisExpressWebServer WebServer { get { return _webServer; } }

        public void Run(string webProjectFolder, int portNumber)
        {
            var webApplication = new WebApplication(ProjectLocation.FromFolder(webProjectFolder), portNumber);
            _webServer = new IisExpressWebServer(webApplication);
            _webServer.Start();
            _webDriver = new FirefoxDriver();
            _webDriver.Navigate().GoToUrl(_webServer.BaseUrl);

            AppDomain.CurrentDomain.DomainUnload += CurrentDomainDomainUnload;
        }

        private void CurrentDomainDomainUnload(object sender, EventArgs e)
        {
            _webDriver.Close();
            _webServer.Stop();
        }
    }
}
