﻿
namespace BatlleSim
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemey = new System.Windows.Forms.PictureBox();
            this.AttackBtn = new System.Windows.Forms.Button();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SkillBtn = new System.Windows.Forms.Button();
            this.HealBtn = new System.Windows.Forms.Button();
            this.FocusBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemey)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(230, 271);
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxEnemey
            // 
            this.pictureBoxEnemey.Location = new System.Drawing.Point(558, 12);
            this.pictureBoxEnemey.Name = "pictureBoxEnemey";
            this.pictureBoxEnemey.Size = new System.Drawing.Size(230, 271);
            this.pictureBoxEnemey.TabIndex = 1;
            this.pictureBoxEnemey.TabStop = false;
            // 
            // AttackBtn
            // 
            this.AttackBtn.Location = new System.Drawing.Point(248, 231);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(60, 50);
            this.AttackBtn.TabIndex = 2;
            this.AttackBtn.Text = "Attack";
            this.AttackBtn.UseVisualStyleBackColor = true;
            this.AttackBtn.Click += new System.EventHandler(this.AttackBtn_Click);
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Location = new System.Drawing.Point(555, 290);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(35, 13);
            this.labelEnemy.TabIndex = 5;
            this.labelEnemy.Text = "label2";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(9, 290);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer.TabIndex = 6;
            this.labelPlayer.Text = "label1";
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 358);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(710, 49);
            this.textBox.TabIndex = 3;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(728, 357);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(60, 50);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // SkillBtn
            // 
            this.SkillBtn.Location = new System.Drawing.Point(248, 175);
            this.SkillBtn.Name = "SkillBtn";
            this.SkillBtn.Size = new System.Drawing.Size(60, 50);
            this.SkillBtn.TabIndex = 8;
            this.SkillBtn.Text = "Skill";
            this.SkillBtn.UseVisualStyleBackColor = true;
            this.SkillBtn.Click += new System.EventHandler(this.SkillBtn_Click);
            // 
            // HealBtn
            // 
            this.HealBtn.Location = new System.Drawing.Point(314, 231);
            this.HealBtn.Name = "HealBtn";
            this.HealBtn.Size = new System.Drawing.Size(175, 50);
            this.HealBtn.TabIndex = 9;
            this.HealBtn.Text = "First Aid";
            this.HealBtn.UseVisualStyleBackColor = true;
            this.HealBtn.Visible = false;
            // 
            // FocusBtn
            // 
            this.FocusBtn.Location = new System.Drawing.Point(314, 175);
            this.FocusBtn.Name = "FocusBtn";
            this.FocusBtn.Size = new System.Drawing.Size(175, 50);
            this.FocusBtn.TabIndex = 10;
            this.FocusBtn.Text = "Focus";
            this.FocusBtn.UseVisualStyleBackColor = true;
            this.FocusBtn.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(314, 119);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(175, 50);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.FocusBtn);
            this.Controls.Add(this.HealBtn);
            this.Controls.Add(this.SkillBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.AttackBtn);
            this.Controls.Add(this.pictureBoxEnemey);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxEnemey;
        private System.Windows.Forms.Button AttackBtn;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button SkillBtn;
        private System.Windows.Forms.Button HealBtn;
        private System.Windows.Forms.Button FocusBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}