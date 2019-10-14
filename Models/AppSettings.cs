namespace WK.Apps.Sharp64.Models.Settings
{
    /// <summary>
    /// Provides the list of settings required by the application.
    /// </summary>
    public class AppSettings
    {
        #region Constructor

        public AppSettings() { }

        #endregion

        #region Properties

        public bool TopMost { get; set; } = false;
        public bool ShowPopup { get; set; } = true;
        public bool AllowHotkeySelections { get; set; } = false;
        public string SelectionHotkey { get; set; } = "Control + F7";

        #endregion
    }
}