using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit5_EnemyFactory
{
    public class BossEnemy: Enemy
    {
        public int ExtraPower
        {
            get { return 42; }
        }
    }
}
