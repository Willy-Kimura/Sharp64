using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;
using WK.Apps.Sharp64.Helpers;

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

        #region Properties

        /// <summary>
        /// Gets or sets the globally selected text.
        /// </summary>
        public string Selection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the 
        /// default conversion is from Base64 to plain text.
        /// </summary>
        public bool DefaultConversion { get; set; } = true;

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
                    base.Hide();
                };
            }
            catch (Exception) { }
        }

        #endregion

        public async void EncodeDecode()
        {
            txtConversion.Text = string.Empty;

            if (EncoderDecoder.IsBase64Formatted(Selection))
            {
                DefaultConversion = true;
                txtConversion.Text = await EncoderDecoder.Base64DecodeAsync(Selection);
            }
            else
            {
                DefaultConversion = false;
                txtConversion.Text = await EncoderDecoder.Base64EncodeAsync(Selection);
            }
        }

        public async void SwapSides()
        {
            if (EncoderDecoder.IsBase64Formatted(txtConversion.Text))
            {
                DefaultConversion = true;
                txtConversion.Text = await EncoderDecoder.Base64DecodeAsync(txtConversion.Text);
            }
            else
            {
                DefaultConversion = false;
                txtConversion.Text = await EncoderDecoder.Base64EncodeAsync(txtConversion.Text);
            }
        }

        #endregion

        #region Events

        private void Popup_Load(object sender, EventArgs e)
        {
            bunifuFormDock1.SubscribeControlsToDragEvents(
                new Control[] { lblTitle, pbAppIcon }, true);
        }

        private void Popup_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void btnSwapSides_Click(object sender, EventArgs e)
        {
            SwapSides();
        }

        private void Popup_Deactivate(object sender, EventArgs e)
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