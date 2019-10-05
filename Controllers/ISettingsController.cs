namespace WK.Apps.Sharp64.Controllers.Settings
{
    /// <summary>
    /// Provides the standard implementation of all
    /// settings controllers within the application.
    /// </summary>
    public interface ISettingsController
    {
        /// <summary>
        /// Implements the path to the application's settings folder.
        /// </summary>
        string SettingsFolder { get; }

        /// <summary>
        /// Implements the path to the application's settings file.
        /// </summary>
        string AppSettingsPath { get; }

        /// <summary>
        /// Implements the path to the application's startup settings file.
        /// </summary>
        string StartupSettingsPath { get; }
    }
}