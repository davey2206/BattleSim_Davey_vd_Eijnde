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

            player = game.GetPlayer();
            player.Name = name;
            labelPlayer.Text = player.ToString();

            game.CreateEnemy();
            enemy = game.GetEnemy();
            labelEnemy.Text = enemy.ToString();
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = game.PlayerAttack();
            labelEnemy.Text = enemy.ToString();
            AttackBtn.Enabled = false;
            SkillBtn.Enabled = false;
            NextBtn.Enabled = true;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = game.EnemyAttack();
            labelPlayer.Text = player.ToString();
            AttackBtn.Enabled = true;
            SkillBtn.Enabled = true;
            NextBtn.Enabled = false;
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
