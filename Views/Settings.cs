using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;
using Bunifu.UI.WinForms;

using WK.Libraries.HotkeyListenerNS;

namespace WK.Apps.Sharp64.Views
{
    public partial class Settings : Form
    {
        #region Constructor

        public Settings()
        {
            InitializeComponent();
        }

        #endregion

        #region Fields
        
        public HotkeySelector HotkeySelector = new HotkeySelector();

        #endregion

        #region Methods

        #region Overrides

        /// <summary>
        /// Displays the window with animation.
        /// </summary>
        public new void Show()
        {
            Opacity = 0.0;

            base.Show();

            Transition.run(this, "Opacity", 1.0, new TransitionType_EaseInEaseOut(500));
        }

        /// <summary>
        /// Hides the window with animation.
        /// </summary>
        public new void Hide()
        {
            Transition transition = new Transition(new TransitionType_EaseInEaseOut(220));

            transition.add(this, "Opacity", 0.0);
            transition.run();

            transition.TransitionCompletedEvent += delegate
            {
                base.Hide();
            };
        }

        /// <summary>
        /// Closes the window with animation.
        /// </summary>
        public new void Close()
        {
            try
            {
                Transition transition = new Transition(new TransitionType_EaseInEaseOut(400));

                transition.add(this, "Opacity", 0.0);
                transition.run();

                transition.TransitionCompletedEvent += delegate
                {
                    base.Close();
                };
            }
            catch (Exception) { }
        }
        
        #endregion

        #endregion

        #region Events

        private void Settings_Load(object sender, EventArgs e)
        {
            bunifuFormDock1.SubscribeControlsToDragEvents(
                new Control[] { lblTitle, pbAppIcon }, true);

            // Suspend hotkeys to prevent invoking 
            // feature when changing hotkeys.
            MainForm.HotkeyListener.SuspendHotkeys();

            HotkeySelector.Enable(txtHotkey.Input);
            txtHotkey.Text = MainForm.ApplicationSettings.SelectionHotkey;
            chkEnableHotkeySelection.Checked = MainForm.ApplicationSettings.AllowHotkeySelections;
            chkTopmost.Checked = MainForm.ApplicationSettings.TopMost;
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void Settings_Deactivate(object sender, EventArgs e)
        {
            MainForm.ApplicationSettings.SelectionHotkey = txtHotkey.Text;
            MainForm.ApplicationSettings.AllowHotkeySelections = chkEnableHotkeySelection.Checked;
            MainForm.ApplicationSettings.TopMost = chkTopmost.Checked;
            MainForm.Instance.TopMost = chkTopmost.Checked;

            MainForm.ApplySettings();

            // Resume using the applied hotkeys when closed.
            MainForm.HotkeyListener.ResumeHotkeys();

            Hide();
        }

        private void txtHotkey_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Minimized;
        }

        #endregion
    }
}
