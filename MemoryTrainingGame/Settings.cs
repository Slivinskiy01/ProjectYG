using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MemoryTrainingGame.Core;

namespace MemoryTrainingGame
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = GameSettings.MaxShownValue.ToString();

            textBox2.Text = GameSettings.ShowIntervalSecond.ToString();

            textBox3.Text = GameSettings.MinTrueAnswerForNextLvl.ToString();
        }

        private void SaveSettingBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["MaxShownValue"] = textBox1.Text;
            Properties.Settings.Default["ShowIntervalSecond"] = textBox2.Text;
            Properties.Settings.Default["MinTrueAnswerForNextLvl"] = textBox3.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Настройки Сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Validation if object is TextBox & if is value parse to int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        private bool ValidationObjectTextToInt(object obj)
        {
            try {
                var _ob = (TextBox)obj;
                int _a;

                if (!string.IsNullOrEmpty(_ob.Text)) {
                    if (int.TryParse(_ob.Text, out _a)) {

                        if (_a > 0 && _a < 100) {
                            _ob.ForeColor = Color.Green;
                            return true;
                        }
                    }
                }
                _ob.ForeColor = Color.Red;
            }
            catch { }

            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationObjectTextToInt(sender))
            {
                return;
            }
            GameSettings.MaxShownValue = int.Parse(textBox1.Text);
            
            int _b;

            if(int.TryParse(textBox3.Text,out _b))
            {
                if(_b > int.Parse(textBox1.Text))
                {
                    textBox3.Text = textBox1.Text;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationObjectTextToInt(sender))
            {
                return;
            }
            GameSettings.ShowIntervalSecond = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationObjectTextToInt(sender))
            {
                return;
            }
            GameSettings.MinTrueAnswerForNextLvl = int.Parse(textBox3.Text);

            int _b;

            if (int.TryParse(textBox1.Text, out _b))
            {
                if (_b < int.Parse(textBox3.Text))
                {
                    textBox1.Text = textBox3.Text;
                }
            }
        }
        
        
    }
}
