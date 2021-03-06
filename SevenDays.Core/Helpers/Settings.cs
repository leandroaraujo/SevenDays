// Helpers/Settings.cs

using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SevenDays.Core.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters.
	/// </summary>
	public class Settings : SevenDays.Core.Interfaces.ISettings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        #region Setting Constants

        private const string SevendaysSelectedServerKey = "sevendays_selected_server";

        private const string UseAdsKey = "showAds";

        private const string PageSizeKey = "page_size";

        #endregion

        public string SevendaysSelectedServer
        {
            get { return AppSettings.GetValueOrDefault(SevendaysSelectedServerKey, ""); }
            set { AppSettings.AddOrUpdateValue(SevendaysSelectedServerKey, value); }
        }

        public static bool ShowAds
        {
            get { return AppSettings.GetValueOrDefault(UseAdsKey, true); }
            set { AppSettings.AddOrUpdateValue(UseAdsKey, value); }
        }

        public static int PageSize
        {
            get { return AppSettings.GetValueOrDefault(PageSizeKey, 30); }
            set { AppSettings.AddOrUpdateValue(PageSizeKey, value); }
        }
    }
}