using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    class Settings
    {
        public static int Score { get; set; }
        public static int HighScore { get; set; }
        public static int Points { get; set; }

        public Settings()
        {
            Score = 0;
            Points = 5;
        }
    }

    

}
