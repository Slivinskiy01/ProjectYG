using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MemoryTrainingGame.Model;

namespace MemoryTrainingGame
{
    public partial class ResultForm : Form
    {
        public UserModel _user;

        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(UserModel user, int? score, int? lvl)
        {
            InitializeComponent();
            _user = user;

            textBox1.Text = _user.Name;

            if(_user.Scores != null && _user.Scores.Count > 0)
            {
                int maxI = _user.Scores.Count;
                int maxJ = _user.Scores.FirstOrDefault().ShownValues.Count;

                dataGridView2.RowCount = maxI;
                dataGridView2.ColumnCount = maxJ;
                dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Transparent;

                for (int i = 0; i < maxI; i++)
                {
                    for(int j = 0; j < maxJ; j++)
                    {
                        var _n = _user.Scores[i].ShownValues[j];

                        if (_user.Scores[i].MemorizedValues.Contains(_n))
                        {
                            dataGridView2[j, i].Style.BackColor = Color.YellowGreen;
                        }
                        dataGridView2[j, i].Value = _n;
                    }
                }
            }

            ScoreValueLabel.Text = $"Ваш счет: {score}";
            lvlValueLabel.Text = $"Уровень: {lvl}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _user.Name = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO:: Save data... 

            MessageBox.Show("In progress...");
        }
    }
}
