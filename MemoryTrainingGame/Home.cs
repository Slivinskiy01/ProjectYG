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
        public Home()
        {
            InitializeComponent();
        }


        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            Game _game = new Game();
            _game.ShowDialog();
        }
        
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Settings _settings = new Settings();
            _settings.ShowDialog();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            HelpForm _help = new HelpForm();
            _help.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
