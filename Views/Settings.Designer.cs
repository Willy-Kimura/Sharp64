namespace WK.Apps.Sharp64.Views
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pbAppIcon = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pbClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bdrSeparator1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.chkTopmost = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTopmost = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlEnableHotkeySelection = new System.Windows.Forms.Panel();
            this.pbShowPopupInfo = new System.Windows.Forms.PictureBox();
            this.lblShowPopup = new Bunifu.UI.WinForms.BunifuLabel();
            this.chkShowPopup = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtHotkey = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pbEnableHotkeySelectionInfo = new System.Windows.Forms.PictureBox();
            this.lblEnableHotkeySelection = new Bunifu.UI.WinForms.BunifuLabel();
            this.chkEnableHotkeySelection = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEnableHotkeySelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPopupInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnableHotkeySelectionInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.pbAppIcon);
            this.pnlTitleBar.Controls.Add(this.pbMinimize);
            this.pnlTitleBar.Controls.Add(this.pbClose);
            this.pnlTitleBar.Controls.Add(this.bdrSeparator1);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(487, 46);
            this.pnlTitleBar.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.pnlTitleBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlTitleBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlTitleBar, "");
            // 
            // pbAppIcon
            // 
            this.pbAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbAppIcon.Image")));
            this.pbAppIcon.Location = new System.Drawing.Point(12, 12);
            this.pbAppIcon.Name = "pbAppIcon";
            this.pbAppIcon.Size = new System.Drawing.Size(20, 19);
            this.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppIcon.TabIndex = 19;
            this.pbAppIcon.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbAppIcon, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pbAppIcon, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbAppIcon, "");
            // 
            // pbMinimize
            // 
            this.pbMinimize.ActiveImage = null;
            this.pbMinimize.AllowAnimations = true;
            this.pbMinimize.AllowBuffering = false;
            this.pbMinimize.AllowZooming = false;
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.ErrorImage")));
            this.pbMinimize.FadeWhenInactive = true;
            this.pbMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.ImageActive = null;
            this.pbMinimize.ImageLocation = null;
            this.pbMinimize.ImageMargin = 24;
            this.pbMinimize.ImageSize = new System.Drawing.Size(16, 16);
            this.pbMinimize.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.pbMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.InitialImage")));
            this.pbMinimize.Location = new System.Drawing.Point(405, 3);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Rotation = 0;
            this.pbMinimize.ShowActiveImage = true;
            this.pbMinimize.ShowCursorChanges = true;
            this.pbMinimize.ShowImageBorders = true;
            this.pbMinimize.ShowSizeMarkers = false;
            this.pbMinimize.Size = new System.Drawing.Size(40, 40);
            this.pbMinimize.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.pbMinimize, "Minimize");
            this.bunifuToolTip1.SetToolTipIcon(this.pbMinimize, null);
            this.pbMinimize.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.pbMinimize, "");
            this.pbMinimize.Visible = false;
            this.pbMinimize.WaitOnLoad = false;
            this.pbMinimize.Zoom = 24;
            this.pbMinimize.ZoomSpeed = 10;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.ActiveImage = null;
            this.pbClose.AllowAnimations = true;
            this.pbClose.AllowBuffering = false;
            this.pbClose.AllowZooming = false;
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbClose.ErrorImage")));
            this.pbClose.FadeWhenInactive = true;
            this.pbClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.ImageActive = null;
            this.pbClose.ImageLocation = null;
            this.pbClose.ImageMargin = 23;
            this.pbClose.ImageSize = new System.Drawing.Size(17, 17);
            this.pbClose.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.pbClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbClose.InitialImage")));
            this.pbClose.Location = new System.Drawing.Point(441, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Rotation = 0;
            this.pbClose.ShowActiveImage = true;
            this.pbClose.ShowCursorChanges = true;
            this.pbClose.ShowImageBorders = true;
            this.pbClose.ShowSizeMarkers = false;
            this.pbClose.Size = new System.Drawing.Size(40, 40);
            this.pbClose.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.pbClose, "Close");
            this.bunifuToolTip1.SetToolTipIcon(this.pbClose, null);
            this.pbClose.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.pbClose, "");
            this.pbClose.WaitOnLoad = false;
            this.pbClose.Zoom = 23;
            this.pbClose.ZoomSpeed = 10;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // bdrSeparator1
            // 
            this.bdrSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.bdrSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdrSeparator1.Enabled = false;
            this.bdrSeparator1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdrSeparator1.Location = new System.Drawing.Point(0, 45);
            this.bdrSeparator1.Name = "bdrSeparator1";
            this.bdrSeparator1.Size = new System.Drawing.Size(487, 1);
            this.bdrSeparator1.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.bdrSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bdrSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bdrSeparator1, "");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(34, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Settings";
            this.bunifuToolTip1.SetToolTip(this.lblTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTitle, "");
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.White;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 1);
            this.label2.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // chkTopmost
            // 
            this.chkTopmost.AllowBindingControlAnimation = true;
            this.chkTopmost.AllowBindingControlColorChanges = false;
            this.chkTopmost.AllowBindingControlLocation = false;
            this.chkTopmost.AllowCheckBoxAnimation = false;
            this.chkTopmost.AllowCheckmarkAnimation = true;
            this.chkTopmost.AllowOnHoverStates = true;
            this.chkTopmost.AutoCheck = true;
            this.chkTopmost.BackColor = System.Drawing.Color.Transparent;
            this.chkTopmost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkTopmost.BackgroundImage")));
            this.chkTopmost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkTopmost.BindingControl = this.lblTopmost;
            this.chkTopmost.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkTopmost.Checked = false;
            this.chkTopmost.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkTopmost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTopmost.CustomCheckmarkImage = null;
            this.chkTopmost.Location = new System.Drawing.Point(28, 21);
            this.chkTopmost.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.OnCheck.BorderColor = System.Drawing.Color.BlueViolet;
            this.chkTopmost.OnCheck.BorderRadius = 2;
            this.chkTopmost.OnCheck.BorderThickness = 2;
            this.chkTopmost.OnCheck.CheckBoxColor = System.Drawing.Color.BlueViolet;
            this.chkTopmost.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkTopmost.OnCheck.CheckmarkThickness = 2;
            this.chkTopmost.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkTopmost.OnDisable.BorderRadius = 2;
            this.chkTopmost.OnDisable.BorderThickness = 2;
            this.chkTopmost.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkTopmost.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkTopmost.OnDisable.CheckmarkThickness = 2;
            this.chkTopmost.OnHoverChecked.BorderColor = System.Drawing.Color.MediumPurple;
            this.chkTopmost.OnHoverChecked.BorderRadius = 2;
            this.chkTopmost.OnHoverChecked.BorderThickness = 2;
            this.chkTopmost.OnHoverChecked.CheckBoxColor = System.Drawing.Color.MediumPurple;
            this.chkTopmost.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkTopmost.OnHoverChecked.CheckmarkThickness = 2;
            this.chkTopmost.OnHoverUnchecked.BorderColor = System.Drawing.Color.MediumPurple;
            this.chkTopmost.OnHoverUnchecked.BorderRadius = 2;
            this.chkTopmost.OnHoverUnchecked.BorderThickness = 1;
            this.chkTopmost.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkTopmost.OnUncheck.BorderColor = System.Drawing.Color.BlueViolet;
            this.chkTopmost.OnUncheck.BorderRadius = 2;
            this.chkTopmost.OnUncheck.BorderThickness = 1;
            this.chkTopmost.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkTopmost.Size = new System.Drawing.Size(21, 21);
            this.chkTopmost.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkTopmost.TabIndex = 16;
            this.chkTopmost.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.chkTopmost, "");
            this.bunifuToolTip1.SetToolTipIcon(this.chkTopmost, null);
            this.chkTopmost.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.chkTopmost, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTopmost);
            this.panel1.Controls.Add(this.chkTopmost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 65);
            this.panel1.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // lblTopmost
            // 
            this.lblTopmost.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblTopmost.AutoEllipsis = false;
            this.lblTopmost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTopmost.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblTopmost.Font = new System.Drawing.Font("Product Sans Light", 12F);
            this.lblTopmost.ForeColor = System.Drawing.Color.White;
            this.lblTopmost.Location = new System.Drawing.Point(58, 21);
            this.lblTopmost.Name = "lblTopmost";
            this.lblTopmost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTopmost.Size = new System.Drawing.Size(368, 22);
            this.lblTopmost.TabIndex = 16;
            this.lblTopmost.Text = "Set main window as top-most (above other windows)";
            this.lblTopmost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTopmost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTopmost, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTopmost, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTopmost, "");
            // 
            // pnlEnableHotkeySelection
            // 
            this.pnlEnableHotkeySelection.Controls.Add(this.pbShowPopupInfo);
            this.pnlEnableHotkeySelection.Controls.Add(this.lblShowPopup);
            this.pnlEnableHotkeySelection.Controls.Add(this.chkShowPopup);
            this.pnlEnableHotkeySelection.Controls.Add(this.bunifuLabel1);
            this.pnlEnableHotkeySelection.Controls.Add(this.txtHotkey);
            this.pnlEnableHotkeySelection.Controls.Add(this.pbEnableHotkeySelectionInfo);
            this.pnlEnableHotkeySelection.Controls.Add(this.lblEnableHotkeySelection);
            this.pnlEnableHotkeySelection.Controls.Add(this.chkEnableHotkeySelection);
            this.pnlEnableHotkeySelection.Controls.Add(this.label1);
            this.pnlEnableHotkeySelection.Controls.Add(this.bunifuLabel2);
            this.pnlEnableHotkeySelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEnableHotkeySelection.Location = new System.Drawing.Point(0, 111);
            this.pnlEnableHotkeySelection.Name = "pnlEnableHotkeySelection";
            this.pnlEnableHotkeySelection.Size = new System.Drawing.Size(487, 171);
            this.pnlEnableHotkeySelection.TabIndex = 17;
            this.bunifuToolTip1.SetToolTip(this.pnlEnableHotkeySelection, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlEnableHotkeySelection, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlEnableHotkeySelection, "");
            // 
            // pbShowPopupInfo
            // 
            this.pbShowPopupInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPopupInfo.Image")));
            this.pbShowPopupInfo.Location = new System.Drawing.Point(268, 136);
            this.pbShowPopupInfo.Name = "pbShowPopupInfo";
            this.pbShowPopupInfo.Size = new System.Drawing.Size(20, 17);
            this.pbShowPopupInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPopupInfo.TabIndex = 26;
            this.pbShowPopupInfo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbShowPopupInfo, "When checked, this will display a popup window\r\nwith the selected text converted " +
        "rather than the \r\nentire main window being displayed.");
            this.bunifuToolTip1.SetToolTipIcon(this.pbShowPopupInfo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbShowPopupInfo, "What does this feature do?");
            // 
            // lblShowPopup
            // 
            this.lblShowPopup.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblShowPopup.AutoEllipsis = false;
            this.lblShowPopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowPopup.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblShowPopup.Font = new System.Drawing.Font("Product Sans Light", 12F);
            this.lblShowPopup.ForeColor = System.Drawing.Color.White;
            this.lblShowPopup.Location = new System.Drawing.Point(175, 135);
            this.lblShowPopup.Name = "lblShowPopup";
            this.lblShowPopup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShowPopup.Size = new System.Drawing.Size(91, 22);
            this.lblShowPopup.TabIndex = 24;
            this.lblShowPopup.Text = "Show popup";
            this.lblShowPopup.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblShowPopup.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblShowPopup, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblShowPopup, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblShowPopup, "");
            // 
            // chkShowPopup
            // 
            this.chkShowPopup.AllowBindingControlAnimation = true;
            this.chkShowPopup.AllowBindingControlColorChanges = false;
            this.chkShowPopup.AllowBindingControlLocation = false;
            this.chkShowPopup.AllowCheckBoxAnimation = false;
            this.chkShowPopup.AllowCheckmarkAnimation = true;
            this.chkShowPopup.AllowOnHoverStates = true;
            this.chkShowPopup.AutoCheck = true;
            this.chkShowPopup.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPopup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkShowPopup.BackgroundImage")));
            this.chkShowPopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkShowPopup.BindingControl = this.lblShowPopup;
            this.chkShowPopup.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkShowPopup.Checked = true;
            this.chkShowPopup.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkShowPopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPopup.CustomCheckmarkImage = null;
            this.chkShowPopup.Location = new System.Drawing.Point(145, 135);
            this.chkShowPopup.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkShowPopup.Name = "chkShowPopup";
            this.chkShowPopup.OnCheck.BorderColor = System.Drawing.Color.BlueViolet;
            this.chkShowPopup.OnCheck.BorderRadius = 2;
            this.chkShowPopup.OnCheck.BorderThickness = 2;
            this.chkShowPopup.OnCheck.CheckBoxColor = System.Drawing.Color.BlueViolet;
            this.chkShowPopup.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkShowPopup.OnCheck.CheckmarkThickness = 2;
            this.chkShowPopup.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkShowPopup.OnDisable.BorderRadius = 2;
            this.chkShowPopup.OnDisable.BorderThickness = 2;
            this.chkShowPopup.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkShowPopup.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkShowPopup.OnDisable.CheckmarkThickness = 2;
            this.chkShowPopup.OnHoverChecked.BorderColor = System.Drawing.Color.MediumPurple;
            this.chkShowPopup.OnHoverChecked.BorderRadius = 2;
            this.chkShowPopup.OnHoverChecked.BorderThickness = 2;
            this.chkShowPopup.OnHoverChecked.CheckBoxColor = System.Drawing.Color.MediumPurple;
            this.chkShowPopup.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkShowPopup.OnHoverChecked.CheckmarkThickness = 2;
            this.chkShowPopup.OnHoverUnchecked.BorderColor = System.Drawing.Color.MediumPurple;
            this.chkShowPopup.OnHoverUnchecked.BorderRadius = 2;
            this.chkShowPopup.OnHoverUnchecked.BorderThickness = 1;
            this.chkShowPopup.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkShowPopup.OnUncheck.BorderColor = System.Drawing.Color.BlueViolet;
            this.chkShowPopup.OnUncheck.BorderRadius = 2;
            this.chkShowPopup.OnUncheck.BorderThickness = 1;
            this.chkShowPopup.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkShowPopup.Size = new System.Drawing.Size(21, 21);
            this.chkShowPopup.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkShowPopup.TabIndex = 25;
            this.chkShowPopup.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.chkShowPopup, "");
            this.bunifuToolTip1.SetToolTipIcon(this.chkShowPopup, null);
            this.chkShowPopup.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.chkShowPopup, "");
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel1.Font = new System.Drawing.Font("Product Sans Light", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(28, 74);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(110, 22);
            this.bunifuLabel1.TabIndex = 22;
            this.bunifuLabel1.Text = "Choose Hotkey";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // txtHotkey
            // 
            this.txtHotkey.AcceptsReturn = false;
            this.txtHotkey.AcceptsTab = false;
            this.txtHotkey.AnimationSpeed = 200;
            this.txtHotkey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHotkey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHotkey.BackColor = System.Drawing.Color.Transparent;
            this.txtHotkey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtHotkey.BackgroundImage")));
            this.txtHotkey.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtHotkey.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtHotkey.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtHotkey.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            this.txtHotkey.BorderRadius = 3;
            this.txtHotkey.BorderThickness = 1;
            this.txtHotkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHotkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHotkey.DefaultFont = new System.Drawing.Font("Product Sans Light", 12F);
            this.txtHotkey.DefaultText = "";
            this.txtHotkey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.txtHotkey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHotkey.HideSelection = true;
            this.txtHotkey.IconLeft = null;
            this.txtHotkey.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHotkey.IconPadding = 10;
            this.txtHotkey.IconRight = null;
            this.txtHotkey.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHotkey.Lines = new string[0];
            this.txtHotkey.Location = new System.Drawing.Point(145, 68);
            this.txtHotkey.MaxLength = 32767;
            this.txtHotkey.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtHotkey.Modified = false;
            this.txtHotkey.Multiline = false;
            this.txtHotkey.Name = "txtHotkey";
            stateProperties1.BorderColor = System.Drawing.Color.MediumPurple;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtHotkey.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtHotkey.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.MediumPurple;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtHotkey.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties4.ForeColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtHotkey.OnIdleState = stateProperties4;
            this.txtHotkey.PasswordChar = '\0';
            this.txtHotkey.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtHotkey.PlaceholderText = "press your keys here...";
            this.txtHotkey.ReadOnly = false;
            this.txtHotkey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHotkey.SelectedText = "";
            this.txtHotkey.SelectionLength = 0;
            this.txtHotkey.SelectionStart = 0;
            this.txtHotkey.ShortcutsEnabled = true;
            this.txtHotkey.Size = new System.Drawing.Size(300, 35);
            this.txtHotkey.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtHotkey.TabIndex = 21;
            this.txtHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHotkey.TextMarginBottom = 0;
            this.txtHotkey.TextMarginLeft = 5;
            this.txtHotkey.TextMarginTop = 0;
            this.txtHotkey.TextPlaceholder = "press your keys here...";
            this.bunifuToolTip1.SetToolTip(this.txtHotkey, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtHotkey, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtHotkey, "");
            this.txtHotkey.UseSystemPasswordChar = false;
            this.txtHotkey.WordWrap = true;
            // 
            // pbEnableHotkeySelectionInfo
            // 
            this.pbEnableHotkeySelectionInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbEnableHotkeySelectionInfo.Image")));
            this.pbEnableHotkeySelectionInfo.Location = new System.Drawing.Point(438, 22);
            this.pbEnableHotkeySelectionInfo.Name = "pbEnableHotkeySelectionInfo";
            this.pbEnableHotkeySelectionInfo.Size = new System.Drawing.Size(20, 17);
            this.pbEnableHotkeySelectionInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnableHotkeySelectionInfo.TabIndex = 20;
            this.pbEnableHotkeySelectionInfo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbEnableHotkeySelectionInfo, resources.GetString("pbEnableHotkeySelectionInfo.ToolTip"));
            this.bunifuToolTip1.SetToolTipIcon(this.pbEnableHotkeySelectionInfo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbEnableHotkeySelectionInfo, "What does this feature do?");
            // 
            // lblEnableHotkeySelection
            // 
            this.lblEnableHotkeySelection.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblEnableHotkeySelection.AutoEllipsis = false;
            this.lblEnableHotkeySelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnableHotkeySelection.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblEnableHotkeySelection.Font = new System.Drawing.Font("Product Sans Light", 12F);
            this.lblEnableHotkeySelection.ForeColor = System.Drawing.Color.White;
            this.lblEnableHotkeySelection.Location = new System.Drawing.Point(58, 21);
            this.lblEnableHotkeySelection.Name = "lblEnableHotkeySelection";
            this.lblEnableHotkeySelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnableHotkeySelection.Size = new System.Drawing.Size(378, 22);
            this.lblEnableHotkeySelection.TabIndex = 16;
            this.lblEnableHotkeySelection.Text = "Enable hotkey for encoding/decoding of selected texts";
            this.lblEnableHotkeySelection.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEnableHotkeySelection.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblEnableHotkeySelection, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblEnableHotkeySelection, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblEnableHotkeySelection, "");
            // 
            // chkEnableHotkeySelection
            // 
            this.chkEnableHotkeySelection.AllowBindingControlAnimation = true;
            this.chkEnableHotkeySelection.AllowBindingControlColorChanges = false;
            this.chkEnableHotkeySelection.AllowBindingControlLocation = false;
            this.chkEnableHotkeySelection.AllowCheckBoxAnimation = false;
            this.chkEnableHotkeySelection.AllowCheckmarkAnimation = true;
            this.chkEnableHotkeySelection.AllowOnHoverStates = true;
            this.chkEnableHotkeySelection.AutoCheck = true;
            this.chkEnableHotkeySelection.BackColor = System.Drawing.Color.Transparent;
            this.chkEnableHotkeySelection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkEnableHotkeySelection.BackgroundImage")));
            this.chkEnableHotkeySelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkEnableHotkeySelection.BindingControl = this.lblEnableHotkeySelection;
            this.chkEnableHotkeySelection.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkEnableHotkeySelection.Checked = true;
            this.chkEnableHotkeySelection.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkEnableHotkeySelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEnableHotkeySelection.CustomCheckmarkImage = null;
            this.chkEnableHotkeySelection.Location = new System.Drawing.Point(28, 21);
            this.chkEnableHotkeySelection.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkEnableHotkeySelection.Name = "chkEnableHotkeySelection";
            this.chkEnableHotkeySelection.OnCheck.BorderColor = System.Drawing.Color.BlueViolet;
            this.chkEnableHotkeySelection.OnCheck.BorderRadius = 2;
            this.chkEnableHotkeySelection.OnCheck.BorderThickness = 2;
            this.chkEnableHotkeySelection.OnCheck.CheckBoxColor = System.Drawing.Color.BlueViolet;
            this.chkEnableHotkeySelection.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkEnableHotkeySelection.OnCheck.CheckmarkThickness = 2;
            this.chkEnableHotkeySelection.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkEnableHotkeySelection.OnDisable.BorderRadius = 2;
            this.chkEnableHotkeySelection.OnDisable.BorderThickness = 2;
            this.chkEnableHotkeySelection.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkEnableHotkeySelection.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkEnableHotkeySelection.OnDisable.CheckmarkThickness = 2;
            this.chkEnableHotkeySelection.OnHoverChecked.BorderColor = System.Drawing.Color.MediumPurple;
            this.chkEnableHotkeySelection.OnHoverChecked.BorderRadius = 2;
            this.chkEnableHotkeySelection.OnHoverChecked.BorderThickness = 2;
            this.chkEnableHotkeySelection.OnHoverChecked.CheckBoxColor = System.Drawing.Color.MediumPurple;
            this.chkEnableHotkeySelection.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkEnableHotkeySelection.OnHoverChecked.CheckmarkThickness = 2;
            this.chkEnableHotkeySelection.OnHoverUnchecked.BorderColor = System.Drawing.Color.MediumPurple;
            this.chkEnableHotkeySelection.OnHoverUnchecked.BorderRadius = 2;
            this.chkEnableHotkeySelection.OnHoverUnchecked.BorderThickness = 1;
            this.chkEnableHotkeySelection.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkEnableHotkeySelection.OnUncheck.BorderColor = System.Drawing.Color.BlueViolet;
            this.chkEnableHotkeySelection.OnUncheck.BorderRadius = 2;
            this.chkEnableHotkeySelection.OnUncheck.BorderThickness = 1;
            this.chkEnableHotkeySelection.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkEnableHotkeySelection.Size = new System.Drawing.Size(21, 21);
            this.chkEnableHotkeySelection.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkEnableHotkeySelection.TabIndex = 16;
            this.chkEnableHotkeySelection.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.chkEnableHotkeySelection, "");
            this.bunifuToolTip1.SetToolTipIcon(this.chkEnableHotkeySelection, null);
            this.chkEnableHotkeySelection.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.chkEnableHotkeySelection, "");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 1);
            this.label1.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel2.Font = new System.Drawing.Font("Product Sans Light", 9F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(146, 105);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(275, 18);
            this.bunifuLabel2.TabIndex = 23;
            this.bunifuLabel2.Text = "Simply press and hold any keys then release to apply...";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel2, "");
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.pnlTitleBar;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(487, 283);
            this.Controls.Add(this.pnlEnableHotkeySelection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp64 Settings";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.Settings_Deactivate);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEnableHotkeySelection.ResumeLayout(false);
            this.pnlEnableHotkeySelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPopupInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnableHotkeySelectionInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox pbAppIcon;
        private Bunifu.UI.WinForms.BunifuImageButton pbMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton pbClose;
        private System.Windows.Forms.Label bdrSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel pnlEnableHotkeySelection;
        private System.Windows.Forms.PictureBox pbShowPopupInfo;
        private Bunifu.UI.WinForms.BunifuLabel lblShowPopup;
        private Bunifu.UI.WinForms.BunifuCheckBox chkShowPopup;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtHotkey;
        private System.Windows.Forms.PictureBox pbEnableHotkeySelectionInfo;
        private Bunifu.UI.WinForms.BunifuLabel lblEnableHotkeySelection;
        private Bunifu.UI.WinForms.BunifuCheckBox chkEnableHotkeySelection;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel lblTopmost;
        private Bunifu.UI.WinForms.BunifuCheckBox chkTopmost;
        private System.Windows.Forms.Label label2;
    }
}