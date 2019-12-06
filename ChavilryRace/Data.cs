using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChavilryRace
{
    abstract class Data
    {
        public static Chevilry[] chevilries = new Chevilry[4];
        public static Gambler[] bettor = new Gambler[3];
        public static Random rand = new Random();
        public static int currentGambler { get; set; }
    }
}
