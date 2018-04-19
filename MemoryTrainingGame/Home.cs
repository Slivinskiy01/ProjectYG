using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemoryTrainingGame
{
    public partial class Home : Form
    {

        //Intial Form
        Game _game = new Game();
        Settings _settings = new Settings();
        


        public Home()
        {
            InitializeComponent();
        }


        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            _game.Show();
        }
        
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            _settings.Show();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress...","Wooups...");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
