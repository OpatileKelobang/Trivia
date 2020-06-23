using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class Settings
    {
        public static int Score { get; set; }
        public static int HighScore { get; set; }

        public Settings()
        {
            Score = 0;
            HighScore = 0;
        }
    }

    

}
