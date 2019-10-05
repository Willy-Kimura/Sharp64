namespace WK.Apps.Sharp64.Models.Settings
{
    /// <summary>
    /// Provides the entry-point settings required by the application.
    /// </summary>
    public class StartupSettings
    {
        #region Properties

        /// <summary>
        /// This checks if the application is being launched for the first time as per 
        /// the current instance. The hosting-file is destroyed once checking is complete.
        /// </summary>
        public bool FirstTime { get; set; }

        #endregion
    }
}