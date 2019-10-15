using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;
using WK.Apps.Sharp64.Helpers;

namespace WK.Apps.Sharp64.Views
{
    public partial class About : Form
    {
        #region Constructor

        public About()
        {
            InitializeComponent();
        }

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

        private void About_Load(object sender, EventArgs e)
        {
            bunifuFormDock1.SubscribeControlsToDragEvents(
                new Control[] { lblTitle, pbAppIcon }, true);
        }

        private void About_Shown(object sender, EventArgs e)
        {
            Activate();

            lblAppName.Text = $"{Application.ProductName} ({Application.ProductVersion})";
            lblAppName.Left = (Width - lblAppName.Width) / 2;
        }
        
        private void About_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
        
        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            Close();

            MainForm.Instance.CheckForUpdates();
        }

        private void pbBuyCoffee_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.buymeacoffee.com/willykimura");
        }

        #endregion
    }
}