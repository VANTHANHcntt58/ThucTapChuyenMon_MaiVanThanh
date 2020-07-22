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
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBookingRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecieveRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNavigationPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChangePassword = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panelRight.BackColor = System.Drawing.Color.DarkBlue;
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.Controls.Add(this.btnClose);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(206, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(857, 583);
            this.panelRight.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(834, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.bunifuFlatButton3);
            this.panelLeft.Controls.Add(this.bunifuFlatButton2);
            this.panelLeft.Controls.Add(this.btnStaff);
            this.panelLeft.Controls.Add(this.btnCustomer);
            this.panelLeft.Controls.Add(this.btnRoom);
            this.panelLeft.Controls.Add(this.btnBill);
            this.panelLeft.Controls.Add(this.btnBookingRoom);
            this.panelLeft.Controls.Add(this.btnRecieveRoom);
            this.panelLeft.Controls.Add(this.btnPay);
            this.panelLeft.Controls.Add(this.btnNavigationPanel);
            this.panelLeft.Controls.Add(this.btnChangePassword);
            this.panelLeft.Controls.Add(this.btnLogOut);
            this.panelLeft.Controls.Add(this.bunifuFlatButton1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.panelLeft.GradientBottomRight = System.Drawing.Color.Maroon;
            this.panelLeft.GradientTopLeft = System.Drawing.Color.Maroon;
            this.panelLeft.GradientTopRight = System.Drawing.Color.Maroon;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Quality = 10;
            this.panelLeft.Size = new System.Drawing.Size(206, 583);
            this.panelLeft.TabIndex = 0;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Brown;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "   Quản lí dịch vụ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-3, 409);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(209, 40);
            this.bunifuFlatButton3.TabIndex = 15;
            this.bunifuFlatButton3.Text = "   Quản lí dịch vụ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Brown;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Thống kê";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-3, 363);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(209, 40);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "   Thống kê";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Activecolor = System.Drawing.Color.Brown;
            this.btnStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStaff.BackColor = System.Drawing.Color.Brown;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaff.BorderRadius = 0;
            this.btnStaff.ButtonText = "   Quản lí nhân viên";
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStaff.Iconimage")));
            this.btnStaff.Iconimage_right = null;
            this.btnStaff.Iconimage_right_Selected = null;
            this.btnStaff.Iconimage_Selected = null;
            this.btnStaff.IconMarginLeft = 0;
            this.btnStaff.IconMarginRight = 0;
            this.btnStaff.IconRightVisible = true;
            this.btnStaff.IconRightZoom = 0D;
            this.btnStaff.IconVisible = true;
            this.btnStaff.IconZoom = 50D;
            this.btnStaff.IsTab = false;
            this.btnStaff.Location = new System.Drawing.Point(-1, 317);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Normalcolor = System.Drawing.Color.Brown;
            this.btnStaff.OnHovercolor = System.Drawing.Color.Brown;
            this.btnStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStaff.selected = false;
            this.btnStaff.Size = new System.Drawing.Size(209, 40);
            this.btnStaff.TabIndex = 13;
            this.btnStaff.Text = "   Quản lí nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Textcolor = System.Drawing.Color.White;
            this.btnStaff.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Activecolor = System.Drawing.Color.Brown;
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomer.BackColor = System.Drawing.Color.Brown;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.BorderRadius = 0;
            this.btnCustomer.ButtonText = "   Quản lí khách hàng";
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Iconimage")));
            this.btnCustomer.Iconimage_right = null;
            this.btnCustomer.Iconimage_right_Selected = null;
            this.btnCustomer.Iconimage_Selected = null;
            this.btnCustomer.IconMarginLeft = 0;
            this.btnCustomer.IconMarginRight = 0;
            this.btnCustomer.IconRightVisible = true;
            this.btnCustomer.IconRightZoom = 0D;
            this.btnCustomer.IconVisible = true;
            this.btnCustomer.IconZoom = 50D;
            this.btnCustomer.IsTab = false;
            this.btnCustomer.Location = new System.Drawing.Point(-1, 271);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Normalcolor = System.Drawing.Color.Brown;
            this.btnCustomer.OnHovercolor = System.Drawing.Color.Brown;
            this.btnCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomer.selected = false;
            this.btnCustomer.Size = new System.Drawing.Size(209, 40);
            this.btnCustomer.TabIndex = 12;
            this.btnCustomer.Text = "   Quản lí khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Textcolor = System.Drawing.Color.White;
            this.btnCustomer.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Activecolor = System.Drawing.Color.Brown;
            this.btnRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRoom.BackColor = System.Drawing.Color.Brown;
            this.btnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoom.BorderRadius = 0;
            this.btnRoom.ButtonText = "   Quản lí phòng";
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRoom.Iconimage")));
            this.btnRoom.Iconimage_right = null;
            this.btnRoom.Iconimage_right_Selected = null;
            this.btnRoom.Iconimage_Selected = null;
            this.btnRoom.IconMarginLeft = 0;
            this.btnRoom.IconMarginRight = 0;
            this.btnRoom.IconRightVisible = true;
            this.btnRoom.IconRightZoom = 0D;
            this.btnRoom.IconVisible = true;
            this.btnRoom.IconZoom = 50D;
            this.btnRoom.IsTab = false;
            this.btnRoom.Location = new System.Drawing.Point(-3, 226);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Normalcolor = System.Drawing.Color.Brown;
            this.btnRoom.OnHovercolor = System.Drawing.Color.Brown;
            this.btnRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRoom.selected = false;
            this.btnRoom.Size = new System.Drawing.Size(209, 40);
            this.btnRoom.TabIndex = 11;
            this.btnRoom.Text = "   Quản lí phòng";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Textcolor = System.Drawing.Color.White;
            this.btnRoom.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnBill
            // 
            this.btnBill.Activecolor = System.Drawing.Color.Brown;
            this.btnBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBill.BackColor = System.Drawing.Color.Brown;
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.BorderRadius = 0;
            this.btnBill.ButtonText = "   Quản lí hóa đơn";
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBill.Iconimage")));
            this.btnBill.Iconimage_right = null;
            this.btnBill.Iconimage_right_Selected = null;
            this.btnBill.Iconimage_Selected = null;
            this.btnBill.IconMarginLeft = 0;
            this.btnBill.IconMarginRight = 0;
            this.btnBill.IconRightVisible = true;
            this.btnBill.IconRightZoom = 0D;
            this.btnBill.IconVisible = true;
            this.btnBill.IconZoom = 50D;
            this.btnBill.IsTab = false;
            this.btnBill.Location = new System.Drawing.Point(0, 180);
            this.btnBill.Name = "btnBill";
            this.btnBill.Normalcolor = System.Drawing.Color.Brown;
            this.btnBill.OnHovercolor = System.Drawing.Color.Brown;
            this.btnBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBill.selected = false;
            this.btnBill.Size = new System.Drawing.Size(206, 40);
            this.btnBill.TabIndex = 10;
            this.btnBill.Text = "   Quản lí hóa đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Textcolor = System.Drawing.Color.White;
            this.btnBill.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnBookingRoom
            // 
            this.btnBookingRoom.Activecolor = System.Drawing.Color.Snow;
            this.btnBookingRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBookingRoom.BackColor = System.Drawing.Color.Brown;
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
            this.btnBookingRoom.Normalcolor = System.Drawing.Color.Brown;
            this.btnBookingRoom.OnHovercolor = System.Drawing.Color.Brown;
            this.btnBookingRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBookingRoom.selected = false;
            this.btnBookingRoom.Size = new System.Drawing.Size(206, 40);
            this.btnBookingRoom.TabIndex = 9;
            this.btnBookingRoom.Text = "    Đặt phòng";
            this.btnBookingRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingRoom.Textcolor = System.Drawing.Color.White;
            this.btnBookingRoom.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingRoom.Click += new System.EventHandler(this.btnBookingRoom_Click);
            // 
            // btnRecieveRoom
            // 
            this.btnRecieveRoom.Activecolor = System.Drawing.Color.Brown;
            this.btnRecieveRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecieveRoom.BackColor = System.Drawing.Color.Brown;
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
            this.btnRecieveRoom.Normalcolor = System.Drawing.Color.Brown;
            this.btnRecieveRoom.OnHovercolor = System.Drawing.Color.Brown;
            this.btnRecieveRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRecieveRoom.selected = false;
            this.btnRecieveRoom.Size = new System.Drawing.Size(206, 40);
            this.btnRecieveRoom.TabIndex = 8;
            this.btnRecieveRoom.Text = "    Nhận phòng";
            this.btnRecieveRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecieveRoom.Textcolor = System.Drawing.Color.White;
            this.btnRecieveRoom.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecieveRoom.Click += new System.EventHandler(this.btnRecieveRoom_Click);
            // 
            // btnPay
            // 
            this.btnPay.Activecolor = System.Drawing.Color.Blue;
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.BackColor = System.Drawing.Color.Brown;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.BorderRadius = 0;
            this.btnPay.ButtonText = "    Dịch vụ và thanh toán";
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
            this.btnPay.Normalcolor = System.Drawing.Color.Brown;
            this.btnPay.OnHovercolor = System.Drawing.Color.Brown;
            this.btnPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPay.selected = false;
            this.btnPay.Size = new System.Drawing.Size(209, 40);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "    Dịch vụ và thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Textcolor = System.Drawing.Color.White;
            this.btnPay.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnNavigationPanel
            // 
            this.btnNavigationPanel.Activecolor = System.Drawing.Color.Maroon;
            this.btnNavigationPanel.BackColor = System.Drawing.Color.Maroon;
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
            this.btnNavigationPanel.Normalcolor = System.Drawing.Color.Maroon;
            this.btnNavigationPanel.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnNavigationPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNavigationPanel.selected = false;
            this.btnNavigationPanel.Size = new System.Drawing.Size(206, 40);
            this.btnNavigationPanel.TabIndex = 6;
            this.btnNavigationPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavigationPanel.Textcolor = System.Drawing.Color.White;
            this.btnNavigationPanel.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNavigationPanel.Click += new System.EventHandler(this.btnNavigationPanel_Click_1);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Activecolor = System.Drawing.Color.Brown;
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangePassword.BackColor = System.Drawing.Color.Brown;
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePassword.BorderRadius = 0;
            this.btnChangePassword.ButtonText = "Đổi mật khẩu";
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Iconimage")));
            this.btnChangePassword.Iconimage_right = null;
            this.btnChangePassword.Iconimage_right_Selected = null;
            this.btnChangePassword.Iconimage_Selected = null;
            this.btnChangePassword.IconMarginLeft = 0;
            this.btnChangePassword.IconMarginRight = 0;
            this.btnChangePassword.IconRightVisible = true;
            this.btnChangePassword.IconRightZoom = 0D;
            this.btnChangePassword.IconVisible = true;
            this.btnChangePassword.IconZoom = 50D;
            this.btnChangePassword.IsTab = false;
            this.btnChangePassword.Location = new System.Drawing.Point(3, 485);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Normalcolor = System.Drawing.Color.Brown;
            this.btnChangePassword.OnHovercolor = System.Drawing.Color.Brown;
            this.btnChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangePassword.selected = false;
            this.btnChangePassword.Size = new System.Drawing.Size(200, 40);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Textcolor = System.Drawing.Color.White;
            this.btnChangePassword.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.Brown;
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.Brown;
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
            this.btnLogOut.Normalcolor = System.Drawing.Color.Brown;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.Brown;
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(203, 40);
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
            this.ClientSize = new System.Drawing.Size(1063, 583);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnChangePassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnNavigationPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnBookingRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecieveRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnPay;
        private Bunifu.Framework.UI.BunifuFlatButton btnBill;
        private Bunifu.Framework.UI.BunifuFlatButton btnRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnStaff;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}