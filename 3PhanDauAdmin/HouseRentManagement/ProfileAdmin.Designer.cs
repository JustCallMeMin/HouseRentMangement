﻿namespace HouseRentManagement
{
    partial class ProfileAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSEARCH = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDELETE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtpDateBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnUPDATE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtOwnerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProofID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOwnerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlProfileUser = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProfileUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvDSPROFILE = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.OwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProofID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.pnlProfileUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPROFILE)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.cbbGender);
            this.guna2Panel1.Controls.Add(this.btnSEARCH);
            this.guna2Panel1.Controls.Add(this.btnDELETE);
            this.guna2Panel1.Controls.Add(this.dtpDateBirth);
            this.guna2Panel1.Controls.Add(this.btnUPDATE);
            this.guna2Panel1.Controls.Add(this.txtPhoneNumber);
            this.guna2Panel1.Controls.Add(this.btnADD);
            this.guna2Panel1.Controls.Add(this.txtOwnerName);
            this.guna2Panel1.Controls.Add(this.txtEmail);
            this.guna2Panel1.Controls.Add(this.txtProofID);
            this.guna2Panel1.Controls.Add(this.txtOwnerID);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 94);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(795, 334);
            this.guna2Panel1.TabIndex = 1;
            // 
            // cbbGender
            // 
            this.cbbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbGender.ItemHeight = 30;
            this.cbbGender.Location = new System.Drawing.Point(464, 114);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(167, 36);
            this.cbbGender.TabIndex = 21;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.ActiveBorderThickness = 1;
            this.btnSEARCH.ActiveCornerRadius = 20;
            this.btnSEARCH.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSEARCH.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSEARCH.ActiveLineColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnSEARCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSEARCH.BackgroundImage")));
            this.btnSEARCH.ButtonText = "SEARCH";
            this.btnSEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSEARCH.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSEARCH.IdleBorderThickness = 1;
            this.btnSEARCH.IdleCornerRadius = 20;
            this.btnSEARCH.IdleFillColor = System.Drawing.Color.Red;
            this.btnSEARCH.IdleForecolor = System.Drawing.Color.White;
            this.btnSEARCH.IdleLineColor = System.Drawing.Color.LightCoral;
            this.btnSEARCH.Location = new System.Drawing.Point(674, 263);
            this.btnSEARCH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(100, 66);
            this.btnSEARCH.TabIndex = 17;
            this.btnSEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDELETE
            // 
            this.btnDELETE.ActiveBorderThickness = 1;
            this.btnDELETE.ActiveCornerRadius = 20;
            this.btnDELETE.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnDELETE.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnDELETE.ActiveLineColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnDELETE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDELETE.BackgroundImage")));
            this.btnDELETE.ButtonText = "DELETE";
            this.btnDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDELETE.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDELETE.IdleBorderThickness = 1;
            this.btnDELETE.IdleCornerRadius = 20;
            this.btnDELETE.IdleFillColor = System.Drawing.Color.Firebrick;
            this.btnDELETE.IdleForecolor = System.Drawing.Color.White;
            this.btnDELETE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDELETE.Location = new System.Drawing.Point(315, 260);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(102, 66);
            this.btnDELETE.TabIndex = 18;
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Checked = true;
            this.dtpDateBirth.FillColor = System.Drawing.Color.LightGray;
            this.dtpDateBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateBirth.Location = new System.Drawing.Point(367, 57);
            this.dtpDateBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(207, 20);
            this.dtpDateBirth.TabIndex = 3;
            this.dtpDateBirth.Value = new System.DateTime(2023, 10, 11, 11, 12, 59, 682);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ActiveBorderThickness = 1;
            this.btnUPDATE.ActiveCornerRadius = 20;
            this.btnUPDATE.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnUPDATE.ActiveForecolor = System.Drawing.Color.DarkOrange;
            this.btnUPDATE.ActiveLineColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnUPDATE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUPDATE.BackgroundImage")));
            this.btnUPDATE.ButtonText = "UPDATE";
            this.btnUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUPDATE.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUPDATE.IdleBorderThickness = 1;
            this.btnUPDATE.IdleCornerRadius = 20;
            this.btnUPDATE.IdleFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUPDATE.IdleForecolor = System.Drawing.Color.White;
            this.btnUPDATE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUPDATE.Location = new System.Drawing.Point(160, 260);
            this.btnUPDATE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(104, 66);
            this.btnUPDATE.TabIndex = 19;
            this.btnUPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(537, 193);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(118, 24);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // btnADD
            // 
            this.btnADD.ActiveBorderThickness = 1;
            this.btnADD.ActiveCornerRadius = 20;
            this.btnADD.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnADD.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnADD.ActiveLineColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.ButtonText = "ADD";
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnADD.IdleBorderThickness = 1;
            this.btnADD.IdleCornerRadius = 20;
            this.btnADD.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnADD.IdleForecolor = System.Drawing.Color.White;
            this.btnADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.Location = new System.Drawing.Point(18, 260);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(98, 66);
            this.btnADD.TabIndex = 20;
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnerName.DefaultText = "";
            this.txtOwnerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOwnerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOwnerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerName.Location = new System.Drawing.Point(178, 83);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.PasswordChar = '\0';
            this.txtOwnerName.PlaceholderText = "";
            this.txtOwnerName.SelectedText = "";
            this.txtOwnerName.Size = new System.Drawing.Size(141, 22);
            this.txtOwnerName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(124, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(155, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtProofID
            // 
            this.txtProofID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProofID.DefaultText = "";
            this.txtProofID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProofID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProofID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProofID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProofID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProofID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProofID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProofID.Location = new System.Drawing.Point(124, 156);
            this.txtProofID.Name = "txtProofID";
            this.txtProofID.PasswordChar = '\0';
            this.txtProofID.PlaceholderText = "";
            this.txtProofID.SelectedText = "";
            this.txtProofID.Size = new System.Drawing.Size(155, 22);
            this.txtProofID.TabIndex = 1;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnerID.DefaultText = "";
            this.txtOwnerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOwnerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOwnerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerID.Location = new System.Drawing.Point(124, 10);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.PasswordChar = '\0';
            this.txtOwnerID.PlaceholderText = "";
            this.txtOwnerID.SelectedText = "";
            this.txtOwnerID.Size = new System.Drawing.Size(132, 22);
            this.txtOwnerID.TabIndex = 1;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(367, 189);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(144, 28);
            this.guna2HtmlLabel7.TabIndex = 0;
            this.guna2HtmlLabel7.Text = "Phone Number";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(367, 122);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(70, 28);
            this.guna2HtmlLabel8.TabIndex = 0;
            this.guna2HtmlLabel8.Text = "Gender";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(367, 10);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(125, 28);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.Text = "Date Of Birth";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(399, 149);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = null;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(20, 202);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(53, 28);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Email";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 150);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(80, 28);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Proof ID";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 77);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(126, 28);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Owner Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 28);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Owner ID";
            // 
            // pnlProfileUser
            // 
            this.pnlProfileUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlProfileUser.Controls.Add(this.lblProfileUser);
            this.pnlProfileUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileUser.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlProfileUser.Name = "pnlProfileUser";
            this.pnlProfileUser.Size = new System.Drawing.Size(1003, 79);
            this.pnlProfileUser.TabIndex = 5;
            // 
            // lblProfileUser
            // 
            this.lblProfileUser.AllowParentOverrides = false;
            this.lblProfileUser.AutoEllipsis = false;
            this.lblProfileUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProfileUser.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblProfileUser.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileUser.ForeColor = System.Drawing.Color.White;
            this.lblProfileUser.Location = new System.Drawing.Point(10, 2);
            this.lblProfileUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProfileUser.Name = "lblProfileUser";
            this.lblProfileUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfileUser.Size = new System.Drawing.Size(117, 45);
            this.lblProfileUser.TabIndex = 0;
            this.lblProfileUser.Text = "PROFILE";
            this.lblProfileUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfileUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvDSPROFILE
            // 
            this.dgvDSPROFILE.AllowCustomTheming = false;
            this.dgvDSPROFILE.AllowUserToAddRows = false;
            this.dgvDSPROFILE.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDSPROFILE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSPROFILE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPROFILE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSPROFILE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSPROFILE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSPROFILE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSPROFILE.ColumnHeadersHeight = 40;
            this.dgvDSPROFILE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OwnerID,
            this.OwnerName,
            this.ProofID,
            this.DateOfBirth,
            this.Gender,
            this.PhoneNumber,
            this.Email});
            this.dgvDSPROFILE.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDSPROFILE.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSPROFILE.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSPROFILE.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDSPROFILE.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDSPROFILE.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDSPROFILE.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDSPROFILE.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDSPROFILE.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSPROFILE.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSPROFILE.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDSPROFILE.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDSPROFILE.CurrentTheme.Name = null;
            this.dgvDSPROFILE.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSPROFILE.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSPROFILE.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSPROFILE.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDSPROFILE.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSPROFILE.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSPROFILE.EnableHeadersVisualStyles = false;
            this.dgvDSPROFILE.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDSPROFILE.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDSPROFILE.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDSPROFILE.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDSPROFILE.Location = new System.Drawing.Point(30, 463);
            this.dgvDSPROFILE.Name = "dgvDSPROFILE";
            this.dgvDSPROFILE.ReadOnly = true;
            this.dgvDSPROFILE.RowHeadersVisible = false;
            this.dgvDSPROFILE.RowTemplate.Height = 40;
            this.dgvDSPROFILE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPROFILE.Size = new System.Drawing.Size(948, 361);
            this.dgvDSPROFILE.TabIndex = 6;
            this.dgvDSPROFILE.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // OwnerID
            // 
            this.OwnerID.HeaderText = "Owner ID";
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.ReadOnly = true;
            // 
            // OwnerName
            // 
            this.OwnerName.HeaderText = "Owner Name";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.ReadOnly = true;
            // 
            // ProofID
            // 
            this.ProofID.HeaderText = "Proof ID";
            this.ProofID.Name = "ProofID";
            this.ProofID.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(537, 270);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(130, 59);
            this.txtSearch.TabIndex = 22;
            // 
            // ProfileAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1003, 841);
            this.Controls.Add(this.dgvDSPROFILE);
            this.Controls.Add(this.pnlProfileUser);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileAdmin";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileAdmin_Load_1);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlProfileUser.ResumeLayout(false);
            this.pnlProfileUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPROFILE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtProofID;
        private Guna.UI2.WinForms.Guna2TextBox txtOwnerID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtOwnerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Panel pnlProfileUser;
        private Bunifu.UI.WinForms.BunifuLabel lblProfileUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSEARCH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDELETE;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUPDATE;
        private Bunifu.Framework.UI.BunifuThinButton2 btnADD;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDSPROFILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProofID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGender;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}