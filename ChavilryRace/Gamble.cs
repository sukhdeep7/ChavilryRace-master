using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChavilryRace
{
    class Gamble : Chevilry
    {
        public int BetAmount { get; set; }
        public Gambler gambler { get; set; }
        public int chevilry { get; set; }
        public int rewardMultiplier = 4;

        public int CashOut(int winningChevilry)
        {
            if (winningChevilry == chevilry)
                return BetAmount * rewardMultiplier;
            else
                return (0 - BetAmount);
        }
    }
}
