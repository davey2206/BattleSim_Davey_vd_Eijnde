using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatlleSim
{
    class Enemy
    {
        #region private variables
        private string name;
        private int health;
        private int maxAttack;
        private Random rng = new Random();
        #endregion

        #region public variables
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxAttack
        {
            get { return maxAttack; }
            set { maxAttack = value; }
        }
        #endregion

        public Enemy(string n, int h, int mA)
        {
            name = n;
            health = h;
            maxAttack = mA;
        }

        public void TakeDamege(int Damege)
        {
            health = health - Damege;

            if (health <= 0)
            {
                //Dead
            }
        }

        public int getAttack()
        {
            return rng.Next(0, maxAttack);
        }

        public override string ToString()
        {
            return name + "  |  " + health + " HP";
        }
    }
}
