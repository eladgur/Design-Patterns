using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformUI
{
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    using FacebookWrapper.ObjectModel;
    using Logic;
    using Logic.ActiveFriend;
    using Logic.FriendsByDistance;

    public partial class MainForm : Form
    {
        private const string k_DefualtProfileImg = @"https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Default_profile_picture_%28male%29_on_Facebook.jpg/600px-Default_profile_picture_%28male%29_on_Facebook.jpg";
        private User m_LoggedInUser;

        public MainForm()
        {
            InitializeComponent();
            ConnectManager.m_ReportUserLoggedInDelegates += this.onUserLoggedIn;
            pictureBoxProfileImg.ImageLocation = k_DefualtProfileImg;

            if (ConnectManager.Settings.RememberMe)
            {
                Size = ConnectManager.Settings.LastWindowSize;
                Location = ConnectManager.Settings.LastWindowLocation;
                ConnectManager.Login();
            }

            webBrowser1.Navigate("https://www.google.com/maps");
        }

        private void onUserLoggedIn(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            try
            {
                userBindingSource.DataSource = m_LoggedInUser;
            }
            catch (Exception)
            {
                // No Facebook permitions...
            }

            appSettingsBindingSource.DataSource = ConnectManager.Settings;
            buttonLogin.Visible = false;
            fetchUserInfo();
            buttonLogout.Visible = true;
        }

        private void loginClick(object i_Sender, EventArgs i_E)
        {
            ConnectManager.Login();
        }

        private void fetchUserInfo()
        {
            pictureBoxProfileImg.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void logoutClick(object i_Sender, EventArgs i_E)
        {
            pictureBoxProfileImg.ImageLocation = k_DefualtProfileImg;
            pictureBoxFriend.Image = null;
            ConnectManager.Logout();
            buttonLogin.Visible = true;
            buttonLogout.Visible = false;
            userBindingSource.Clear();
        }

        private void listBoxFriendsLocations_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            User destinationUser = listBoxFriendsLocations.SelectedItem as User;

            try
            {
                FacebookMapFacade.ShowDirections(m_LoggedInUser, destinationUser,
                    webBrowserLocation, checkBoxShowHScrollBar.Checked, checkBoxShowVScrollBar.Checked);
            }
            catch (Exception)
            {
                // This will allways happend due to lack of permitions from FaceBook =]
            }
        }

        private void fetchMostActiveFriendsButton_Click(object i_Sender, EventArgs i_E)
        {
            if (m_LoggedInUser != null)
            {
                Thread thread = new Thread(() =>
                {
                    List<string> sortParamsList = CheckedListBoxSortingParameters.CheckedItems.OfType<string>().ToList();
                    List<User> friendList = m_LoggedInUser.Friends.ToList();
                    List<UserToICompareableAdapter> activeFriendList =
                        ActiveFriendFeatureManager.FetchActiveFriendsList(m_LoggedInUser, sortParamsList, friendList);

                    mostActiveFriendsListBox.Invoke(new Action(() =>
                    {
                        mostActiveFriendsListBox.Items.Clear();
                        mostActiveFriendsListBox.DisplayMember = "Name";
                        activeFriendList.ForEach(new Action<UserToICompareableAdapter>(friend => mostActiveFriendsListBox.Items.Add(friend)));
                    }));
                });
                thread.Start();
            }
        }

        private void buttonSetStatus_Click(object i_Sender, EventArgs i_E)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void checkBoxSelectAllSortingParameters_CheckedChanged(object i_Sender, EventArgs i_E)
        {
            for (int i = 0; i < CheckedListBoxSortingParameters.Items.Count; i++)
            {
                CheckedListBoxSortingParameters.SetItemChecked(i, checkBoxSelectAllSortingParameters.Checked);
            }
        }

        private void mostActiveFriendsListBox_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            UserToICompareableAdapter v_UserToICompareableAdapter = mostActiveFriendsListBox.SelectedItem as UserToICompareableAdapter;
            if (v_UserToICompareableAdapter != null)
            {
                webBrowserFriendProfile.Navigate("https://www.facebook.com/" + v_UserToICompareableAdapter.Name);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs i_E)
        {
            base.OnFormClosing(i_E);
            if (checkBoxRememberMe.Enabled && checkBoxRememberMe.Checked)
            {
                ConnectManager.Settings.LastWindowLocation = Location;
                ConnectManager.Settings.LastWindowSize = Size;
                ConnectManager.Settings.RememberMe = checkBoxRememberMe.Checked;
            }
            else
            {
                ConnectManager.Settings.AccessToken = null;
                ConnectManager.Settings.RememberMe = false;
            }

            ConnectManager.SaveSettings();
        }

        private void buttonSendFriendsDistance_Click(object i_Sender, EventArgs i_E)
        {
            if (validateFriendDistance(textBoxChosenDistance1))
            {
                int distance = int.Parse(textBoxChosenDistance1.Text);
                List<User> users = FriendsByDistanceFeatureManager.GetFriendsInDistance(m_LoggedInUser, distance);
                listBoxFriendsLocations.Items.Clear();
                listBoxFriendsLocations.DisplayMember = "Name";
                foreach (User user in users)
                {
                    listBoxFriendsLocations.Items.Add(user);
                }
            }
        }

        private bool validateFriendDistance(TextBox i_ChosenDistanceTextBox)
        {
            const int k_MinVal = 0;
            const int k_MaxVal = 1000;
            bool valid = true;
            int chosenDistance;
            try
            {
                chosenDistance = int.Parse(i_ChosenDistanceTextBox.Text);
                if (chosenDistance < k_MinVal || k_MaxVal < chosenDistance)
                {
                    MessageBox.Show(string.Format("Please enter a number between {0} and {1}", k_MinVal, k_MaxVal));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number");
                valid = false;
            }

            return valid;
        }

        private void friendsListBox_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (friendsListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = friendsListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }

        private void buttonSendMostActiveFriendByDistance_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null && validateFriendDistance(textBoxChosenDistance2))
            {
                int chosenDistance = int.Parse(textBoxChosenDistance2.Text);
                List<string> sortParamsList = activeFriendByDistancecheckedListBox.CheckedItems.OfType<string>().ToList();

                try
                {
                    UserToICompareableAdapter mostActiveFriendByDistance = Logic.MostActiveFriendByDistanceFacade.getActiveFriendByDistance(m_LoggedInUser, chosenDistance, sortParamsList);
                    textBoxChosenDistance2.Text = mostActiveFriendByDistance.Name;
                }
                catch (Exception)
                {
                    // This will always happen because no permissions from facebook ! =]
                }
            }
        }

        private void checkBoxdefaultSortingAlg_Click(object sender, EventArgs e)
        {
            checkBoxAdvanceSortingAlg.Checked = false;
            (sender as CheckBox).Checked = true;
            UserToICompareableAdapter.SetScoreStrategy(new DefaultScoreStrategy());
        }

        private void checkBoxAdvanceSortingAlg_Click(object sender, EventArgs e)
        {
            checkBoxdefaultSortingAlg.Checked = false;
            (sender as CheckBox).Checked = true;
            UserToICompareableAdapter.SetScoreStrategy(new AdvanceScoreStrategy());
        }
    }
}