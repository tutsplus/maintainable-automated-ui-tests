using MvcMusicStore.FunctionalTests.Framework;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests.PageObjects
{
    public class AddressAndPaymentPage : Page
    {
        public string FirstName { set { SetText("FirstName", value); } }
        public string LastName { set { SetText("LastName", value); } }
        public string Address { set { SetText("Address", value); } }
        public string City { set { SetText("City", value); } }
        public string State { set { SetText("State", value); } }
        public string PostalCode { set { SetText("PostalCode", value); } }
        public string Country { set { SetText("Country", value); } }
        public string Phone { set { SetText("Phone", value); } }
        public string Email { set { SetText("Email", value); } }
        public string PromoCode { set { SetText("PromoCode", value); } }

        public Page SubmitOrder()
        {
            return NavigateTo<Page>(By.CssSelector("input[type=submit]"));
        }
    }
}