using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.ActiveFriend
{
    public class AdvanceScoreStrategy : IUserScoreStrategy
    {
        private static readonly Dictionary<eScoreFactor, int> sr_Factors =
            new Dictionary<eScoreFactor, int>()
                {
                    { eScoreFactor.Posts, 10 },
                    { eScoreFactor.Friends, 10 },
                    { eScoreFactor.PhotosTaggedIn, 1 },
                    { eScoreFactor.Statuses, 1 },
                    { eScoreFactor.Videos, 1 },
                    { eScoreFactor.Albums, 1 }
                };

        public int GetScore(User i_User, List<eScoreFactor> i_ChosenScoreFactors)
        {
            int score = 0;

            try
            {
                score = i_User.Posts.Count * sr_Factors[eScoreFactor.Posts] * (i_ChosenScoreFactors.Contains(eScoreFactor.Posts) ? 1 : 0);
                score += i_User.Albums.Count * sr_Factors[eScoreFactor.Albums] * (i_ChosenScoreFactors.Contains(eScoreFactor.Albums) ? 1 : 0);
                score += i_User.Friends.Count * sr_Factors[eScoreFactor.Friends] * (i_ChosenScoreFactors.Contains(eScoreFactor.Friends) ? 1 : 0);
                score += i_User.PhotosTaggedIn.Count * sr_Factors[eScoreFactor.PhotosTaggedIn] * (i_ChosenScoreFactors.Contains(eScoreFactor.PhotosTaggedIn) ? 1 : 0);
                score += i_User.Videos.Count * sr_Factors[eScoreFactor.Videos] * (i_ChosenScoreFactors.Contains(eScoreFactor.Videos) ? 1 : 0);
            }
            catch (Facebook.WebExceptionWrapper)
            {
                // No Facebook permitions ...
            }

            return score;
        }
    }
}
