namespace MvcMusicStore.FunctionalTests.Framework
{
    public class Host
    {
        internal static readonly SeleniumApplication Instance = new SeleniumApplication();
        static Host()
        {
            Instance.Run("MvcMusicStore", 12345);
        }
    }
}