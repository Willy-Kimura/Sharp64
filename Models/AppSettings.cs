namespace WK.Apps.Sharp64.Models.Settings
{
    /// <summary>
    /// Provides the list of settings required by the application.
    /// </summary>
    public class AppSettings
    {
        #region Constructor

        public AppSettings()
        {

        }

        #endregion

        #region Properties

        public bool TopMost { get; set; } = false;
        public bool AllowHotkeySelections { get; set; } = true;
        public string SelectionHotkey { get; set; } = string.Empty;

        #endregion
    }
}