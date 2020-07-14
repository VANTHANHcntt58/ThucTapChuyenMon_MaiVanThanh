namespace HotelManager
{
    partial class fManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManagement));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.metroTile17 = new MetroFramework.Controls.MetroTile();
            this.metroTile16 = new MetroFramework.Controls.MetroTile();
            this.titleManageRoom = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.titleRecieveRoom = new MetroFramework.Controls.MetroTile();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.titleBookRoom = new MetroFramework.Controls.MetroTile();
            this.panelLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnBookingRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecieveRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNavigationPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccountProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelRight;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.Controls.Add(this.metroTile17);
            this.panelRight.Controls.Add(this.metroTile16);
            this.panelRight.Controls.Add(this.titleManageRoom);
            this.panelRight.Controls.Add(this.metroTile8);
            this.panelRight.Controls.Add(this.titleRecieveRoom);
            this.panelRight.Controls.Add(this.btnClose);
            this.panelRight.Controls.Add(this.titleBookRoom);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(177, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(939, 583);
            this.panelRight.TabIndex = 1;
            // 
            // metroTile17
            // 
            this.metroTile17.ActiveControl = null;
            this.metroTile17.BackColor = System.Drawing.Color.DarkBlue;
            this.metroTile17.ForeColor = System.Drawing.Color.White;
            this.metroTile17.Location = new System.Drawing.Point(194, 12);
            this.metroTile17.Name = "metroTile17";
            this.metroTile17.Size = new System.Drawing.Size(203, 130);
            this.metroTile17.TabIndex = 47;
            this.metroTile17.Text = "Quản Lí Khách Hàng";
            this.metroTile17.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile17.TileImage")));
            this.metroTile17.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile17.UseCustomBackColor = true;
            this.metroTile17.UseCustomForeColor = true;
            this.metroTile17.UseSelectable = true;
            this.metroTile17.UseStyleColors = true;
            this.metroTile17.UseTileImage = true;
            this.metroTile17.Click += new System.EventHandler(this.metroTile17_Click);
            // 
            // metroTile16
            // 
            this.metroTile16.ActiveControl = null;
            this.metroTile16.BackColor = System.Drawing.Color.DarkBlue;
            this.metroTile16.ForeColor = System.Drawing.Color.White;
            this.metroTile16.Location = new System.Drawing.Point(197, 402);
            this.metroTile16.Name = "metroTile16";
            this.metroTile16.Size = new System.Drawing.Size(200, 135);
            this.metroTile16.TabIndex = 44;
            this.metroTile16.Text = "Quản Lí Hóa Đơn";
            this.metroTile16.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile16.TileImage")));
            this.metroTile16.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile16.UseCustomBackColor = true;
            this.metroTile16.UseCustomForeColor = true;
            this.metroTile16.UseSelectable = true;
            this.metroTile16.UseStyleColors = true;
            this.metroTile16.UseTileImage = true;
            this.metroTile16.Click += new System.EventHandler(this.metroTile16_Click);
            // 
            // titleManageRoom
            // 
            this.titleManageRoom.ActiveControl = null;
            this.titleManageRoom.BackColor = System.Drawing.Color.DarkBlue;
            this.titleManageRoom.ForeColor = System.Drawing.Color.White;
            this.titleManageRoom.Location = new System.Drawing.Point(29, 261);
            this.titleManageRoom.Name = "titleManageRoom";
            this.titleManageRoom.Size = new System.Drawing.Size(135, 135);
            this.titleManageRoom.TabIndex = 34;
            this.titleManageRoom.Text = "Quản Lí Phòng";
            this.titleManageRoom.TileImage = ((System.Drawing.Image)(resources.GetObject("titleManageRoom.TileImage")));
            this.titleManageRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleManageRoom.UseCustomBackColor = true;
            this.titleManageRoom.UseCustomForeColor = true;
            this.titleManageRoom.UseSelectable = true;
            this.titleManageRoom.UseStyleColors = true;
            this.titleManageRoom.UseTileImage = true;
            this.titleManageRoom.Click += new System.EventHandler(this.titleManageRoom_Click);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.BackColor = System.Drawing.Color.DarkBlue;
            this.metroTile8.ForeColor = System.Drawing.Color.White;
            this.metroTile8.Location = new System.Drawing.Point(29, 402);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(135, 135);
            this.metroTile8.TabIndex = 29;
            this.metroTile8.Text = "Quản Lí Nhân Viên";
            this.metroTile8.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile8.TileImage")));
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseCustomBackColor = true;
            this.metroTile8.UseCustomForeColor = true;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseStyleColors = true;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // titleRecieveRoom
            // 
            this.titleRecieveRoom.ActiveControl = null;
            this.titleRecieveRoom.BackColor = System.Drawing.Color.DarkBlue;
            this.titleRecieveRoom.ForeColor = System.Drawing.Color.White;
            this.titleRecieveRoom.Location = new System.Drawing.Point(29, 145);
            this.titleRecieveRoom.Name = "titleRecieveRoom";
            this.titleRecieveRoom.Size = new System.Drawing.Size(135, 110);
            this.titleRecieveRoom.TabIndex = 25;
            this.titleRecieveRoom.Text = "Nhận Phòng";
            this.titleRecieveRoom.TileImage = ((System.Drawing.Image)(resources.GetObject("titleRecieveRoom.TileImage")));
            this.titleRecieveRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleRecieveRoom.UseCustomBackColor = true;
            this.titleRecieveRoom.UseCustomForeColor = true;
            this.titleRecieveRoom.UseSelectable = true;
            this.titleRecieveRoom.UseStyleColors = true;
            this.titleRecieveRoom.UseTileImage = true;
            this.titleRecieveRoom.Click += new System.EventHandler(this.titleRecieveRoom_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(916, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // titleBookRoom
            // 
            this.titleBookRoom.ActiveControl = null;
            this.titleBookRoom.BackColor = System.Drawing.Color.DarkBlue;
            this.titleBookRoom.ForeColor = System.Drawing.Color.White;
            this.titleBookRoom.Location = new System.Drawing.Point(29, 12);
            this.titleBookRoom.Name = "titleBookRoom";
            this.titleBookRoom.Size = new System.Drawing.Size(135, 127);
            this.titleBookRoom.TabIndex = 17;
            this.titleBookRoom.Text = "Đặt Phòng";
            this.titleBookRoom.TileImage = ((System.Drawing.Image)(resources.GetObject("titleBookRoom.TileImage")));
            this.titleBookRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleBookRoom.UseCustomBackColor = true;
            this.titleBookRoom.UseCustomForeColor = true;
            this.titleBookRoom.UseSelectable = true;
            this.titleBookRoom.UseStyleColors = true;
            this.titleBookRoom.UseTileImage = true;
            this.titleBookRoom.Click += new System.EventHandler(this.titleSignUpRoom_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.btnBookingRoom);
            this.panelLeft.Controls.Add(this.btnRecieveRoom);
            this.panelLeft.Controls.Add(this.btnPay);
            this.panelLeft.Controls.Add(this.btnNavigationPanel);
            this.panelLeft.Controls.Add(this.btnAccountProfile);
            this.panelLeft.Controls.Add(this.btnLogOut);
            this.panelLeft.Controls.Add(this.bunifuFlatButton1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.GradientBottomLeft = System.Drawing.Color.DarkBlue;
            this.panelLeft.GradientBottomRight = System.Drawing.Color.DarkBlue;
            this.panelLeft.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.panelLeft.GradientTopRight = System.Drawing.Color.DarkBlue;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Quality = 10;
            this.panelLeft.Size = new System.Drawing.Size(177, 583);
            this.panelLeft.TabIndex = 0;
            // 
            // btnBookingRoom
            // 
            this.btnBookingRoom.Activecolor = System.Drawing.Color.Blue;
            this.btnBookingRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBookingRoom.BackColor = System.Drawing.Color.Blue;
            this.btnBookingRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookingRoom.BorderRadius = 0;
            this.btnBookingRoom.ButtonText = "    Đặt phòng";
            this.btnBookingRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookingRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnBookingRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBookingRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBookingRoom.Iconimage")));
            this.btnBookingRoom.Iconimage_right = null;
            this.btnBookingRoom.Iconimage_right_Selected = null;
            this.btnBookingRoom.Iconimage_Selected = null;
            this.btnBookingRoom.IconMarginLeft = 0;
            this.btnBookingRoom.IconMarginRight = 0;
            this.btnBookingRoom.IconRightVisible = true;
            this.btnBookingRoom.IconRightZoom = 0D;
            this.btnBookingRoom.IconVisible = true;
            this.btnBookingRoom.IconZoom = 50D;
            this.btnBookingRoom.IsTab = false;
            this.btnBookingRoom.Location = new System.Drawing.Point(0, 42);
            this.btnBookingRoom.Name = "btnBookingRoom";
            this.btnBookingRoom.Normalcolor = System.Drawing.Color.Blue;
            this.btnBookingRoom.OnHovercolor = System.Drawing.Color.Blue;
            this.btnBookingRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBookingRoom.selected = false;
            this.btnBookingRoom.Size = new System.Drawing.Size(177, 40);
            this.btnBookingRoom.TabIndex = 9;
            this.btnBookingRoom.Text = "    Đặt phòng";
            this.btnBookingRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingRoom.Textcolor = System.Drawing.Color.White;
            this.btnBookingRoom.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingRoom.Click += new System.EventHandler(this.btnBookingRoom_Click);
            // 
            // btnRecieveRoom
            // 
            this.btnRecieveRoom.Activecolor = System.Drawing.Color.Blue;
            this.btnRecieveRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecieveRoom.BackColor = System.Drawing.Color.Blue;
            this.btnRecieveRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecieveRoom.BorderRadius = 0;
            this.btnRecieveRoom.ButtonText = "    Nhận phòng";
            this.btnRecieveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecieveRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecieveRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecieveRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRecieveRoom.Iconimage")));
            this.btnRecieveRoom.Iconimage_right = null;
            this.btnRecieveRoom.Iconimage_right_Selected = null;
            this.btnRecieveRoom.Iconimage_Selected = null;
            this.btnRecieveRoom.IconMarginLeft = 0;
            this.btnRecieveRoom.IconMarginRight = 0;
            this.btnRecieveRoom.IconRightVisible = true;
            this.btnRecieveRoom.IconRightZoom = 0D;
            this.btnRecieveRoom.IconVisible = true;
            this.btnRecieveRoom.IconZoom = 50D;
            this.btnRecieveRoom.IsTab = false;
            this.btnRecieveRoom.Location = new System.Drawing.Point(0, 88);
            this.btnRecieveRoom.Name = "btnRecieveRoom";
            this.btnRecieveRoom.Normalcolor = System.Drawing.Color.Blue;
            this.btnRecieveRoom.OnHovercolor = System.Drawing.Color.Blue;
            this.btnRecieveRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRecieveRoom.selected = false;
            this.btnRecieveRoom.Size = new System.Drawing.Size(177, 40);
            this.btnRecieveRoom.TabIndex = 8;
            this.btnRecieveRoom.Text = "    Nhận phòng";
            this.btnRecieveRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecieveRoom.Textcolor = System.Drawing.Color.White;
            this.btnRecieveRoom.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPay
            // 
            this.btnPay.Activecolor = System.Drawing.Color.Blue;
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.BackColor = System.Drawing.Color.Blue;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.BorderRadius = 0;
            this.btnPay.ButtonText = "    Dịch vụ & thanh toán";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledColor = System.Drawing.Color.Gray;
            this.btnPay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPay.Iconimage")));
            this.btnPay.Iconimage_right = null;
            this.btnPay.Iconimage_right_Selected = null;
            this.btnPay.Iconimage_Selected = null;
            this.btnPay.IconMarginLeft = 0;
            this.btnPay.IconMarginRight = 0;
            this.btnPay.IconRightVisible = true;
            this.btnPay.IconRightZoom = 0D;
            this.btnPay.IconVisible = true;
            this.btnPay.IconZoom = 50D;
            this.btnPay.IsTab = false;
            this.btnPay.Location = new System.Drawing.Point(-3, 134);
            this.btnPay.Name = "btnPay";
            this.btnPay.Normalcolor = System.Drawing.Color.Blue;
            this.btnPay.OnHovercolor = System.Drawing.Color.Blue;
            this.btnPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPay.selected = false;
            this.btnPay.Size = new System.Drawing.Size(177, 40);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "    Dịch vụ & thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Textcolor = System.Drawing.Color.White;
            this.btnPay.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNavigationPanel
            // 
            this.btnNavigationPanel.Activecolor = System.Drawing.Color.DarkBlue;
            this.btnNavigationPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNavigationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNavigationPanel.BorderRadius = 0;
            this.btnNavigationPanel.ButtonText = "";
            this.btnNavigationPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavigationPanel.DisabledColor = System.Drawing.Color.Gray;
            this.btnNavigationPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNavigationPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNavigationPanel.Iconimage")));
            this.btnNavigationPanel.Iconimage_right = null;
            this.btnNavigationPanel.Iconimage_right_Selected = null;
            this.btnNavigationPanel.Iconimage_Selected = null;
            this.btnNavigationPanel.IconMarginLeft = 0;
            this.btnNavigationPanel.IconMarginRight = 0;
            this.btnNavigationPanel.IconRightVisible = true;
            this.btnNavigationPanel.IconRightZoom = 0D;
            this.btnNavigationPanel.IconVisible = true;
            this.btnNavigationPanel.IconZoom = 50D;
            this.btnNavigationPanel.IsTab = false;
            this.btnNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.btnNavigationPanel.Name = "btnNavigationPanel";
            this.btnNavigationPanel.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnNavigationPanel.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnNavigationPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNavigationPanel.selected = false;
            this.btnNavigationPanel.Size = new System.Drawing.Size(177, 40);
            this.btnNavigationPanel.TabIndex = 6;
            this.btnNavigationPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavigationPanel.Textcolor = System.Drawing.Color.White;
            this.btnNavigationPanel.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNavigationPanel.Click += new System.EventHandler(this.btnNavigationPanel_Click_1);
            // 
            // btnAccountProfile
            // 
            this.btnAccountProfile.Activecolor = System.Drawing.Color.Blue;
            this.btnAccountProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccountProfile.BackColor = System.Drawing.Color.Blue;
            this.btnAccountProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccountProfile.BorderRadius = 0;
            this.btnAccountProfile.ButtonText = "    Thông Tin Cá Nhân";
            this.btnAccountProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccountProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccountProfile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccountProfile.Iconimage")));
            this.btnAccountProfile.Iconimage_right = null;
            this.btnAccountProfile.Iconimage_right_Selected = null;
            this.btnAccountProfile.Iconimage_Selected = null;
            this.btnAccountProfile.IconMarginLeft = 0;
            this.btnAccountProfile.IconMarginRight = 0;
            this.btnAccountProfile.IconRightVisible = true;
            this.btnAccountProfile.IconRightZoom = 0D;
            this.btnAccountProfile.IconVisible = true;
            this.btnAccountProfile.IconZoom = 50D;
            this.btnAccountProfile.IsTab = false;
            this.btnAccountProfile.Location = new System.Drawing.Point(3, 485);
            this.btnAccountProfile.Name = "btnAccountProfile";
            this.btnAccountProfile.Normalcolor = System.Drawing.Color.Blue;
            this.btnAccountProfile.OnHovercolor = System.Drawing.Color.Blue;
            this.btnAccountProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccountProfile.selected = false;
            this.btnAccountProfile.Size = new System.Drawing.Size(177, 40);
            this.btnAccountProfile.TabIndex = 5;
            this.btnAccountProfile.Text = "    Thông Tin Cá Nhân";
            this.btnAccountProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountProfile.Textcolor = System.Drawing.Color.White;
            this.btnAccountProfile.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.Blue;
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.Blue;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "    Đăng Xuất";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 50D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(0, 531);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.Blue;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.Blue;
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(177, 40);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "    Đăng Xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Giới Thiệu";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 670);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(206, 46);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Giới Thiệu";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 583);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí khách sạn";
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private MetroFramework.Controls.MetroTile titleBookRoom;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private MetroFramework.Controls.MetroTile titleManageRoom;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile titleRecieveRoom;
        private MetroFramework.Controls.MetroTile metroTile16;
        private MetroFramework.Controls.MetroTile metroTile17;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccountProfile;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnNavigationPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnBookingRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecieveRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnPay;
    }
}