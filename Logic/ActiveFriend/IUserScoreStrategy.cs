using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.ActiveFriend
{
    // Functional Interface
    public interface IUserScoreStrategy
    {
        int GetScore(User i_User, List<eScoreFactor> i_ChosenScoreFactors);
    }
}
