using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System;
using Logic.ActiveFriend.FactorsFactories;

namespace Logic.ActiveFriend
{
    public static class ActiveFriendFeatureManager
    {
        public static IScoreFactorFactory ScoreFactorsFactory { get; set; }

        static ActiveFriendFeatureManager()
        {
            ScoreFactorsFactory = new BasicScoreFactorFactory();
        }

        public static List<UserToICompareableAdapter> FetchActiveFriendsList(User i_LoggedInUser, List<string> i_SortingParms, List<User> friendsList)
        {
            List<eScoreFactor> sortParamsList = createSortFactorsList(i_SortingParms);
            List<UserToICompareableAdapter> activeFriendList = createComperableUsersList(friendsList, sortParamsList);

            activeFriendList.Sort();

            return activeFriendList;
        }

        private static List<eScoreFactor> createSortFactorsList(List<string> i_SortingParms)
        {
            List<eScoreFactor> scoreFactorsList = new List<eScoreFactor>(i_SortingParms.Count);

            i_SortingParms.ForEach(new Action<string>(s => scoreFactorsList.Add(ScoreFactorsFactory.Make(s))));

            return scoreFactorsList;
        }

        private static List<UserToICompareableAdapter> createComperableUsersList(List<User> friendsList, List<eScoreFactor> sortParmsList)
        {
            List<UserToICompareableAdapter> activeFriendList = new List<UserToICompareableAdapter>(friendsList.Count);

            foreach (User user in friendsList)
            {
                activeFriendList.Add(new UserToICompareableAdapter(user, sortParmsList));
            }

            return activeFriendList;
        }
    }
}