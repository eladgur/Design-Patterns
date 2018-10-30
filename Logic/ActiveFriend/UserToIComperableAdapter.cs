namespace Logic.ActiveFriend
{
    using System;
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;

    public class UserToICompareableAdapter : IComparable<UserToICompareableAdapter>
    {
        private User m_User;
        private List<eScoreFactor> m_ChosenScoreFactors;
        private static IUserScoreStrategy s_ScoreStrategy = new DefaultScoreStrategy();

        public string Name { get; set; }

        public UserToICompareableAdapter(User i_User, List<eScoreFactor> i_ChosenScoreFactors)
        {
            Name = i_User.Name;
            m_User = i_User;
            m_ChosenScoreFactors = i_ChosenScoreFactors;
        }

        public int CompareTo(UserToICompareableAdapter i_Other)
        {
            return userScore() - i_Other.userScore();
        }

        private int userScore()
        {
            return s_ScoreStrategy.GetScore(m_User, m_ChosenScoreFactors);
        }

        public static void SetScoreStrategy(IUserScoreStrategy i_ScoreStrategy)
        {
            s_ScoreStrategy = i_ScoreStrategy;
        }
    }
}