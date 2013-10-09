using MvcMusicStore.FunctionalTests.Framework;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests.PageObjects
{
    public class AlbumDetailPage : Page
    {
        public ShoppingCartPage AddToCart()
        {
            return NavigateTo<ShoppingCartPage>(By.LinkText("Add to cart"));
        }
    }
}