using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatlleSim
{
    public partial class GameForm : Form
    {
        Player player;
        Enemy enemy;
        Game game = new Game();
        public GameForm(string name)
        {
            InitializeComponent();

            player = game.Player;
            player.Name = name;
            labelPlayer.Text = player.ToString();

            game.CreateEnemy();
            enemy = game.Enemy;
            pictureBoxEnemey.Image = enemy.Picture;
            labelEnemy.Text = enemy.ToString();
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            string attack = game.PlayerAttack();
            textBox.Text = attack;
            if (attack.Contains("beaten"))
            {
                enemy = game.Enemy;
                pictureBoxEnemey.Image = enemy.Picture;
                ScoreLb.Text = game.Score.ToString();
            }
            else
            {
                AttackBtn.Enabled = false;
                SkillBtn.Enabled = false;
                NextBtn.Enabled = true;
            }
            labelEnemy.Text = enemy.ToString();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            string attack = game.EnemyAttack();
            labelPlayer.Text = player.ToString();
            textBox.Text = attack;
            if (attack == "GAME OVER")
            {
                AttackBtn.Enabled = false;
                SkillBtn.Enabled = false;
                NextBtn.Enabled = false;
            }
            else
            {
                AttackBtn.Enabled = true;
                SkillBtn.Enabled = true;
                NextBtn.Enabled = false;
            }
        }

        private void SkillBtn_Click(object sender, EventArgs e)
        {
            AttackBtn.Visible = false;
            SkillBtn.Visible = false;
            BackBtn.Visible = true;
            FocusBtn.Visible = true;
            HealBtn.Visible = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AttackBtn.Visible = true;
            SkillBtn.Visible = true;
            BackBtn.Visible = false;
            FocusBtn.Visible = false;
            HealBtn.Visible = false;
        }

        private void FocusBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = game.FocusSkill();

            AttackBtn.Visible = true;
            SkillBtn.Visible = true;
            BackBtn.Visible = false;
            FocusBtn.Visible = false;
            HealBtn.Visible = false;

            AttackBtn.Enabled = false;
            SkillBtn.Enabled = false;
            NextBtn.Enabled = true;
        }

        private void HealBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = game.HealSkill();
            labelPlayer.Text = player.ToString();

            AttackBtn.Visible = true;
            SkillBtn.Visible = true;
            BackBtn.Visible = false;
            FocusBtn.Visible = false;
            HealBtn.Visible = false;

            AttackBtn.Enabled = false;
            SkillBtn.Enabled = false;
            NextBtn.Enabled = true;
        }
    }
}
