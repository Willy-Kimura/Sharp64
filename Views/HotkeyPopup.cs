using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;
using Bunifu.UI.WinForms;

namespace WK.Apps.Sharp64.Views
{
    public partial class HotkeyPopup : Form
    {
        #region Constructor

        public HotkeyPopup()
        {
            InitializeComponent();
        }

        #endregion

        #region Fields
        
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

            Transition.run(this, "Opacity", 1.0, new TransitionType_EaseInEaseOut(220));
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
                Transition transition = new Transition(new TransitionType_EaseInEaseOut(220));

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
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void Settings_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void txtHotkey_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
        
        #endregion
    }
}