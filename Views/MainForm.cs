using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Transitions;
using Bunifu.UI.WinForms;

using WK.Apps.Sharp64.Helpers;
using WK.Libraries.HotkeyListenerNS;
using WK.Apps.Sharp64.Models.Settings;
using WK.Apps.TranslatrNS.Controllers.Settings;

namespace WK.Apps.Sharp64.Views
{
    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            _instance = this;
        }

        #endregion

        #region Fields

        // These two lists are used to save the controls
        // contained within the two panels when swapping.
        private List<Control> _panel1Controls = new List<Control>();
        private List<Control> _panel2Controls = new List<Control>();

        // These are used to minimize the window 
        // using the CreateParams override.
        private const int CS_DBLCLKS = 0x8;
        private const int WS_MINIMIZEBOX = 0x20000;

        private static MainForm _instance;
        private Settings _settings = new Settings();
        public static HotkeyListener HotkeyListener = new HotkeyListener();

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the MainForm.
        /// </summary>
        public static MainForm Instance
        {
            get {

                if (_instance == null)
                    _instance = new MainForm();

                return _instance;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the 
        /// default conversion is from Base64 to plain text.
        /// </summary>
        public bool DefaultConversion { get; set; } = true;

        /// <summary>
        /// Gets a value indicating whether 
        /// the Image Viewer is visible.
        /// </summary>
        public bool ImageViewerVisible { get => pnlImageViewer.Visible; }

        /// <summary>
        /// Gets or sets the application's settings. 
        /// Use the <see cref="SettingsManager"/> 
        /// to read or write to the application's settings.
        /// </summary>
        public static AppSettings ApplicationSettings { get; set; }

        /// <summary>
        /// Lets you manage the application's settings by 
        /// using the provided <see cref="ApplicationSettings"/> object.
        /// </summary>
        public static SettingsController SettingsManager { get; set; } = new SettingsController();

        #endregion

        #region Methods

        #region Window Management

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

                    try
                    {
                        notifyIcon1.Visible = false;
                    }
                    catch (Exception) { }

                    Application.Exit();
                };
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Overriden the default parameters to 
        /// provide window minimizing features.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get {

                CreateParams cp = base.CreateParams;

                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;

                return cp;
            }
        }

        #endregion

        /// <summary>
        /// Minimizes the window.
        /// </summary>
        public void Minimize()
        {
            // This will provide the default animation
            // whenever the form is minimized.
            FormBorderStyle = FormBorderStyle.Sizable;

            bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Minimized;

            // Let's restore the window's style back to no-border.
            FormBorderStyle = FormBorderStyle.None;
        }

        /// <summary>
        /// Shows or hides the window.
        /// </summary>
        public void ShowOrHide()
        {
            if (Visible)
                Hide();
            else
                Show();
        }

        /// <summary>
        /// Maximizes or restores the window.
        /// </summary>
        /// <param name="shortcutInvoked">
        /// Is the method being invoked using shortcut keys?
        /// </param>
        public void MaximizeRestore(bool shortcutInvoked = false)
        {
            if (bunifuFormDock1.WindowState == BunifuFormDock.FormWindowStates.Normal)
            {
                bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Maximized;
                pbMaximize.Image = Properties.Resources.restore;
                bunifuToolTip1.SetToolTip(pbMaximize, "Restore");

                if (!shortcutInvoked)
                {
                    if (DefaultConversion)
                        txtRaw.Focus();
                    else
                        txtConversion.Focus();
                }
            }
            else if (bunifuFormDock1.WindowState == BunifuFormDock.FormWindowStates.Maximized)
            {
                bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Normal;
                pbMaximize.Image = Properties.Resources.maximize;
                bunifuToolTip1.SetToolTip(pbMaximize, "Maximize");

                if (!shortcutInvoked)
                {
                    if (DefaultConversion)
                        txtRaw.Focus();
                    else
                        txtConversion.Focus();
                }
            }
        }

        /// <summary>
        /// Minimizes or restores the window.
        /// </summary>
        public void MinimizeRestore()
        {
            if (bunifuFormDock1.WindowState ==
                BunifuFormDock.FormWindowStates.Minimized)
            {
                bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Normal;
                WindowState = FormWindowState.Normal;

                if (DefaultConversion)
                    txtRaw.Focus();
                else
                    txtConversion.Focus();

                return;
            }

            if (Visible)
            {
                PinToSystemTray();
            }
            else
            {
                Show();

                if (DefaultConversion)
                    txtRaw.Focus();
                else
                    txtConversion.Focus();
            }
        }

        /// <summary>
        /// Restores the window.
        /// </summary>
        public void Restore()
        {
            if (bunifuFormDock1.WindowState ==
                BunifuFormDock.FormWindowStates.Minimized)
            {
                bunifuFormDock1.WindowState = BunifuFormDock.FormWindowStates.Normal;
                WindowState = FormWindowState.Normal;

                if (DefaultConversion)
                    txtRaw.Focus();
                else
                    txtConversion.Focus();

                return;
            }

            if (notifyIcon1.Visible)
                Show();

            if (DefaultConversion)
                txtRaw.Focus();
            else
                txtConversion.Focus();

            Activate();
        }

        /// <summary>
        /// Pins the window to the System Tray area.
        /// </summary>
        public void PinToSystemTray()
        {
            notifyIcon1.Visible = true;

            Hide();
        }

        /// <summary>
        /// Applies the standard window settings.
        /// </summary>
        public void ApplyWindowSettings()
        {
            try
            {
                bunifuFormDock1.SubscribeControlsToDragEvents(
                    new Control[] { pbAppIcon, lblTitle }, true);

                bunifuToolTip1.SetToolTip(pbAppIcon, $"v{Application.ProductVersion}");

                TopMost = ApplicationSettings.TopMost;
                Text = $"{Application.ProductName} v{Application.ProductVersion}";
                notifyIcon1.Text = Text;
            }
            catch (Exception) { }
        }

        #endregion

        #region Features Management
        
        /// <summary>
        /// Displays the image viewer panel.
        /// </summary>
        public void ShowImageViewer()
        {
            pnlImageViewer.Show();
            pnlImageViewer.BringToFront();
        }

        /// <summary>
        /// Hides the image viewer panel.
        /// </summary>
        public void HideImageViewer()
        {
            pnlImageViewer.Hide();
            pnlImageViewer.SendToBack();

            if (DefaultConversion)
            {
                txtRaw.Focus();

                // Prevents highlighting all text.
                txtRaw.SelectionStart = 0;
                txtRaw.SelectionLength = 0;
            }
            else
            {
                txtConversion.Focus();

                // Prevents highlighting all text.
                txtRaw.SelectionStart = 0;
                txtRaw.SelectionLength = 0;
            }
        }

        /// <summary>
        /// Displays or hides the image viewer panel if visible.
        /// </summary>
        public void ShowOrHideImageViewer()
        {
            if (ImageViewerVisible)
                HideImageViewer();
            else
                ShowImageViewer();
        }

        /// <summary>
        /// Shows the settings window.
        /// </summary>
        private void ShowSettings()
        {
            _settings.Show();
        }

        /// <summary>
        /// Updates and saves the current application settings.
        /// </summary>
        public static void ApplySettings()
        {
            SettingsManager.SetAppSettings(ApplicationSettings);
        }

        /// <summary>
        /// Displays a loading indicator at the conversion panel.
        /// </summary>
        public void ShowLoadingIndicator()
        {
            pgiLoader.Show();
            pgiLoader.BringToFront();
            pgiLoader.AutoStart = true;
        }

        /// <summary>
        /// Hides the loading indicator at the conversion panel.
        /// </summary>
        public void HideLoadingIndicator()
        {
            pgiLoader.Hide();
            pgiLoader.SendToBack();
            pgiLoader.AutoStart = false;
        }

        /// <summary>
        /// Zooms-in text in any of the 
        /// available inputs when focused.
        /// </summary>
        public void ZoomInText()
        {
            if (txtRaw.Input.Focused)
            {
                txtRaw.Font = new Font(txtRaw.Font.FontFamily, 
                    txtRaw.Font.SizeInPoints + 1F, txtRaw.Font.Style);

                txtRaw.Refresh();
            }

            if (txtConversion.Input.Focused)
            {
                txtConversion.Font = new Font(txtConversion.Font.FontFamily, 
                    txtConversion.Font.SizeInPoints + 1F, txtConversion.Font.Style);

                txtConversion.Refresh();
            }
        }

        /// <summary>
        /// Zooms-out text in any of the 
        /// available inputs when focused.
        /// </summary>
        public void ZoomOutText()
        {
            if (txtRaw.Input.Focused)
            {
                txtRaw.Font = new Font(txtRaw.Font.FontFamily,
                    txtRaw.Font.SizeInPoints - 1F, txtRaw.Font.Style);

                txtRaw.Refresh();
            }

            if (txtConversion.Input.Focused)
            {
                txtConversion.Font = new Font(txtConversion.Font.FontFamily,
                    txtConversion.Font.SizeInPoints - 1F, txtConversion.Font.Style);

                txtConversion.Refresh();
            }
        }

        /// <summary>
        /// Lets the user choose any supported file to 
        /// be encoded/decoded and outputs the results.
        /// </summary>
        /// <param name="allowImagesOnly">
        /// Allow only supported images to be selected?
        /// </param>
        public void EncodeFile(bool allowImagesOnly = false)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Multiselect = false;
            fileDialog.RestoreDirectory = true;
            fileDialog.SupportMultiDottedExtensions = true;
            fileDialog.Title = "Choose a file or image to decode...";

            // To fully add filters, you'll need to update the 
            // "EncoderDecoder.IsSupportedFile()" and/or 
            // the "EncoderDecoder.IsSupportedImage()" 
            // methods to reflect the filters added.
            fileDialog.Filter =
                // Text filters.
                (allowImagesOnly ? "" :
                "Encoded Files |*.enc;*enci;*.txt;|Code Files |*.html;*.css;*.js;*.php;*.cs;" +
                "*.java;*.py;*.rb;*.ps;*.ps1;*.vb|") +
                // Image filters.
                "Images |*.enci;*.jpg;*.jpeg;*.gif;*.png;*.ico;*.tif;*.tiff";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                ShowLoadingIndicator();

                if (EncoderDecoder.IsSupportedFile(path))
                {
                    string content = File.ReadAllText(path);

                    if (EncoderDecoder.IsBase64Formatted(content))
                    {
                        txtRaw.Text = EncoderDecoder.Base64Decode(content);
                    }
                    else
                    {
                        txtRaw.Text = content;
                    }
                }
                else if (EncoderDecoder.IsSupportedImage(path))
                {
                    if (Path.GetExtension(path).ToLower() == ".enci")
                    {
                        string content = File.ReadAllText(path);
                        txtConversion.Text = content;

                        pbImageViewer.Image = EncoderDecoder.Base64DecodeImage(content);
                        lblImageFilename.Text = Path.GetFileName(path);

                        ShowImageViewer();
                    }
                    else
                    {
                        if (txtConversion.Focused)
                        {
                            txtConversion.Text = string.Empty;

                            pbImageViewer.Image = EncoderDecoder.Base64DecodeImage(path);
                            lblImageFilename.Text = Path.GetFileName(path);

                            ShowImageViewer();
                        }
                        else
                        {
                            txtRaw.Text = string.Empty;

                            txtConversion.Text = EncoderDecoder.Base64EncodeImage(path);
                            lblImageFilename.Text = Path.GetFileName(path);
                            pbImageViewer.ImageLocation = path;

                            ShowImageViewer();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a supported text or image file.");
                }

                HideLoadingIndicator();
            }
        }

        /// <summary>
        /// Saves the currently encoded text or image as a file.
        /// </summary>
        public void SaveEncodingAsFile()
        {
            if (!string.IsNullOrWhiteSpace(txtConversion.Text))
            {
                SaveFileDialog fileDialog = new SaveFileDialog();

                fileDialog.RestoreDirectory = true;
                fileDialog.SupportMultiDottedExtensions = true;
                fileDialog.Title = "Save encoding as file...";
                fileDialog.Filter = 
                    $"{(ImageViewerVisible ? "Encoded Images (*.enci)|*.enci|" : "")}" +
                    "Encoded Files (*.enc)|*.enc|Text Files (*.txt)|*.txt";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(fileDialog.FileName, txtConversion.Text);

                    MessageBox.Show(
                        "The encoding was successfully saved to: \n" +
                        $"{fileDialog.FileName}");
                }
            }
        }

        /// <summary>
        /// Swaps encoding/decoding inputs to either 
        /// sides together with their tasks.
        /// </summary>
        public void SwapSides()
        {
            _panel1Controls.Clear();
            _panel2Controls.Clear();

            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox)
                {
                    _panel1Controls.Add(control);
                    splitContainer1.Panel1.Controls.Remove(control);
                }
            }

            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                _panel2Controls.Add(control);
            }

            splitContainer1.Panel2.Controls.Clear();

            foreach (Control hostedControl in _panel1Controls)
            {
                if (hostedControl is Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox)
                {
                    hostedControl.Dock = DockStyle.Fill;
                }

                splitContainer1.Panel2.Controls.Add(hostedControl);
            }

            foreach (Control hostedControl in _panel2Controls)
            {
                if (hostedControl is Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox)
                {
                    hostedControl.Dock = DockStyle.Fill;
                }

                splitContainer1.Panel1.Controls.Add(hostedControl);
            }

            foreach (Control hostedControl in splitContainer1.Panel1.Controls)
            {
                if (hostedControl is Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox)
                {
                    if (hostedControl.Name == "txtRaw")
                        DefaultConversion = true;
                    else
                        DefaultConversion = false;

                    hostedControl.Focus();
                }
            }
        }

        /// <summary>
        /// Registers the user-applied hotkeys.
        /// </summary>
        public void RegisterHotkeys()
        {
            HotkeyListener.AddHotkey(ApplicationSettings.SelectionHotkey);
            HotkeyListener.HotkeyPressed += OnHotkeyPressed;
        }

        /// <summary>
        /// Encodes the selected text from any application.
        /// </summary>
        public void EncodeDecodeSelection()
        {
            if (!TopMost)
                TopMost = true;

            string clipboardText = Clipboard.GetText();
            SendKeys.SendWait("^c");

            string selection = Clipboard.GetText();
            Clipboard.SetText(clipboardText);
            
            Restore();

            if (DefaultConversion)
            {
                if (EncoderDecoder.IsBase64Formatted(selection))
                {
                    txtConversion.Input.Focus();
                    txtConversion.Text = selection;
                }
                else
                {
                    txtRaw.Input.Focus();
                    txtRaw.Text = selection;
                }
            }
            else
            {
                txtConversion.Input.Focus();
                txtConversion.Text = selection;
            }

            TopMost = ApplicationSettings.TopMost;
        }

        #endregion

        #endregion

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            // This will simply animate 
            // the window when loading.
            Show();

            ApplicationSettings = SettingsManager.GetAppSettings();

            ApplyWindowSettings();
            RegisterHotkeys();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            txtRaw.Focus();
        }

        private async void TxtRaw_TextChanged(object sender, EventArgs e)
        {
            if (DefaultConversion && txtRaw.Focused)
                txtConversion.Text = await EncoderDecoder.Base64EncodeAsync(txtRaw.Text);
            else
                txtRaw.Text = await EncoderDecoder.Base64DecodeAsync(txtConversion.Text);
        }

        private async void TxtConversion_TextChanged(object sender, EventArgs e)
        {
            if (txtConversion.Focused)
                txtRaw.Text = await EncoderDecoder.Base64DecodeAsync(txtConversion.Text);
        }

        private void OnIputsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && 
                e.KeyCode == Keys.O)
            {
                EncodeFile();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.Modifiers == Keys.Control &&
                e.KeyCode == Keys.S)
            {
                SaveEncodingAsFile();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.Modifiers == Keys.Control &&
                e.KeyCode == Keys.I)
            {
                ShowOrHideImageViewer();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.Modifiers == Keys.Control &&
                e.KeyCode == Keys.Oemplus)
            {
                ZoomInText();
            }

            if (e.Modifiers == Keys.Control &&
                e.KeyCode == Keys.OemMinus)
            {
                ZoomOutText();
            }

            if (e.KeyCode == Keys.F11)
            {
                MaximizeRestore(true);
            }

            if (e.KeyCode == Keys.Escape)
            {
                Minimize();
            }
        }

        private void OnHotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == ApplicationSettings.SelectionHotkey)
            {
                if (ApplicationSettings.AllowHotkeySelections &&
                    !string.IsNullOrWhiteSpace(ApplicationSettings.SelectionHotkey))
                {
                    EncodeDecodeSelection();
                }
            }
        }

        private void PnlImageViewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control &&
                e.KeyCode == Keys.I)
            {
                ShowOrHideImageViewer();
            }
        }

        private void BtnSwapSides_Click(object sender, EventArgs e)
        {
            SwapSides();
        }

        private void PbSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void PbMaximize_Click(object sender, EventArgs e)
        {
            MaximizeRestore();
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            Minimize();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PbCloseImageViewer_Click(object sender, EventArgs e)
        {
            HideImageViewer();
        }

        private void PbChooseImage_Click(object sender, EventArgs e)
        {
            EncodeFile(true);
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }

        #endregion
    }
}