namespace WK.Apps.Sharp64.Views
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnCheckForUpdates = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbAppIcon = new System.Windows.Forms.PictureBox();
            this.pbClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bdrSeparator1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pbBuyCoffee = new System.Windows.Forms.PictureBox();
            this.lblTitleAppreciation = new Bunifu.UI.WinForms.BunifuLabel();
            this.bdrSeparator4 = new System.Windows.Forms.Label();
            this.lblAppreciation = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProgressIndicator = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUpdatesManager = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitleThirdParties = new Bunifu.UI.WinForms.BunifuLabel();
            this.bdrSeparator3 = new System.Windows.Forms.Label();
            this.lblGithub = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTwitter = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHomepage = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitleContact = new Bunifu.UI.WinForms.BunifuLabel();
            this.bdrSeparator2 = new System.Windows.Forms.Label();
            this.lblAppAuthor = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppName = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbAppIconLarge = new System.Windows.Forms.PictureBox();
            this.lblAppDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUI = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuyCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIconLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnCheckForUpdates);
            this.pnlTitleBar.Controls.Add(this.pbAppIcon);
            this.pnlTitleBar.Controls.Add(this.pbClose);
            this.pnlTitleBar.Controls.Add(this.bdrSeparator1);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(445, 46);
            this.pnlTitleBar.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.pnlTitleBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlTitleBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlTitleBar, "");
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.AllowToggling = false;
            this.btnCheckForUpdates.AnimationSpeed = 200;
            this.btnCheckForUpdates.AutoGenerateColors = false;
            this.btnCheckForUpdates.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckForUpdates.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(93)))));
            this.btnCheckForUpdates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckForUpdates.BackgroundImage")));
            this.btnCheckForUpdates.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckForUpdates.ButtonText = "CHECK FOR UPDATES";
            this.btnCheckForUpdates.ButtonTextMarginLeft = 1;
            this.btnCheckForUpdates.ColorContrastOnClick = 45;
            this.btnCheckForUpdates.ColorContrastOnHover = 45;
            this.btnCheckForUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCheckForUpdates.CustomizableEdges = borderEdges1;
            this.btnCheckForUpdates.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckForUpdates.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.btnCheckForUpdates.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.btnCheckForUpdates.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            this.btnCheckForUpdates.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnCheckForUpdates.Font = new System.Drawing.Font("Product Sans Light", 8.249999F);
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.LightGray;
            this.btnCheckForUpdates.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckForUpdates.IconMarginLeft = 11;
            this.btnCheckForUpdates.IconPadding = 10;
            this.btnCheckForUpdates.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckForUpdates.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(93)))));
            this.btnCheckForUpdates.IdleBorderRadius = 2;
            this.btnCheckForUpdates.IdleBorderThickness = 1;
            this.btnCheckForUpdates.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(93)))));
            this.btnCheckForUpdates.IdleIconLeftImage = null;
            this.btnCheckForUpdates.IdleIconRightImage = null;
            this.btnCheckForUpdates.IndicateFocus = false;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(255, 10);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties1.BorderRadius = 2;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties1.ForeColor = System.Drawing.Color.Silver;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnCheckForUpdates.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties2.BorderRadius = 2;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnCheckForUpdates.OnPressedState = stateProperties2;
            this.btnCheckForUpdates.Size = new System.Drawing.Size(138, 26);
            this.btnCheckForUpdates.TabIndex = 22;
            this.btnCheckForUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckForUpdates.TextMarginLeft = 1;
            this.bunifuToolTip1.SetToolTip(this.btnCheckForUpdates, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnCheckForUpdates, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnCheckForUpdates, "");
            this.btnCheckForUpdates.UseDefaultRadiusAndThickness = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
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
            this.pbClose.Location = new System.Drawing.Point(399, 3);
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
            this.bdrSeparator1.Size = new System.Drawing.Size(445, 1);
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
            this.lblTitle.Size = new System.Drawing.Size(48, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "About";
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
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Controls.Add(this.pbBuyCoffee);
            this.pnlContent.Controls.Add(this.lblTitleAppreciation);
            this.pnlContent.Controls.Add(this.bdrSeparator4);
            this.pnlContent.Controls.Add(this.lblAppreciation);
            this.pnlContent.Controls.Add(this.lblProgressIndicator);
            this.pnlContent.Controls.Add(this.lblUpdatesManager);
            this.pnlContent.Controls.Add(this.lblTitleThirdParties);
            this.pnlContent.Controls.Add(this.bdrSeparator3);
            this.pnlContent.Controls.Add(this.lblGithub);
            this.pnlContent.Controls.Add(this.lblTwitter);
            this.pnlContent.Controls.Add(this.lblHomepage);
            this.pnlContent.Controls.Add(this.lblTitleContact);
            this.pnlContent.Controls.Add(this.bdrSeparator2);
            this.pnlContent.Controls.Add(this.lblAppAuthor);
            this.pnlContent.Controls.Add(this.lblAppName);
            this.pnlContent.Controls.Add(this.pbAppIconLarge);
            this.pnlContent.Controls.Add(this.lblAppDescription);
            this.pnlContent.Controls.Add(this.lblUI);
            this.pnlContent.Location = new System.Drawing.Point(4, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(437, 452);
            this.pnlContent.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.pnlContent, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlContent, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlContent, "");
            // 
            // pbBuyCoffee
            // 
            this.pbBuyCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuyCoffee.Image = ((System.Drawing.Image)(resources.GetObject("pbBuyCoffee.Image")));
            this.pbBuyCoffee.Location = new System.Drawing.Point(33, 406);
            this.pbBuyCoffee.Name = "pbBuyCoffee";
            this.pbBuyCoffee.Size = new System.Drawing.Size(127, 30);
            this.pbBuyCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuyCoffee.TabIndex = 38;
            this.pbBuyCoffee.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbBuyCoffee, "Give a thank-you donation...");
            this.bunifuToolTip1.SetToolTipIcon(this.pbBuyCoffee, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbBuyCoffee, "");
            this.pbBuyCoffee.Click += new System.EventHandler(this.pbBuyCoffee_Click);
            // 
            // lblTitleAppreciation
            // 
            this.lblTitleAppreciation.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblTitleAppreciation.AutoEllipsis = false;
            this.lblTitleAppreciation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitleAppreciation.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblTitleAppreciation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAppreciation.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleAppreciation.Location = new System.Drawing.Point(34, 336);
            this.lblTitleAppreciation.Name = "lblTitleAppreciation";
            this.lblTitleAppreciation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleAppreciation.Size = new System.Drawing.Size(71, 17);
            this.lblTitleAppreciation.TabIndex = 36;
            this.lblTitleAppreciation.Text = "Appreciation";
            this.lblTitleAppreciation.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitleAppreciation.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTitleAppreciation, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTitleAppreciation, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTitleAppreciation, "");
            // 
            // bdrSeparator4
            // 
            this.bdrSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdrSeparator4.BackColor = System.Drawing.Color.DimGray;
            this.bdrSeparator4.Enabled = false;
            this.bdrSeparator4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdrSeparator4.Location = new System.Drawing.Point(112, 345);
            this.bdrSeparator4.Name = "bdrSeparator4";
            this.bdrSeparator4.Size = new System.Drawing.Size(293, 1);
            this.bdrSeparator4.TabIndex = 35;
            this.bunifuToolTip1.SetToolTip(this.bdrSeparator4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bdrSeparator4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bdrSeparator4, "");
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblAppreciation.AutoEllipsis = false;
            this.lblAppreciation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppreciation.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblAppreciation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppreciation.ForeColor = System.Drawing.Color.White;
            this.lblAppreciation.Location = new System.Drawing.Point(35, 362);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppreciation.Size = new System.Drawing.Size(356, 32);
            this.lblAppreciation.TabIndex = 37;
            this.lblAppreciation.Text = "A big thank you to all the people who\'ve appreciated this nifty little\r\nutility a" +
    "nd to all of my projects\' supporters. Thank you.";
            this.lblAppreciation.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppreciation.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblAppreciation, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblAppreciation, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblAppreciation, "");
            // 
            // lblProgressIndicator
            // 
            this.lblProgressIndicator.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblProgressIndicator.AutoEllipsis = false;
            this.lblProgressIndicator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProgressIndicator.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblProgressIndicator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressIndicator.ForeColor = System.Drawing.Color.White;
            this.lblProgressIndicator.Location = new System.Drawing.Point(36, 285);
            this.lblProgressIndicator.Name = "lblProgressIndicator";
            this.lblProgressIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProgressIndicator.Size = new System.Drawing.Size(254, 17);
            this.lblProgressIndicator.TabIndex = 34;
            this.lblProgressIndicator.Text = "+ Progress Indicator: <a href=\"https://github.com/ravibpatel/AutoUpdater.NET\" sty" +
    "le=\"text-decoration: none; color: deepskyblue;\">Circular Progress Indicator</a>";
            this.lblProgressIndicator.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProgressIndicator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblProgressIndicator, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblProgressIndicator, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblProgressIndicator, "");
            // 
            // lblUpdatesManager
            // 
            this.lblUpdatesManager.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblUpdatesManager.AutoEllipsis = false;
            this.lblUpdatesManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpdatesManager.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblUpdatesManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatesManager.ForeColor = System.Drawing.Color.White;
            this.lblUpdatesManager.Location = new System.Drawing.Point(36, 308);
            this.lblUpdatesManager.Name = "lblUpdatesManager";
            this.lblUpdatesManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpdatesManager.Size = new System.Drawing.Size(202, 17);
            this.lblUpdatesManager.TabIndex = 33;
            this.lblUpdatesManager.Text = "+ Updates Manager: <a href=\"https://github.com/ravibpatel/AutoUpdater.NET\" style=" +
    "\"text-decoration: none; color: deepskyblue;\">Autoupdater.Net</a>";
            this.lblUpdatesManager.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUpdatesManager.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblUpdatesManager, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblUpdatesManager, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblUpdatesManager, "");
            // 
            // lblTitleThirdParties
            // 
            this.lblTitleThirdParties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblTitleThirdParties.AutoEllipsis = false;
            this.lblTitleThirdParties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitleThirdParties.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblTitleThirdParties.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleThirdParties.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleThirdParties.Location = new System.Drawing.Point(35, 236);
            this.lblTitleThirdParties.Name = "lblTitleThirdParties";
            this.lblTitleThirdParties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleThirdParties.Size = new System.Drawing.Size(106, 17);
            this.lblTitleThirdParties.TabIndex = 30;
            this.lblTitleThirdParties.Text = "Third-party libraries";
            this.lblTitleThirdParties.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitleThirdParties.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTitleThirdParties, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTitleThirdParties, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTitleThirdParties, "");
            // 
            // bdrSeparator3
            // 
            this.bdrSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdrSeparator3.BackColor = System.Drawing.Color.DimGray;
            this.bdrSeparator3.Enabled = false;
            this.bdrSeparator3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdrSeparator3.Location = new System.Drawing.Point(147, 245);
            this.bdrSeparator3.Name = "bdrSeparator3";
            this.bdrSeparator3.Size = new System.Drawing.Size(257, 1);
            this.bdrSeparator3.TabIndex = 29;
            this.bunifuToolTip1.SetToolTip(this.bdrSeparator3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bdrSeparator3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bdrSeparator3, "");
            // 
            // lblGithub
            // 
            this.lblGithub.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblGithub.AutoEllipsis = false;
            this.lblGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGithub.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblGithub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithub.ForeColor = System.Drawing.Color.White;
            this.lblGithub.Location = new System.Drawing.Point(280, 206);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGithub.Size = new System.Drawing.Size(125, 17);
            this.lblGithub.TabIndex = 28;
            this.lblGithub.Text = "Github: <a href=\"https://github.com/willy-kimura\" style=\"text-decoration: none; c" +
    "olor: deepskyblue;\">@Willy-Kimura</a>";
            this.lblGithub.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblGithub.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblGithub, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblGithub, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblGithub, "");
            // 
            // lblTwitter
            // 
            this.lblTwitter.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblTwitter.AutoEllipsis = false;
            this.lblTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTwitter.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblTwitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitter.ForeColor = System.Drawing.Color.White;
            this.lblTwitter.Location = new System.Drawing.Point(142, 206);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTwitter.Size = new System.Drawing.Size(120, 17);
            this.lblTwitter.TabIndex = 27;
            this.lblTwitter.Text = "Twitter: <a href=\"https://twitter.com/willykimura/\" style=\"text-decoration: none;" +
    " color: deepskyblue;\">@WillyKimura</a>";
            this.lblTwitter.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTwitter.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTwitter, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTwitter, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTwitter, "");
            // 
            // lblHomepage
            // 
            this.lblHomepage.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblHomepage.AutoEllipsis = false;
            this.lblHomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHomepage.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblHomepage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomepage.ForeColor = System.Drawing.Color.White;
            this.lblHomepage.Location = new System.Drawing.Point(35, 206);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHomepage.Size = new System.Drawing.Size(87, 17);
            this.lblHomepage.TabIndex = 26;
            this.lblHomepage.Text = "<a href=\"https://willykimura.home.blog/\" style=\"text-decoration: none; color: dod" +
    "gerblue;\">Visit Homepage</a>";
            this.lblHomepage.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHomepage.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblHomepage, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblHomepage, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblHomepage, "");
            // 
            // lblTitleContact
            // 
            this.lblTitleContact.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblTitleContact.AutoEllipsis = false;
            this.lblTitleContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitleContact.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblTitleContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleContact.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleContact.Location = new System.Drawing.Point(34, 180);
            this.lblTitleContact.Name = "lblTitleContact";
            this.lblTitleContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleContact.Size = new System.Drawing.Size(45, 17);
            this.lblTitleContact.TabIndex = 25;
            this.lblTitleContact.Text = "Contact";
            this.lblTitleContact.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitleContact.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTitleContact, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTitleContact, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTitleContact, "");
            // 
            // bdrSeparator2
            // 
            this.bdrSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdrSeparator2.BackColor = System.Drawing.Color.DimGray;
            this.bdrSeparator2.Enabled = false;
            this.bdrSeparator2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdrSeparator2.Location = new System.Drawing.Point(85, 189);
            this.bdrSeparator2.Name = "bdrSeparator2";
            this.bdrSeparator2.Size = new System.Drawing.Size(319, 1);
            this.bdrSeparator2.TabIndex = 24;
            this.bunifuToolTip1.SetToolTip(this.bdrSeparator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bdrSeparator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bdrSeparator2, "");
            // 
            // lblAppAuthor
            // 
            this.lblAppAuthor.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblAppAuthor.AutoEllipsis = false;
            this.lblAppAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppAuthor.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblAppAuthor.Font = new System.Drawing.Font("Product Sans Light", 11.25F);
            this.lblAppAuthor.ForeColor = System.Drawing.Color.Silver;
            this.lblAppAuthor.Location = new System.Drawing.Point(167, 136);
            this.lblAppAuthor.Name = "lblAppAuthor";
            this.lblAppAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppAuthor.Size = new System.Drawing.Size(103, 21);
            this.lblAppAuthor.TabIndex = 23;
            this.lblAppAuthor.Text = "By Willy Kimura";
            this.lblAppAuthor.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppAuthor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblAppAuthor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblAppAuthor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblAppAuthor, "");
            // 
            // lblAppName
            // 
            this.lblAppName.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblAppName.AutoEllipsis = false;
            this.lblAppName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppName.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblAppName.Font = new System.Drawing.Font("Product Sans Light", 20.25F);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(168, 79);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppName.Size = new System.Drawing.Size(101, 36);
            this.lblAppName.TabIndex = 21;
            this.lblAppName.Text = "Sharp64";
            this.lblAppName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblAppName, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblAppName, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblAppName, "");
            // 
            // pbAppIconLarge
            // 
            this.pbAppIconLarge.Image = ((System.Drawing.Image)(resources.GetObject("pbAppIconLarge.Image")));
            this.pbAppIconLarge.Location = new System.Drawing.Point(188, 15);
            this.pbAppIconLarge.Name = "pbAppIconLarge";
            this.pbAppIconLarge.Size = new System.Drawing.Size(60, 65);
            this.pbAppIconLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppIconLarge.TabIndex = 20;
            this.pbAppIconLarge.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbAppIconLarge, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pbAppIconLarge, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbAppIconLarge, "");
            // 
            // lblAppDescription
            // 
            this.lblAppDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblAppDescription.AutoEllipsis = false;
            this.lblAppDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppDescription.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblAppDescription.Font = new System.Drawing.Font("Product Sans Light", 11.25F);
            this.lblAppDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblAppDescription.Location = new System.Drawing.Point(101, 113);
            this.lblAppDescription.Name = "lblAppDescription";
            this.lblAppDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppDescription.Size = new System.Drawing.Size(234, 21);
            this.lblAppDescription.TabIndex = 22;
            this.lblAppDescription.Text = "A Base64 encoder & decoder utility";
            this.lblAppDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblAppDescription, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblAppDescription, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblAppDescription, "");
            // 
            // lblUI
            // 
            this.lblUI.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblUI.AutoEllipsis = false;
            this.lblUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUI.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblUI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUI.ForeColor = System.Drawing.Color.White;
            this.lblUI.Location = new System.Drawing.Point(36, 262);
            this.lblUI.Name = "lblUI";
            this.lblUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUI.Size = new System.Drawing.Size(261, 17);
            this.lblUI.TabIndex = 32;
            this.lblUI.Text = "+ UI Controls & Components: <a href=\"https://bunifuframework.com/ref/Willy\" style" +
    "=\"text-decoration: none; color: deepskyblue;\">Bunifu Framework</a>";
            this.lblUI.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUI.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblUI, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblUI, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblUI, "");
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
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(445, 506);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitleBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp64 Conversions";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.About_Deactivate);
            this.Load += new System.EventHandler(this.About_Load);
            this.Shown += new System.EventHandler(this.About_Shown);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuyCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIconLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox pbAppIcon;
        private Bunifu.UI.WinForms.BunifuImageButton pbClose;
        private System.Windows.Forms.Label bdrSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pbAppIconLarge;
        private Bunifu.UI.WinForms.BunifuLabel lblAppDescription;
        private Bunifu.UI.WinForms.BunifuLabel lblAppAuthor;
        private Bunifu.UI.WinForms.BunifuLabel lblAppName;
        private System.Windows.Forms.Label bdrSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel lblTitleContact;
        private Bunifu.UI.WinForms.BunifuLabel lblHomepage;
        private Bunifu.UI.WinForms.BunifuLabel lblTwitter;
        private Bunifu.UI.WinForms.BunifuLabel lblGithub;
        private Bunifu.UI.WinForms.BunifuLabel lblUpdatesManager;
        private Bunifu.UI.WinForms.BunifuLabel lblUI;
        private Bunifu.UI.WinForms.BunifuLabel lblTitleThirdParties;
        private System.Windows.Forms.Label bdrSeparator3;
        private Bunifu.UI.WinForms.BunifuLabel lblProgressIndicator;
        private Bunifu.UI.WinForms.BunifuLabel lblTitleAppreciation;
        private System.Windows.Forms.Label bdrSeparator4;
        private Bunifu.UI.WinForms.BunifuLabel lblAppreciation;
        private System.Windows.Forms.PictureBox pbBuyCoffee;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCheckForUpdates;
    }
}