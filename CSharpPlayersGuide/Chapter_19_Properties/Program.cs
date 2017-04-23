using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player() { Name = "Andre the Giant", Score = 23 };
            int currentScore = player.Score;
            player.Score = 50;
        }
    }
}
