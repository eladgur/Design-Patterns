using Logic.ActiveFriend.FactorsFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.ActiveFriend
{
    public class BasicScoreFactorFactory : IScoreFactorFactory
    {
        public eScoreFactor Make(string i_FactorName)
        {
            eScoreFactor createdObject;

            i_FactorName = i_FactorName.Replace(" ", string.Empty);
            if (string.IsNullOrWhiteSpace(i_FactorName))
            {
                throw new ArgumentNullException("Can't create ScoreFactor from null, please provide score factor name");
            }
            else if (i_FactorName.All(char.IsLetter))
            {
                createdObject = tryParse(i_FactorName);
            }
            else
            {
                throw new ArgumentException("Can't create ScoreFactor from word contain number, please provide score factor name");
            }

            return createdObject;
        }

        private eScoreFactor tryParse(string i_FactorName)
        {
            eScoreFactor createdObject;
            try
            {
                createdObject = (eScoreFactor)Enum.Parse(typeof(eScoreFactor), i_FactorName, true);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException(string.Format("no score factors named: {0} exist", i_FactorName));
            }

            return createdObject;
        }
    }
}
