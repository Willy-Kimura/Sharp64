using System;
using System.IO;

using Newtonsoft.Json;
using WK.Apps.Sharp64.Models.Settings;
using WK.Apps.Sharp64.Controllers.Settings;

namespace WK.Apps.TranslatrNS.Controllers.Settings
{
    /// <summary>
    /// Assists in the reading and writing
    /// of application-settings objects.
    /// </summary>
    public class SettingsController : ISettingsController
    {
        #region Fields

        private static string _path = Environment.GetFolderPath(
                                Environment.SpecialFolder.CommonApplicationData) +
                                $"\\Willy Kimura\\Sharp64";

        #endregion

        #region Interface

        /// <summary>
        /// Gets the path to the application's settings folder.
        /// </summary>
        public string SettingsFolder { get => $"{_path}\\Resources\\Settings\\"; }

        /// <summary>
        /// Gets the path to the application's settings file.
        /// </summary>
        public string AppSettingsPath { get => $"{_path}\\Resources\\Settings\\ApplicationSettings.json"; }

        /// <summary>
        /// Gets the path to the application's startup settings file.
        /// </summary>
        public string StartupSettingsPath { get => $"{_path}\\Resources\\Settings\\StartupSettings.json"; }

        #endregion

        #region Properties

        public bool AppSettingsExists { get => File.Exists(AppSettingsPath); }
        public bool StartupSettingsExists { get => File.Exists(StartupSettingsPath); }
        
        #endregion

        #region Methods

        #region App Settings

        /// <summary>
        /// Reads the default application settings file, 
        /// returning the settings object.
        /// </summary>
        /// <returns>
        /// An <see cref="AppSettings"/> object.
        /// </returns>
        public AppSettings GetAppSettings()
        {
            if (!AppSettingsExists)
                SetAppSettings(new AppSettings());

            return JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(AppSettingsPath));
        }

        /// <summary>
        /// Writes to the default application settings file, 
        /// and returns a <see cref="Boolean"/> value indicating whether the
        /// settings have been updated successfully.
        /// </summary>
        /// <returns>
        /// True, if the settings file has been updated,
        /// or False if the settings-update failed.
        /// </returns>
        public bool SetAppSettings(AppSettings settings)
        {
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                if (!Directory.Exists(Path.GetDirectoryName(AppSettingsPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(AppSettingsPath));
                }

                File.WriteAllText(AppSettingsPath, JsonConvert.SerializeObject(settings).ToString());
                
                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        #region Startup Settings
        
        /// <summary>
        /// Reads the default startup settings file, 
        /// returning the settings object.
        /// </summary>
        /// <returns>
        /// A <see cref="StartupSettings"/> object.
        /// </returns>
        public StartupSettings GetStartupSettings()
        {
            StartupSettings startup = new StartupSettings();

            if (!Directory.Exists(Path.GetDirectoryName(AppSettingsPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(AppSettingsPath));
                SetStartupSettings(new StartupSettings() { FirstTime = true });
            }

            if (StartupSettingsExists)
            {
                string content = File.ReadAllText(StartupSettingsPath);
                
                try
                {
                    File.Delete(StartupSettingsPath);
                }
                catch (Exception) { }
                
                return JsonConvert.DeserializeObject<StartupSettings>(content);
            }
            else
            {
                return startup;
            }
        }

        /// <summary>
        /// Writes to the default startup settings file, 
        /// and returns a <see cref="Boolean"/> value indicating whether the
        /// settings have been updated successfully.
        /// </summary>
        /// <returns>
        /// True, if the settings file has been updated,
        /// or False if the settings-update failed.
        /// </returns>
        private bool SetStartupSettings(StartupSettings settings)
        {
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                File.WriteAllText(StartupSettingsPath, JsonConvert.SerializeObject(settings).ToString());

                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion
        
        #endregion
    }
}