using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BatlleSim
{
    class Enemy
    {
        #region private variables
        private string name;
        private int health;
        private int maxAttack;
        private Image picture;
        private Random rng = new Random();
        #endregion

        #region public variables
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
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

        public Enemy(string n, int h, int mA, Image p)
        {
            name = n;
            health = h;
            maxAttack = mA;
            picture = p;
        }

        public bool TakeDamege(int Damege)
        {
            health = health - Damege;

            if (health <= 0)
            {
                health = 0;
                return true;
            }
            return false;
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
