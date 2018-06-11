using MemoryTrainingGame.Core;
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
            GameInit init = new GameInit();
        }

        /// <summary>
        /// Запуск Игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            Game _game = new Game();
            _game.ShowDialog();
        }
        /// <summary>
        /// Запуск надстроеек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Settings _settings = new Settings();
            _settings.ShowDialog();
        }
        /// <summary>
        /// Запуск окна с справкой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            HelpForm _help = new HelpForm();
            _help.ShowDialog();
        }
        /// <summary>
        /// Запуск игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game _game = new Game();
            _game.ShowDialog();
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Запуск надстроеек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings _settings = new Settings();
            _settings.ShowDialog();
        }
        /// <summary>
        /// About Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm _help = new HelpForm();
            _help.ShowDialog();
        }
        /// <summary>
        /// Метод События закрузки главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Load(object sender, EventArgs e)
        { }
    }
}
