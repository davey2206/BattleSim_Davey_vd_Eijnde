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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            string name;
            if (textBoxPlayer.Text == null || textBoxPlayer.Text == "")
            {
                MessageBox.Show("voer een naam in");
            }
            else
            {
                name = textBoxPlayer.Text;
                Game gm = new Game(name);
                gm.Show();
                this.Hide();
            }
        }
    }
}
