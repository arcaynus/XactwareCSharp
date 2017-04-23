using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_Properties
{
    class Player
    {
        private int _score;
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                if (_score < 0)
                {
                    Score = 0;
                }
            }
        }
        private int Score2 { get; set; }
        public Guid PlayerID { get; } = new Guid(); // One way to set the default value of immutable property

        public Player()
        {
            PlayerID = new Guid();  // Another way to se the default value of an immutable property *Overwrites above
        }
        public string Name { get; set; }
    }
}
