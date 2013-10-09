using MvcMusicStore.FunctionalTests.Framework;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests.PageObjects
{
    public class RegisterPage : Page
    {
        public HomePage SubmitRegistration()
        {
            return NavigateTo<HomePage>(By.CssSelector("input[type='submit']"));
        }

        public string Username          { set { SetText("UserName", value); } }
        public string Email             { set { SetText("Email", value); } }
        public string ConfirmPassword   { set { SetText("ConfirmPassword", value); } }
        public string Password          { set { SetText("Password", value); } }
    }
}