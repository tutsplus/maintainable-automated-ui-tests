using MvcMusicStore.FunctionalTests.Framework;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests.StronglyTypedPageObjects
{
    public class AlbumDetailPage : Page
    {
        public ShoppingCartPage AddAlbumToCart()
        {
            return NavigateTo<ShoppingCartPage>(By.LinkText("Add to cart"));
        }
    }
}