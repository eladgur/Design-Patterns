using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.ActiveFriend.FactorsFactories
{
    public interface IScoreFactorFactory
    {
        eScoreFactor Make(string i_FactorName);
    }
}
