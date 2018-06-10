using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MemoryTrainingGame.Model;

namespace MemoryTrainingGame
{
    public partial class ResultForm : Form
    {
        public UserModel _user;

        public Score _score;

        public ResultForm()
        {
            InitializeComponent();
        }

        int maxI;
        int maxJ;
        /// <summary>
        /// Перегруженный конструктор 
        /// Формы для показа результатов
        /// </summary>
        /// <param name="user"></param>
        /// <param name="score"></param>
        /// <param name="lvl"></param>
        public ResultForm(UserModel user, int? score, int? lvl)
        {
            InitializeComponent();
            _user = user;

            // инициализация глобализации
            _score = new Score()
            {
                _User = user,
                score = score ?? 0,
                lvl = lvl ?? 0
            };

            textBox1.Text = _user.Name;

            if(_user.Scores != null && _user.Scores.Count > 0)
            {
                maxI = _user.Scores.Count;
                maxJ = _user.Scores.FirstOrDefault().ShownValues.Count;

                dataGridView2.RowCount = maxI;
                dataGridView2.ColumnCount = maxJ;
                dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;

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

        /// <summary>
        /// Метод сохранения полученных результатов в Word
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void SaveResultBtn_Click(object sender, EventArgs e)
        {
            // Обработка исключенний
            try
            {
                saveFileDialog1.Filter = "Document | *.txt|Document | *.doc";
                saveFileDialog1.DefaultExt = "txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string path = saveFileDialog1.FileName;
            

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();

                    using (TextWriter tw = new StreamWriter(path))
                    {
                        tw.WriteLine("Отчет по прохождению теста: \"Тренажер Памяти\"");
                        tw.WriteLine("");
                        tw.WriteLine(string.Format("Имя: {0}",_user.Name));
                        tw.WriteLine(string.Format("Счет: {0}", _score.score));
                        tw.WriteLine(string.Format("Максимальный уровень: {0}", _score.lvl));

                        tw.WriteLine("");
                        tw.WriteLine("");

                        tw.WriteLine("Таблица с показаными значениями:");

                        for (int i = 0; i < maxI; i++)
                        {
                            tw.WriteLine("");
                            for (int j = 0; j < maxJ; j++)
                            {
                                var _n = _user.Scores[i].ShownValues[j];
                                tw.Write(string.Format(" {0} |",_n.ToString()));
                            }
                        }

                        tw.WriteLine("");
                        tw.WriteLine("");
                        tw.WriteLine("Таблица с правельными ответами:");

                        for (int i = 0; i < maxI; i++)
                        {
                            tw.WriteLine("");
                            for (int j = 0; j < maxJ; j++)
                            {
                                var _n = _user.Scores[i].ShownValues[j];
                                if (_user.Scores[i].MemorizedValues.Contains(_n))
                                {
                                    tw.Write(string.Format(" {0} |", _n.ToString()));
                                }
                                else
                                {
                                    tw.Write(" - |");
                                }
                            }
                        }

                        tw.Close();
                        MessageBox.Show("Файл сохранен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Модель которая содержит , пользователя, и его счет
        /// </summary>
        public class Score
        {
            public UserModel _User { get; set; }

            public int score { get; set; }

            public int lvl { get; set; }
        }
    }
}
