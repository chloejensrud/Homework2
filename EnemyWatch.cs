//Written By Chloe Jensrud
//2/5/25


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
    public class EnemyWatch
    {
        //class Variables
        private int x;
        private int y;

        //Gets and sets
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        // constructor
        public EnemyWatch(int aX, int aY)
        {
            this.x = aX;
            this.y = aY;
        }
        
        //Method
        public string CalcDirection()
        {
            {
                if (x < 0 && y > 0)
                    return "The enemy is to the northwest!";
                if (x < 0 && y == 0)
                    return "The enemy is to the west!";
                if (x < 0 && y < 0)
                    return "The enemy is to the southwest!";
                if (x == 0 && y > 0)
                    return "The enemy is to the north!";
                if (x == 0 && y == 0)
                    return "The enemy is here!!";
                if (x == 0 && y < 0)
                    return "The enemy is to the south!";
                if (x > 0 && y > 0)
                    return "The enemy is to the northeast!";
                if (x > 0 && y == 0)
                    return "The enemy is to the east";
                if (x > 0 && y < 0)
                    return "The enemy is to the southeast";
                return "Unknown Direction";
            }
        }

    }

}
