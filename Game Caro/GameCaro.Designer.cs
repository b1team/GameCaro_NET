﻿namespace Game_Caro
{
    partial class GameCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCaro));
            this.pn_GameBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grb_About = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_About = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.tm_About = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.pgb_CountDown = new System.Windows.Forms.ProgressBar();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.btn_AI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SameCom = new System.Windows.Forms.Button();
            this.btn_LAN = new System.Windows.Forms.Button();
            this.tm_CountDown = new System.Windows.Forms.Timer(this.components);
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ViaLANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SameComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutThisGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.Grb_About.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_GameBoard
            // 
            this.pn_GameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_GameBoard.AutoScroll = true;
            this.pn_GameBoard.BackColor = System.Drawing.Color.Transparent;
            this.pn_GameBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_GameBoard.Location = new System.Drawing.Point(11, 39);
            this.pn_GameBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pn_GameBoard.Name = "pn_GameBoard";
            this.pn_GameBoard.Size = new System.Drawing.Size(692, 597);
            this.pn_GameBoard.TabIndex = 0;
            this.pn_GameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_GameBoard_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Location = new System.Drawing.Point(707, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 102);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.BackgroundImage = global::Game_Caro.Properties.Resources.logo_caro;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Logo.InitialImage = null;
            this.pb_Logo.Location = new System.Drawing.Point(0, -2);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(300, 102);
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Grb_About);
            this.panel2.Controls.Add(this.txt_PlayerName);
            this.panel2.Controls.Add(this.pb_Avatar);
            this.panel2.Location = new System.Drawing.Point(707, 149);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 146);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Grb_About
            // 
            this.Grb_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Grb_About.BackColor = System.Drawing.Color.Transparent;
            this.Grb_About.Controls.Add(this.panel3);
            this.Grb_About.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grb_About.ForeColor = System.Drawing.Color.Honeydew;
            this.Grb_About.Location = new System.Drawing.Point(155, 0);
            this.Grb_About.Margin = new System.Windows.Forms.Padding(2);
            this.Grb_About.Name = "Grb_About";
            this.Grb_About.Padding = new System.Windows.Forms.Padding(2);
            this.Grb_About.Size = new System.Drawing.Size(145, 117);
            this.Grb_About.TabIndex = 0;
            this.Grb_About.TabStop = false;
            this.Grb_About.Text = "About";
            this.Grb_About.Enter += new System.EventHandler(this.Grb_About_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_About);
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 95);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_About
            // 
            this.lbl_About.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_About.ForeColor = System.Drawing.Color.Violet;
            this.lbl_About.Location = new System.Drawing.Point(0, 0);
            this.lbl_About.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(145, 90);
            this.lbl_About.TabIndex = 4;
            this.lbl_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_About.Click += new System.EventHandler(this.lbl_About_Click);
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PlayerName.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_PlayerName.Font = new System.Drawing.Font("UVN Mang Tre", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlayerName.ForeColor = System.Drawing.Color.Black;
            this.txt_PlayerName.Location = new System.Drawing.Point(155, 122);
            this.txt_PlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.ReadOnly = true;
            this.txt_PlayerName.Size = new System.Drawing.Size(146, 29);
            this.txt_PlayerName.TabIndex = 1;
            this.txt_PlayerName.Text = "Đình Ngọc";
            this.txt_PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PlayerName.TextChanged += new System.EventHandler(this.txt_PlayerName_TextChanged);
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Avatar.Location = new System.Drawing.Point(0, 0);
            this.pb_Avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(149, 146);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 0;
            this.pb_Avatar.TabStop = false;
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // tm_About
            // 
            this.tm_About.Interval = 70;
            this.tm_About.Tick += new System.EventHandler(this.Tm_About_Tick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txt_IP);
            this.panel4.Controls.Add(this.btn_Undo);
            this.panel4.Controls.Add(this.pgb_CountDown);
            this.panel4.Controls.Add(this.btn_Redo);
            this.panel4.Controls.Add(this.btn_AI);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btn_SameCom);
            this.panel4.Controls.Add(this.btn_LAN);
            this.panel4.Location = new System.Drawing.Point(707, 301);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 138);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txt_IP
            // 
            this.txt_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IP.BackColor = System.Drawing.Color.White;
            this.txt_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.ForeColor = System.Drawing.Color.Blue;
            this.txt_IP.Location = new System.Drawing.Point(155, 1);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(145, 26);
            this.txt_IP.TabIndex = 1;
            this.txt_IP.Text = "127.0.0.1";
            this.txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IP.TextChanged += new System.EventHandler(this.txt_IP_TextChanged);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Undo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Undo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Undo.FlatAppearance.BorderSize = 0;
            this.btn_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Undo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.Location = new System.Drawing.Point(0, 106);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(72, 32);
            this.btn_Undo.TabIndex = 3;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.Btn_Undo_Click);
            // 
            // pgb_CountDown
            // 
            this.pgb_CountDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgb_CountDown.BackColor = System.Drawing.Color.Lime;
            this.pgb_CountDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pgb_CountDown.Location = new System.Drawing.Point(0, 1);
            this.pgb_CountDown.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_CountDown.Name = "pgb_CountDown";
            this.pgb_CountDown.Size = new System.Drawing.Size(149, 24);
            this.pgb_CountDown.TabIndex = 2;
            this.pgb_CountDown.Click += new System.EventHandler(this.pgb_CountDown_Click);
            // 
            // btn_Redo
            // 
            this.btn_Redo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Redo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Redo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Redo.FlatAppearance.BorderSize = 0;
            this.btn_Redo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Redo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Redo.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.Location = new System.Drawing.Point(77, 106);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(72, 32);
            this.btn_Redo.TabIndex = 3;
            this.btn_Redo.Text = "Redo";
            this.btn_Redo.UseVisualStyleBackColor = false;
            this.btn_Redo.Click += new System.EventHandler(this.Btn_Redo_Click);
            // 
            // btn_AI
            // 
            this.btn_AI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AI.BackColor = System.Drawing.Color.DeepPink;
            this.btn_AI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AI.FlatAppearance.BorderSize = 0;
            this.btn_AI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AI.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AI.ForeColor = System.Drawing.Color.White;
            this.btn_AI.Location = new System.Drawing.Point(155, 106);
            this.btn_AI.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AI.Name = "btn_AI";
            this.btn_AI.Size = new System.Drawing.Size(145, 32);
            this.btn_AI.TabIndex = 3;
            this.btn_AI.Text = "Player vs Com";
            this.btn_AI.UseVisualStyleBackColor = false;
            this.btn_AI.Click += new System.EventHandler(this.Btn_AI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Game_Caro.Properties.Resources.Cocaro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_SameCom
            // 
            this.btn_SameCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SameCom.BackColor = System.Drawing.Color.DeepPink;
            this.btn_SameCom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SameCom.FlatAppearance.BorderSize = 0;
            this.btn_SameCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SameCom.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SameCom.ForeColor = System.Drawing.Color.White;
            this.btn_SameCom.Location = new System.Drawing.Point(155, 68);
            this.btn_SameCom.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SameCom.Name = "btn_SameCom";
            this.btn_SameCom.Size = new System.Drawing.Size(145, 32);
            this.btn_SameCom.TabIndex = 3;
            this.btn_SameCom.Text = "2 Players / Com";
            this.btn_SameCom.UseVisualStyleBackColor = false;
            this.btn_SameCom.Click += new System.EventHandler(this.Btn_SameCom_Click);
            // 
            // btn_LAN
            // 
            this.btn_LAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LAN.BackColor = System.Drawing.Color.DeepPink;
            this.btn_LAN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LAN.FlatAppearance.BorderSize = 0;
            this.btn_LAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LAN.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LAN.ForeColor = System.Drawing.Color.White;
            this.btn_LAN.Location = new System.Drawing.Point(155, 31);
            this.btn_LAN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LAN.Name = "btn_LAN";
            this.btn_LAN.Size = new System.Drawing.Size(145, 32);
            this.btn_LAN.TabIndex = 3;
            this.btn_LAN.Text = "2 Players in LAN";
            this.btn_LAN.UseVisualStyleBackColor = false;
            this.btn_LAN.Click += new System.EventHandler(this.Btn_LAN_Click);
            // 
            // tm_CountDown
            // 
            this.tm_CountDown.Tick += new System.EventHandler(this.Tm_CountDown_Tick);
            // 
            // txt_Message
            // 
            this.txt_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Message.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Message.Location = new System.Drawing.Point(709, 612);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(243, 26);
            this.txt_Message.TabIndex = 4;
            this.txt_Message.TextChanged += new System.EventHandler(this.txt_Message_TextChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Send.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.btn_Send.ForeColor = System.Drawing.Color.White;
            this.btn_Send.Location = new System.Drawing.Point(954, 612);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(53, 24);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem2,
            this.playerToolStripMenuItem1,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem2
            // 
            this.playerToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViaLANToolStripMenuItem,
            this.SameComToolStripMenuItem});
            this.playerToolStripMenuItem2.Name = "playerToolStripMenuItem2";
            this.playerToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.playerToolStripMenuItem2.Text = "2 Players";
            this.playerToolStripMenuItem2.Click += new System.EventHandler(this.playerToolStripMenuItem2_Click);
            // 
            // ViaLANToolStripMenuItem
            // 
            this.ViaLANToolStripMenuItem.Name = "ViaLANToolStripMenuItem";
            this.ViaLANToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ViaLANToolStripMenuItem.Text = "Via LAN";
            this.ViaLANToolStripMenuItem.Click += new System.EventHandler(this.ViaLANToolStripMenuItem_Click);
            // 
            // SameComToolStripMenuItem
            // 
            this.SameComToolStripMenuItem.Name = "SameComToolStripMenuItem";
            this.SameComToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.SameComToolStripMenuItem.Text = "On Same Computer";
            this.SameComToolStripMenuItem.Click += new System.EventHandler(this.SameComToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.playerToolStripMenuItem1.Text = "1 Player";
            this.playerToolStripMenuItem1.Click += new System.EventHandler(this.PlayerToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.contactMeToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutThisGameToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.HowToPlayToolStripMenuItem_Click);
            // 
            // contactMeToolStripMenuItem
            // 
            this.contactMeToolStripMenuItem.Name = "contactMeToolStripMenuItem";
            this.contactMeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contactMeToolStripMenuItem.Text = "Contact me";
            this.contactMeToolStripMenuItem.Click += new System.EventHandler(this.ContactMeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator3_Click);
            // 
            // aboutThisGameToolStripMenuItem
            // 
            this.aboutThisGameToolStripMenuItem.Name = "aboutThisGameToolStripMenuItem";
            this.aboutThisGameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutThisGameToolStripMenuItem.Text = "About this game";
            this.aboutThisGameToolStripMenuItem.Click += new System.EventHandler(this.AboutThisGameToolStripMenuItem_Click);
            // 
            // txt_Chat
            // 
            this.txt_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Chat.BackColor = System.Drawing.Color.White;
            this.txt_Chat.Font = new System.Drawing.Font("Arial", 11F);
            this.txt_Chat.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Chat.Location = new System.Drawing.Point(706, 443);
            this.txt_Chat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.ReadOnly = true;
            this.txt_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Chat.Size = new System.Drawing.Size(301, 154);
            this.txt_Chat.TabIndex = 4;
            this.txt_Chat.Text = "- Player 1: ";
            this.txt_Chat.TextChanged += new System.EventHandler(this.txt_Chat_TextChanged);
            // 
            // GameCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::Game_Caro.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 661);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_GameBoard);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameCaro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameCaro_FormClosing);
            this.Load += new System.EventHandler(this.GameCaro_Load);
            this.Shown += new System.EventHandler(this.GameCaro_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Grb_About.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pn_GameBoard;

        #region MenuStrip
        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ViaLANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SameComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutThisGameToolStripMenuItem;
        #endregion

        #region Panel 1
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Logo;
        #endregion

        #region Panel 2 + 3
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.GroupBox Grb_About;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_About;
        private System.Windows.Forms.Timer tm_About;
        private System.Windows.Forms.TextBox txt_PlayerName;
        #endregion

        #region Panel 4
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer tm_CountDown;
        private System.Windows.Forms.ProgressBar pgb_CountDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_LAN;
        private System.Windows.Forms.Button btn_SameCom;
        private System.Windows.Forms.Button btn_AI;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Redo;
        #endregion

        #region LAN Chat
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Send;
        #endregion
    }
}