using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatlleSim
{
    class Player
    {
        #region private variables
        private string name;
        private int health;
        private int maxHealth = 100;
        private int maxAttack = 30;
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

        public int MaxHealth
        {
            set { maxHealth = value; }
        }

        public int MaxAttack
        {
            set { maxAttack = value; }
        }
        #endregion

        public Player(string nm)
        {
            name = nm;
            health = maxHealth;
        }

        public void IncreaseMaxAttack(int aIncrease)
        {
            maxAttack = maxAttack + aIncrease;
        }

        public void IncreaseMaxHealth(int aIncrease)
        {
            maxHealth = maxHealth + aIncrease;
        }

        public void TakeDamege(int Damege)
        {
            health = health - Damege;

            if (health <= 0)
            {
                //Dead
            }
        }

        public void Heal(int healing)
        {
            health = health + healing;

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
}
