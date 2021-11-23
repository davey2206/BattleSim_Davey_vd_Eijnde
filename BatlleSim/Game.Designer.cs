
namespace BatlleSim
{
    partial class Game
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
            this.AttackBtn.Location = new System.Drawing.Point(249, 259);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(75, 23);
            this.AttackBtn.TabIndex = 2;
            this.AttackBtn.Text = "Attack";
            this.AttackBtn.UseVisualStyleBackColor = true;
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
            this.textBox.Location = new System.Drawing.Point(249, 328);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(303, 110);
            this.textBox.TabIndex = 3;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.AttackBtn);
            this.Controls.Add(this.pictureBoxEnemey);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Name = "Game";
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
    }
}