namespace WK.Apps.Sharp64.Views
{
    partial class HotkeyPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyPopup));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnSwapSides = new Bunifu.UI.WinForms.BunifuUserControl();
            this.pbAppIcon = new System.Windows.Forms.PictureBox();
            this.pbClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bdrSeparator1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConversion = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnSwapSides);
            this.pnlTitleBar.Controls.Add(this.pbAppIcon);
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
            // btnSwapSides
            // 
            this.btnSwapSides.AllowAnimations = true;
            this.btnSwapSides.AllowBorderColorChanges = true;
            this.btnSwapSides.AllowMouseEffects = true;
            this.btnSwapSides.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSwapSides.AnimationSpeed = 200;
            this.btnSwapSides.BackColor = System.Drawing.Color.Transparent;
            this.btnSwapSides.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnSwapSides.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnSwapSides.BorderRadius = 2;
            this.btnSwapSides.BorderThickness = 1;
            this.btnSwapSides.ColorContrastOnClick = 60;
            this.btnSwapSides.ColorContrastOnHover = 10;
            this.btnSwapSides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwapSides.Image = ((System.Drawing.Image)(resources.GetObject("btnSwapSides.Image")));
            this.btnSwapSides.ImageMargin = new System.Windows.Forms.Padding(3, 2, 6, -4);
            this.btnSwapSides.Location = new System.Drawing.Point(225, 6);
            this.btnSwapSides.Name = "btnSwapSides";
            this.btnSwapSides.ShowBorders = true;
            this.btnSwapSides.Size = new System.Drawing.Size(36, 35);
            this.btnSwapSides.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Round;
            this.btnSwapSides.TabIndex = 22;
            this.bunifuToolTip1.SetToolTip(this.btnSwapSides, "Swap from encoding to decoding or vice-versa");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSwapSides, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSwapSides, "");
            this.btnSwapSides.Click += new System.EventHandler(this.btnSwapSides_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(64, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Sharp64";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtConversion);
            this.panel1.Location = new System.Drawing.Point(4, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 371);
            this.panel1.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // txtConversion
            // 
            this.txtConversion.AcceptsReturn = false;
            this.txtConversion.AcceptsTab = false;
            this.txtConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConversion.AnimationSpeed = 200;
            this.txtConversion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConversion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConversion.BackColor = System.Drawing.Color.Transparent;
            this.txtConversion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtConversion.BackgroundImage")));
            this.txtConversion.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtConversion.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtConversion.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtConversion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtConversion.BorderRadius = 1;
            this.txtConversion.BorderThickness = 1;
            this.txtConversion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConversion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConversion.DefaultFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversion.DefaultText = "";
            this.txtConversion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtConversion.ForeColor = System.Drawing.Color.White;
            this.txtConversion.HideSelection = true;
            this.txtConversion.IconLeft = null;
            this.txtConversion.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConversion.IconPadding = 10;
            this.txtConversion.IconRight = null;
            this.txtConversion.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConversion.Lines = new string[0];
            this.txtConversion.Location = new System.Drawing.Point(0, 0);
            this.txtConversion.MaxLength = 32767;
            this.txtConversion.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtConversion.Modified = false;
            this.txtConversion.Multiline = true;
            this.txtConversion.Name = "txtConversion";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConversion.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtConversion.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConversion.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtConversion.OnIdleState = stateProperties12;
            this.txtConversion.PasswordChar = '\0';
            this.txtConversion.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtConversion.PlaceholderText = "Base64 conversions show here...";
            this.txtConversion.ReadOnly = false;
            this.txtConversion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConversion.SelectedText = "";
            this.txtConversion.SelectionLength = 0;
            this.txtConversion.SelectionStart = 0;
            this.txtConversion.ShortcutsEnabled = true;
            this.txtConversion.Size = new System.Drawing.Size(479, 371);
            this.txtConversion.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtConversion.TabIndex = 2;
            this.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConversion.TextMarginBottom = 0;
            this.txtConversion.TextMarginLeft = 10;
            this.txtConversion.TextMarginTop = 10;
            this.txtConversion.TextPlaceholder = "Base64 conversions show here...";
            this.bunifuToolTip1.SetToolTip(this.txtConversion, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtConversion, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtConversion, "");
            this.txtConversion.UseSystemPasswordChar = false;
            this.txtConversion.WordWrap = true;
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
            // HotkeyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(487, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotkeyPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp64 Conversions";
            this.Deactivate += new System.EventHandler(this.Popup_Deactivate);
            this.Load += new System.EventHandler(this.Popup_Load);
            this.Shown += new System.EventHandler(this.Popup_Shown);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuUserControl btnSwapSides;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtConversion;
    }
}