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
    public partial class Game : Form
    {
        Player player = new Player();
        public Game(string name)
        {
            InitializeComponent();
            player.Name = name;

            labelPlayer.Text = player.ToString();
        }
    }
}
