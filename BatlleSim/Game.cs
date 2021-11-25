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
        public void CreateEnemy()
        {
            int n = rng.Next(1,5);
            switch (n)
            {
                case 1:
                    enemy = new Enemy("slime", 50, 10);
                    break;
                case 2:
                    enemy = new Enemy("King slime", 100, 25);
                    break;
                case 3:
                    enemy = new Enemy("goblin", 75, 20);
                    break;
                case 4:
                    enemy = new Enemy("bendit", 100, 30);
                    break;
                case 5:
                    enemy = new Enemy("demon", 200, 40);
                    break;
            }
        }

        public Enemy GetEnemy()
        {
            return enemy;
        }

        public Player GetPlayer()
        {
            return player;
        }

        public string PlayerAttack()
        {
            int d = player.getAttack();
            if (d == 0)
            {
                return player.Name + " missed";
            }
            else if (d >= (player.MaxAttack - 5))
            {
                return player.Name + " crits the " + enemy.Name + " for " + d.ToString();
            }
            enemy.TakeDamege(d);

            return "the " + enemy.Name +  " takes " + d.ToString() + " damege";
        }

        public string EnemyAttack()
        {
            int d = enemy.getAttack();
            if (d == 0)
            {
                return "the " + enemy.Name + " missed";
            }
            else if (d >= (enemy.MaxAttack - 5))
            {
                return "the " + enemy.Name + " crits " + player.Name + " for " + d.ToString();
            }
            player.TakeDamege(d);

            return player.Name + " takes " + d.ToString() + " damege";
        }

        public string FocusSkill()
        {
            int a = rng.Next(2, 7);
            player.IncreaseMaxAttack(a);

            return player.Name + " focuses and gets " + a + "+ max attack damege";
        }

        public string HealSkill()
        {
            int h = rng.Next(10, 30);
            player.Heal(h);

            return player.Name + " applys first aid healing for " + h + "hp";
        }
    }
}
