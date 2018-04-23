using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MemoryTrainingGame.Helpers;
using MemoryTrainingGame.Model;
using MemoryTrainingGame.Core;

namespace MemoryTrainingGame
{
    public partial class Game : Form
    {
        // Init
        public static int _countValue = GameSettings.MaxShownValue;
        public int[] rand = new int[GameSettings.MaxShownValue];
        public int score;

        DataContext DS = new DataContext();
        UserModel User = new UserModel() { Name = "Player", Scores = new List<ScoreModel>() };
        
        int _tCounter;
        int _range = GameSettings.StartRangeValue;

        public Game()
        {
            InitializeComponent();
            timer1.Interval = GameSettings.ShowIntervalSecond * 1000;
            this.Closed += (s, args) => {
                ResultForm result = new ResultForm(User, score, _range);
                result.ShowDialog();
                this.Hide();
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!(_tCounter < GameSettings.MaxShownValue))
            {
                timer1.Stop();
                _tCounter = 0;
                label1.Text = "";
                CheckBtn.Enabled = true;
                checkTextInput.Enabled = true;
                HelperLabel.Visible = true;
            }
            else
            {
                label1.Text = rand[_tCounter].ToString();
                _tCounter++;
            }
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            rand = Helpers.Helper.GetRandomArrayByRange(_range, GameSettings.MaxShownValue);

            timer1.Start();
            StartGameBtn.Enabled = false;
        }
        
        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(checkTextInput.Text))
            {
                throw new Exception("Ошибка, поле пустое");
            }

            var start = new ScoreModel
            {
                ShownValues = rand.ToList<int>(),
                RangeLvl = _range,
                MemorizedValues = new List<int>()
            };

            var _response = checkTextInput.Text.Split(',');
            int r;

            for(int i = 0; i < _response.Length; i++)
            {
                if (int.TryParse(_response[i],out r))
                {
                    if (rand.Contains(r))
                    {
                        score++;
                        start.MemorizedValues.Add(r);
                    }
                }
            }

            if(start.MemorizedValues.Count >=  GameSettings.MinTrueAnswerForNextLvl)
            {
                User.Scores.Add(new ScoreModel() {
                    MemorizedValues = start.MemorizedValues,
                    RangeLvl = start.RangeLvl,
                    ShownValues = start.ShownValues
                });

                _range++;
                StartGameBtn.Enabled = true;
                CheckBtn.Enabled = false;
                checkTextInput.Text = "";
                checkTextInput.Enabled = false;
                HelperLabel.Visible = false;
                ScoreLabelValue.Text = score.ToString();
                LevelLabelValue.Text = _range.ToString();
            }
            else
            {
                User.Scores.Add(new ScoreModel()
                {
                    MemorizedValues = start.MemorizedValues,
                    RangeLvl = start.RangeLvl,
                    ShownValues = start.ShownValues
                });

                ResultForm result = new ResultForm(User,score,_range);
                this.Hide();
                result.Closed += (s, args) => this.Close();
                result.ShowDialog();
            }
        }

        private void checkTextInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
