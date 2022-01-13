using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatlleSim
{
    class Game
    {
        private Player player = new Player();
        private Random rng = new Random();
        private Enemy enemy;
        private int score = 0;
        public void CreateEnemy()
        {
            int n = rng.Next(1,6);
            switch (n)
            {
                case 1:
                    enemy = new Enemy("slime", 50, 10, Properties.Resources.Slime);
                    break;
                case 2:
                    enemy = new Enemy("King slime", 100, 25, Properties.Resources.KingSlime);
                    break;
                case 3:
                    enemy = new Enemy("goblin", 75, 20, Properties.Resources.goblin);
                    break;
                case 4:
                    enemy = new Enemy("goblin king", 100, 30, Properties.Resources.GoblinKing);
                    break;
                case 5:
                    enemy = new Enemy("demon slime", 200, 40, Properties.Resources.DemonSlime);
                    break;
            }
        }

        public int Score
        {
            get { return score; }
        }

        public Enemy Enemy
        {
            get { return enemy; }
        }

        public Player Player
        {
            get { return player; }
        }

        public string PlayerAttack()
        {
            int d = player.getAttack();
            bool dead = enemy.TakeDamage(d);
            if (dead)
            {
                string oldEnemy = enemy.Name;
                CreateEnemy();
                score++;
                return "You have beaten the " + oldEnemy + " and a " + enemy.Name + " appeared";
            }
            if (d == 0)
            {
                return player.Name + " missed";
            }
            else if (d >= (player.MaxAttack - 5))
            {
                return player.Name + " crits the " + enemy.Name + " for " + d.ToString();
            }

            return "the " + enemy.Name +  " takes " + d.ToString() + " damage";
        }

        public string EnemyAttack()
        {
            int d = enemy.getAttack();
            bool dead = player.TakeDamage(d);
            if (dead)
            {
                return "GAME OVER";
            }
            if (d == 0)
            {
                return "the " + enemy.Name + " missed";
            }
            else if (d >= (enemy.MaxAttack - 5))
            {
                return "the " + enemy.Name + " crits " + player.Name + " for " + d.ToString();
            }

            return player.Name + " takes " + d.ToString() + " damage";
        }

        public string FocusSkill()
        {
            int a = rng.Next(2, 7);
            player.IncreaseMaxAttack(a);

            return player.Name + " focuses and gets " + a + "+ max attack damage";
        }

        public string HealSkill()
        {
            int h = rng.Next(10, 30);
            player.Heal(h);

            return player.Name + " applys first aid healing for " + h + "hp";
        }
    }
}
