using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    using Logic.ActiveFriend;
    using FacebookWrapper.ObjectModel;

    public static class MostActiveFriendByDistanceFacade
    {
        public static UserToICompareableAdapter getActiveFriendByDistance(User i_LoggedInUser, int i_ChosenDistance, List<string> sortParamsList)
        {
            List<User> filteredUsersList = FriendsByDistance.FriendsByDistanceFeatureManager.GetFriendsInDistance(i_LoggedInUser, i_ChosenDistance);
            List<UserToICompareableAdapter> activeFriendList = ActiveFriendFeatureManager.FetchActiveFriendsList(i_LoggedInUser, sortParamsList, filteredUsersList);
            UserToICompareableAdapter mostActiveFriend = null;

            if (activeFriendList.Count > 0)
            {
                mostActiveFriend = activeFriendList[0];
            }
            else
            {
                throw new Exception("Can't get most active friend by distance");
            }

            return mostActiveFriend;
        }
    }
}
