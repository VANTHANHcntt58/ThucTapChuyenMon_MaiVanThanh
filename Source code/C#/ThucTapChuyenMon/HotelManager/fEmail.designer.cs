namespace HotelManager
{
    partial class fEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmail));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.saveParameter = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbFile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbMess = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAttachFile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbSubject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSentEmail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label14 = new System.Windows.Forms.Label();
            this.txbToCustomer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(440, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 45;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelName.Location = new System.Drawing.Point(9, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 37);
            this.labelName.TabIndex = 63;
            this.labelName.Text = "Gửi email";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.UseMnemonic = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 43);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(835, 13);
            this.bunifuSeparator1.TabIndex = 67;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // saveParameter
            // 
            this.saveParameter.FileName = "Danh sách phụ thu";
            this.saveParameter.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListCustomer);
            this.groupBox3.Controls.Add(this.txbFile);
            this.groupBox3.Controls.Add(this.txbMess);
            this.groupBox3.Controls.Add(this.btnAttachFile);
            this.groupBox3.Controls.Add(this.txbSubject);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbUserName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnClose_);
            this.groupBox3.Controls.Add(this.btnSentEmail);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txbToCustomer);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txbPass);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.bunifuCheckbox2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 540);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.ActiveBorderThickness = 1;
            this.btnListCustomer.ActiveCornerRadius = 20;
            this.btnListCustomer.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.btnListCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnListCustomer.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnListCustomer.BackColor = System.Drawing.Color.White;
            this.btnListCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListCustomer.BackgroundImage")));
            this.btnListCustomer.ButtonText = "List Customer";
            this.btnListCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnListCustomer.IdleBorderThickness = 1;
            this.btnListCustomer.IdleCornerRadius = 20;
            this.btnListCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnListCustomer.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.btnListCustomer.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.btnListCustomer.Location = new System.Drawing.Point(282, 101);
            this.btnListCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(119, 40);
            this.btnListCustomer.TabIndex = 76;
            this.btnListCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListCustomer.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txbFile
            // 
            this.txbFile.BorderColorFocused = System.Drawing.Color.DarkBlue;
            this.txbFile.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.txbFile.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.txbFile.BorderThickness = 1;
            this.txbFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFile.Enabled = false;
            this.txbFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFile.isPassword = false;
            this.txbFile.Location = new System.Drawing.Point(24, 34);
            this.txbFile.Margin = new System.Windows.Forms.Padding(0);
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(195, 40);
            this.txbFile.TabIndex = 75;
            this.txbFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbMess
            // 
            this.txbMess.BorderColorFocused = System.Drawing.Color.DarkBlue;
            this.txbMess.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.txbMess.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.txbMess.BorderThickness = 1;
            this.txbMess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMess.isPassword = false;
            this.txbMess.Location = new System.Drawing.Point(27, 361);
            this.txbMess.Margin = new System.Windows.Forms.Padding(0);
            this.txbMess.Name = "txbMess";
            this.txbMess.Size = new System.Drawing.Size(332, 83);
            this.txbMess.TabIndex = 74;
            this.txbMess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.ActiveBorderThickness = 1;
            this.btnAttachFile.ActiveCornerRadius = 20;
            this.btnAttachFile.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.btnAttachFile.ActiveForecolor = System.Drawing.Color.White;
            this.btnAttachFile.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnAttachFile.BackColor = System.Drawing.Color.White;
            this.btnAttachFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttachFile.BackgroundImage")));
            this.btnAttachFile.ButtonText = "Chọn file";
            this.btnAttachFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttachFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachFile.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAttachFile.IdleBorderThickness = 1;
            this.btnAttachFile.IdleCornerRadius = 20;
            this.btnAttachFile.IdleFillColor = System.Drawing.Color.White;
            this.btnAttachFile.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.btnAttachFile.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.btnAttachFile.Location = new System.Drawing.Point(223, 34);
            this.btnAttachFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(178, 40);
            this.btnAttachFile.TabIndex = 73;
            this.btnAttachFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // txbSubject
            // 
            this.txbSubject.BorderColorFocused = System.Drawing.Color.DarkBlue;
            this.txbSubject.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.txbSubject.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.txbSubject.BorderThickness = 1;
            this.txbSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSubject.isPassword = false;
            this.txbSubject.Location = new System.Drawing.Point(26, 169);
            this.txbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(218, 29);
            this.txbSubject.TabIndex = 71;
            this.txbSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(22, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Subject";
            // 
            // txbUserName
            // 
            this.txbUserName.BorderColorFocused = System.Drawing.Color.DarkBlue;
            this.txbUserName.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.txbUserName.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.txbUserName.BorderThickness = 1;
            this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUserName.isPassword = false;
            this.txbUserName.Location = new System.Drawing.Point(24, 223);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(218, 29);
            this.txbUserName.TabIndex = 69;
            this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(22, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.btnClose_.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.btnClose_.Location = new System.Drawing.Point(283, 471);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(109, 40);
            this.btnClose_.TabIndex = 59;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // btnSentEmail
            // 
            this.btnSentEmail.ActiveBorderThickness = 1;
            this.btnSentEmail.ActiveCornerRadius = 20;
            this.btnSentEmail.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.btnSentEmail.ActiveForecolor = System.Drawing.Color.White;
            this.btnSentEmail.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnSentEmail.BackColor = System.Drawing.Color.White;
            this.btnSentEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSentEmail.BackgroundImage")));
            this.btnSentEmail.ButtonText = "Gửi mail";
            this.btnSentEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSentEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSentEmail.IdleBorderThickness = 1;
            this.btnSentEmail.IdleCornerRadius = 20;
            this.btnSentEmail.IdleFillColor = System.Drawing.Color.White;
            this.btnSentEmail.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.btnSentEmail.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.btnSentEmail.Location = new System.Drawing.Point(164, 471);
            this.btnSentEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSentEmail.Name = "btnSentEmail";
            this.btnSentEmail.Size = new System.Drawing.Size(101, 40);
            this.btnSentEmail.TabIndex = 68;
            this.btnSentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSentEmail.Click += new System.EventHandler(this.btnSentEmail_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(22, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 67;
            this.label14.Text = "Message";
            // 
            // txbToCustomer
            // 
            this.txbToCustomer.BorderColorFocused = System.Drawing.Color.DarkBlue;
            this.txbToCustomer.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.txbToCustomer.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.txbToCustomer.BorderThickness = 1;
            this.txbToCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbToCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbToCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbToCustomer.isPassword = false;
            this.txbToCustomer.Location = new System.Drawing.Point(26, 112);
            this.txbToCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txbToCustomer.Name = "txbToCustomer";
            this.txbToCustomer.Size = new System.Drawing.Size(218, 29);
            this.txbToCustomer.TabIndex = 64;
            this.txbToCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(22, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 65;
            this.label15.Text = "Người nhận";
            // 
            // txbPass
            // 
            this.txbPass.BorderColorFocused = System.Drawing.Color.DarkBlue;
            this.txbPass.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.txbPass.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.txbPass.BorderThickness = 1;
            this.txbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPass.isPassword = true;
            this.txbPass.Location = new System.Drawing.Point(24, 288);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(218, 29);
            this.txbPass.TabIndex = 62;
            this.txbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(22, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 63;
            this.label17.Text = "Mật khẩu:";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(87, 1959);
            this.bunifuCheckbox2.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 38;
            // 
            // fEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuSeparator1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSurcharge";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.SaveFileDialog saveParameter;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAttachFile;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSubject;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbUserName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSentEmail;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbToCustomer;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPass;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMess;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbFile;
        private Bunifu.Framework.UI.BunifuThinButton2 btnListCustomer;
    }
}