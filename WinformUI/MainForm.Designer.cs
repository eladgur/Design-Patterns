namespace WinformUI
{
    public partial class MainForm
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
            this.TabControll = new System.Windows.Forms.TabControl();
            this.BasicTab = new System.Windows.Forms.TabPage();
            this.pictureBoxFBLogoText = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.appSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.checkinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.pictureBoxProfileImg = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTab = new System.Windows.Forms.TabPage();
            this.splitContainerForm = new System.Windows.Forms.SplitContainer();
            this.activeFriendByDistancecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonSendMostActiveFriendByDistance = new System.Windows.Forms.Button();
            this.textBoxChosenDistance2 = new System.Windows.Forms.TextBox();
            this.TextBoxMostActiveFriendByLocations = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSendFriendsDistance = new System.Windows.Forms.Button();
            this.textBoxChosenDistance1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFriendsLocations = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowserLocation = new System.Windows.Forms.WebBrowser();
            this.ActiveFriendTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxAdvanceSortingAlg = new System.Windows.Forms.CheckBox();
            this.checkBoxdefaultSortingAlg = new System.Windows.Forms.CheckBox();
            this.webBrowserFriendProfile = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckedListBoxSortingParameters = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSelectAllSortingParameters = new System.Windows.Forms.CheckBox();
            this.mostActiveFriendsListBox = new System.Windows.Forms.ListBox();
            this.fetchMostActiveFriendsButton = new System.Windows.Forms.Button();
            this.checkBoxShowVScrollBar = new System.Windows.Forms.CheckBox();
            this.checkBoxShowHScrollBar = new System.Windows.Forms.CheckBox();
            this.TabControll.SuspendLayout();
            this.BasicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBLogoText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.locationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).BeginInit();
            this.splitContainerForm.Panel1.SuspendLayout();
            this.splitContainerForm.Panel2.SuspendLayout();
            this.splitContainerForm.SuspendLayout();
            this.ActiveFriendTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.BasicTab);
            this.TabControll.Controls.Add(this.locationTab);
            this.TabControll.Controls.Add(this.ActiveFriendTab);
            this.TabControll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControll.Location = new System.Drawing.Point(0, 0);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(1081, 628);
            this.TabControll.TabIndex = 0;
            // 
            // BasicTab
            // 
            this.BasicTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BasicTab.Controls.Add(this.pictureBoxFBLogoText);
            this.BasicTab.Controls.Add(this.label7);
            this.BasicTab.Controls.Add(this.label6);
            this.BasicTab.Controls.Add(this.label5);
            this.BasicTab.Controls.Add(this.label4);
            this.BasicTab.Controls.Add(this.checkBoxRememberMe);
            this.BasicTab.Controls.Add(this.buttonLogout);
            this.BasicTab.Controls.Add(this.buttonLogin);
            this.BasicTab.Controls.Add(this.friendsListBox);
            this.BasicTab.Controls.Add(this.listBoxEvents);
            this.BasicTab.Controls.Add(this.listBoxCheckins);
            this.BasicTab.Controls.Add(this.listBoxPosts);
            this.BasicTab.Controls.Add(this.buttonSetStatus);
            this.BasicTab.Controls.Add(this.pictureBoxProfileImg);
            this.BasicTab.Controls.Add(this.textBoxStatus);
            this.BasicTab.Controls.Add(this.pictureBoxFriend);
            this.BasicTab.Controls.Add(this.label3);
            this.BasicTab.Location = new System.Drawing.Point(4, 22);
            this.BasicTab.Name = "BasicTab";
            this.BasicTab.Padding = new System.Windows.Forms.Padding(3);
            this.BasicTab.Size = new System.Drawing.Size(1073, 602);
            this.BasicTab.TabIndex = 3;
            this.BasicTab.Text = "Basic";
            // 
            // pictureBoxFBLogoText
            // 
            this.pictureBoxFBLogoText.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Facebook.svg/2000px-Fac" +
    "ebook.svg.png";
            this.pictureBoxFBLogoText.Location = new System.Drawing.Point(17, 3);
            this.pictureBoxFBLogoText.Name = "pictureBoxFBLogoText";
            this.pictureBoxFBLogoText.Size = new System.Drawing.Size(73, 26);
            this.pictureBoxFBLogoText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFBLogoText.TabIndex = 59;
            this.pictureBoxFBLogoText.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Checkins:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Events:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Posts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Friends:";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.appSettingsBindingSource, "RememberMe", true));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(194, 63);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 52;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // appSettingsBindingSource
            // 
            this.appSettingsBindingSource.DataSource = typeof(Logic.AppSettings);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(194, 34);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 51;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.logoutClick);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(194, 34);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.loginClick);
            // 
            // friendsListBox
            // 
            this.friendsListBox.DataSource = this.friendsBindingSource;
            this.friendsListBox.DisplayMember = "Name";
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(17, 218);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(160, 368);
            this.friendsListBox.TabIndex = 37;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "Friends";
            this.friendsBindingSource.DataSource = this.userBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DataSource = this.eventsBindingSource;
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(344, 242);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(704, 160);
            this.listBoxEvents.TabIndex = 40;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.userBindingSource;
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCheckins.DataSource = this.checkinsBindingSource;
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(344, 426);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(704, 160);
            this.listBoxCheckins.TabIndex = 40;
            // 
            // checkinsBindingSource
            // 
            this.checkinsBindingSource.DataMember = "Checkins";
            this.checkinsBindingSource.DataSource = this.userBindingSource;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DataSource = this.postsBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(344, 59);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(704, 156);
            this.listBoxPosts.TabIndex = 40;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.userBindingSource;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Location = new System.Drawing.Point(860, 9);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(64, 20);
            this.buttonSetStatus.TabIndex = 46;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // pictureBoxProfileImg
            // 
            this.pictureBoxProfileImg.Location = new System.Drawing.Point(-3, 34);
            this.pictureBoxProfileImg.Name = "pictureBoxProfileImg";
            this.pictureBoxProfileImg.Size = new System.Drawing.Size(200, 156);
            this.pictureBoxProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfileImg.TabIndex = 41;
            this.pictureBoxProfileImg.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(421, 9);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(433, 20);
            this.textBoxStatus.TabIndex = 45;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(194, 218);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(106, 100);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFriend.TabIndex = 42;
            this.pictureBoxFriend.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(341, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Post Status:";
            // 
            // locationTab
            // 
            this.locationTab.Controls.Add(this.splitContainerForm);
            this.locationTab.Location = new System.Drawing.Point(4, 22);
            this.locationTab.Name = "locationTab";
            this.locationTab.Padding = new System.Windows.Forms.Padding(3);
            this.locationTab.Size = new System.Drawing.Size(1073, 602);
            this.locationTab.TabIndex = 4;
            this.locationTab.Text = "Location";
            this.locationTab.UseVisualStyleBackColor = true;
            // 
            // splitContainerForm
            // 
            this.splitContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerForm.Location = new System.Drawing.Point(3, 3);
            this.splitContainerForm.Name = "splitContainerForm";
            // 
            // splitContainerForm.Panel1
            // 
            this.splitContainerForm.Panel1.AllowDrop = true;
            this.splitContainerForm.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainerForm.Panel1.Controls.Add(this.checkBoxShowHScrollBar);
            this.splitContainerForm.Panel1.Controls.Add(this.checkBoxShowVScrollBar);
            this.splitContainerForm.Panel1.Controls.Add(this.activeFriendByDistancecheckedListBox);
            this.splitContainerForm.Panel1.Controls.Add(this.buttonSendMostActiveFriendByDistance);
            this.splitContainerForm.Panel1.Controls.Add(this.textBoxChosenDistance2);
            this.splitContainerForm.Panel1.Controls.Add(this.TextBoxMostActiveFriendByLocations);
            this.splitContainerForm.Panel1.Controls.Add(this.label8);
            this.splitContainerForm.Panel1.Controls.Add(this.buttonSendFriendsDistance);
            this.splitContainerForm.Panel1.Controls.Add(this.textBoxChosenDistance1);
            this.splitContainerForm.Panel1.Controls.Add(this.label2);
            this.splitContainerForm.Panel1.Controls.Add(this.listBoxFriendsLocations);
            // 
            // splitContainerForm.Panel2
            // 
            this.splitContainerForm.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainerForm.Panel2.Controls.Add(this.webBrowserLocation);
            this.splitContainerForm.Size = new System.Drawing.Size(1067, 596);
            this.splitContainerForm.SplitterDistance = 381;
            this.splitContainerForm.TabIndex = 5;
            // 
            // activeFriendByDistancecheckedListBox
            // 
            this.activeFriendByDistancecheckedListBox.FormattingEnabled = true;
            this.activeFriendByDistancecheckedListBox.Items.AddRange(new object[] {
            "Posts",
            "Friends",
            "Photos Tagged In",
            "Statuses",
            "Videos",
            "Albums"});
            this.activeFriendByDistancecheckedListBox.Location = new System.Drawing.Point(16, 375);
            this.activeFriendByDistancecheckedListBox.Name = "activeFriendByDistancecheckedListBox";
            this.activeFriendByDistancecheckedListBox.Size = new System.Drawing.Size(135, 94);
            this.activeFriendByDistancecheckedListBox.TabIndex = 18;
            // 
            // buttonSendMostActiveFriendByDistance
            // 
            this.buttonSendMostActiveFriendByDistance.Location = new System.Drawing.Point(310, 311);
            this.buttonSendMostActiveFriendByDistance.Name = "buttonSendMostActiveFriendByDistance";
            this.buttonSendMostActiveFriendByDistance.Size = new System.Drawing.Size(43, 23);
            this.buttonSendMostActiveFriendByDistance.TabIndex = 17;
            this.buttonSendMostActiveFriendByDistance.Text = "Send";
            this.buttonSendMostActiveFriendByDistance.UseVisualStyleBackColor = true;
            this.buttonSendMostActiveFriendByDistance.Click += new System.EventHandler(this.buttonSendMostActiveFriendByDistance_Click);
            // 
            // textBoxChosenDistance2
            // 
            this.textBoxChosenDistance2.Location = new System.Drawing.Point(260, 315);
            this.textBoxChosenDistance2.Name = "textBoxChosenDistance2";
            this.textBoxChosenDistance2.Size = new System.Drawing.Size(44, 20);
            this.textBoxChosenDistance2.TabIndex = 16;
            // 
            // TextBoxMostActiveFriendByLocations
            // 
            this.TextBoxMostActiveFriendByLocations.Location = new System.Drawing.Point(16, 340);
            this.TextBoxMostActiveFriendByLocations.Name = "TextBoxMostActiveFriendByLocations";
            this.TextBoxMostActiveFriendByLocations.Size = new System.Drawing.Size(337, 20);
            this.TextBoxMostActiveFriendByLocations.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(13, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Show Most Active Friend \r\nWithin Distance (in KM):";
            // 
            // buttonSendFriendsDistance
            // 
            this.buttonSendFriendsDistance.Location = new System.Drawing.Point(310, 14);
            this.buttonSendFriendsDistance.Name = "buttonSendFriendsDistance";
            this.buttonSendFriendsDistance.Size = new System.Drawing.Size(43, 23);
            this.buttonSendFriendsDistance.TabIndex = 13;
            this.buttonSendFriendsDistance.Text = "Send";
            this.buttonSendFriendsDistance.UseVisualStyleBackColor = true;
            this.buttonSendFriendsDistance.Click += new System.EventHandler(this.buttonSendFriendsDistance_Click);
            // 
            // textBoxChosenDistance1
            // 
            this.textBoxChosenDistance1.Location = new System.Drawing.Point(260, 17);
            this.textBoxChosenDistance1.Name = "textBoxChosenDistance1";
            this.textBoxChosenDistance1.Size = new System.Drawing.Size(44, 20);
            this.textBoxChosenDistance1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Show Friends Within\r\nDistance (in KM):";
            // 
            // listBoxFriendsLocations
            // 
            this.listBoxFriendsLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriendsLocations.FormattingEnabled = true;
            this.listBoxFriendsLocations.Location = new System.Drawing.Point(16, 50);
            this.listBoxFriendsLocations.Name = "listBoxFriendsLocations";
            this.listBoxFriendsLocations.Size = new System.Drawing.Size(337, 238);
            this.listBoxFriendsLocations.TabIndex = 8;
            this.listBoxFriendsLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsLocations_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(682, 596);
            this.webBrowser1.TabIndex = 5;
            // 
            // webBrowserLocation
            // 
            this.webBrowserLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserLocation.Location = new System.Drawing.Point(0, 0);
            this.webBrowserLocation.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserLocation.Name = "webBrowserLocation";
            this.webBrowserLocation.Size = new System.Drawing.Size(682, 596);
            this.webBrowserLocation.TabIndex = 4;
            this.webBrowserLocation.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // ActiveFriendTab
            // 
            this.ActiveFriendTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ActiveFriendTab.Controls.Add(this.label9);
            this.ActiveFriendTab.Controls.Add(this.checkBoxAdvanceSortingAlg);
            this.ActiveFriendTab.Controls.Add(this.checkBoxdefaultSortingAlg);
            this.ActiveFriendTab.Controls.Add(this.webBrowserFriendProfile);
            this.ActiveFriendTab.Controls.Add(this.label1);
            this.ActiveFriendTab.Controls.Add(this.CheckedListBoxSortingParameters);
            this.ActiveFriendTab.Controls.Add(this.checkBoxSelectAllSortingParameters);
            this.ActiveFriendTab.Controls.Add(this.mostActiveFriendsListBox);
            this.ActiveFriendTab.Controls.Add(this.fetchMostActiveFriendsButton);
            this.ActiveFriendTab.Location = new System.Drawing.Point(4, 22);
            this.ActiveFriendTab.Name = "ActiveFriendTab";
            this.ActiveFriendTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveFriendTab.Size = new System.Drawing.Size(1073, 602);
            this.ActiveFriendTab.TabIndex = 5;
            this.ActiveFriendTab.Text = "Active";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Sorting Algorithm:";
            // 
            // checkBoxAdvanceSortingAlg
            // 
            this.checkBoxAdvanceSortingAlg.AutoSize = true;
            this.checkBoxAdvanceSortingAlg.Location = new System.Drawing.Point(22, 208);
            this.checkBoxAdvanceSortingAlg.Name = "checkBoxAdvanceSortingAlg";
            this.checkBoxAdvanceSortingAlg.Size = new System.Drawing.Size(75, 17);
            this.checkBoxAdvanceSortingAlg.TabIndex = 56;
            this.checkBoxAdvanceSortingAlg.Text = "Advanced";
            this.checkBoxAdvanceSortingAlg.UseVisualStyleBackColor = true;
            this.checkBoxAdvanceSortingAlg.Click += new System.EventHandler(this.checkBoxAdvanceSortingAlg_Click);
            // 
            // checkBoxdefaultSortingAlg
            // 
            this.checkBoxdefaultSortingAlg.AutoSize = true;
            this.checkBoxdefaultSortingAlg.Checked = true;
            this.checkBoxdefaultSortingAlg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxdefaultSortingAlg.Location = new System.Drawing.Point(22, 185);
            this.checkBoxdefaultSortingAlg.Name = "checkBoxdefaultSortingAlg";
            this.checkBoxdefaultSortingAlg.Size = new System.Drawing.Size(60, 17);
            this.checkBoxdefaultSortingAlg.TabIndex = 55;
            this.checkBoxdefaultSortingAlg.Text = "Default";
            this.checkBoxdefaultSortingAlg.UseVisualStyleBackColor = true;
            this.checkBoxdefaultSortingAlg.Click += new System.EventHandler(this.checkBoxdefaultSortingAlg_Click);
            // 
            // webBrowserFriendProfile
            // 
            this.webBrowserFriendProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowserFriendProfile.Location = new System.Drawing.Point(440, 3);
            this.webBrowserFriendProfile.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserFriendProfile.Name = "webBrowserFriendProfile";
            this.webBrowserFriendProfile.Size = new System.Drawing.Size(630, 596);
            this.webBrowserFriendProfile.TabIndex = 54;
            this.webBrowserFriendProfile.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sort by:";
            // 
            // CheckedListBoxSortingParameters
            // 
            this.CheckedListBoxSortingParameters.FormattingEnabled = true;
            this.CheckedListBoxSortingParameters.Items.AddRange(new object[] {
            "Posts",
            "Friends",
            "Photos Tagged In",
            "Statuses",
            "Videos",
            "Albums"});
            this.CheckedListBoxSortingParameters.Location = new System.Drawing.Point(23, 57);
            this.CheckedListBoxSortingParameters.Name = "CheckedListBoxSortingParameters";
            this.CheckedListBoxSortingParameters.Size = new System.Drawing.Size(120, 94);
            this.CheckedListBoxSortingParameters.TabIndex = 7;
            // 
            // checkBoxSelectAllSortingParameters
            // 
            this.checkBoxSelectAllSortingParameters.AutoSize = true;
            this.checkBoxSelectAllSortingParameters.Location = new System.Drawing.Point(23, 34);
            this.checkBoxSelectAllSortingParameters.Name = "checkBoxSelectAllSortingParameters";
            this.checkBoxSelectAllSortingParameters.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSelectAllSortingParameters.TabIndex = 2;
            this.checkBoxSelectAllSortingParameters.Text = "Select all";
            this.checkBoxSelectAllSortingParameters.UseVisualStyleBackColor = true;
            this.checkBoxSelectAllSortingParameters.CheckedChanged += new System.EventHandler(this.checkBoxSelectAllSortingParameters_CheckedChanged);
            // 
            // mostActiveFriendsListBox
            // 
            this.mostActiveFriendsListBox.FormattingEnabled = true;
            this.mostActiveFriendsListBox.Location = new System.Drawing.Point(178, 48);
            this.mostActiveFriendsListBox.Name = "mostActiveFriendsListBox";
            this.mostActiveFriendsListBox.Size = new System.Drawing.Size(244, 524);
            this.mostActiveFriendsListBox.TabIndex = 1;
            this.mostActiveFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.mostActiveFriendsListBox_SelectedIndexChanged);
            // 
            // fetchMostActiveFriendsButton
            // 
            this.fetchMostActiveFriendsButton.AutoSize = true;
            this.fetchMostActiveFriendsButton.BackColor = System.Drawing.Color.Aquamarine;
            this.fetchMostActiveFriendsButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchMostActiveFriendsButton.Location = new System.Drawing.Point(178, 14);
            this.fetchMostActiveFriendsButton.Name = "fetchMostActiveFriendsButton";
            this.fetchMostActiveFriendsButton.Size = new System.Drawing.Size(244, 28);
            this.fetchMostActiveFriendsButton.TabIndex = 0;
            this.fetchMostActiveFriendsButton.Text = "Fetch Most Active Friends";
            this.fetchMostActiveFriendsButton.UseVisualStyleBackColor = false;
            this.fetchMostActiveFriendsButton.Click += new System.EventHandler(this.fetchMostActiveFriendsButton_Click);
            // 
            // checkBoxShowVScrollBar
            // 
            this.checkBoxShowVScrollBar.AutoSize = true;
            this.checkBoxShowVScrollBar.Checked = true;
            this.checkBoxShowVScrollBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowVScrollBar.Location = new System.Drawing.Point(260, 375);
            this.checkBoxShowVScrollBar.Name = "checkBoxShowVScrollBar";
            this.checkBoxShowVScrollBar.Size = new System.Drawing.Size(105, 17);
            this.checkBoxShowVScrollBar.TabIndex = 19;
            this.checkBoxShowVScrollBar.Text = "Show VScrollBar";
            this.checkBoxShowVScrollBar.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowHScrollBar
            // 
            this.checkBoxShowHScrollBar.AutoSize = true;
            this.checkBoxShowHScrollBar.Location = new System.Drawing.Point(260, 398);
            this.checkBoxShowHScrollBar.Name = "checkBoxShowHScrollBar";
            this.checkBoxShowHScrollBar.Size = new System.Drawing.Size(106, 17);
            this.checkBoxShowHScrollBar.TabIndex = 20;
            this.checkBoxShowHScrollBar.Text = "Show HScrollBar";
            this.checkBoxShowHScrollBar.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 628);
            this.Controls.Add(this.TabControll);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facebook App";
            this.TabControll.ResumeLayout(false);
            this.BasicTab.ResumeLayout(false);
            this.BasicTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBLogoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.locationTab.ResumeLayout(false);
            this.splitContainerForm.Panel1.ResumeLayout(false);
            this.splitContainerForm.Panel1.PerformLayout();
            this.splitContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).EndInit();
            this.splitContainerForm.ResumeLayout(false);
            this.ActiveFriendTab.ResumeLayout(false);
            this.ActiveFriendTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage BasicTab;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfileImg;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage locationTab;
        private System.Windows.Forms.SplitContainer splitContainerForm;
        private System.Windows.Forms.ListBox listBoxFriendsLocations;
        private System.Windows.Forms.WebBrowser webBrowserLocation;
        private System.Windows.Forms.TabPage ActiveFriendTab;
        private System.Windows.Forms.ListBox mostActiveFriendsListBox;
        private System.Windows.Forms.Button fetchMostActiveFriendsButton;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.CheckBox checkBoxSelectAllSortingParameters;
        private System.Windows.Forms.CheckedListBox CheckedListBoxSortingParameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowserFriendProfile;
        private System.Windows.Forms.BindingSource appSettingsBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChosenDistance1;
        private System.Windows.Forms.Button buttonSendFriendsDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxFBLogoText;
        private System.Windows.Forms.Button buttonSendMostActiveFriendByDistance;
        private System.Windows.Forms.TextBox textBoxChosenDistance2;
        private System.Windows.Forms.TextBox TextBoxMostActiveFriendByLocations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox activeFriendByDistancecheckedListBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.BindingSource checkinsBindingSource;
        private System.Windows.Forms.CheckBox checkBoxAdvanceSortingAlg;
        private System.Windows.Forms.CheckBox checkBoxdefaultSortingAlg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxShowHScrollBar;
        private System.Windows.Forms.CheckBox checkBoxShowVScrollBar;
    }
}