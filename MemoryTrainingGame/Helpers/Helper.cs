using MemoryTrainingGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemoryTrainingGame.Helpers
{
    public static class Helper
    {
        /// <summary>
        /// Мы генерируем целочисленных масив из случайныхб не повторяющихся чисел,
        /// По полученому разряду
        /// </summary>
        /// <param name="range">Разряд</param>
        /// <param name="arrSize">Размер масива</param>
        /// <returns></returns>
        public static int[] GetRandomArrayByRange(int range, int arrSize)
        {
            int min = 1;
            int max = 1;

            for(int i = 0; i < range; i++)
            {
                min *= (i != 0) ? 10 : 1;
                max *= 10;
            }

            var rnd = new Random();
            int[] arr = new int[arrSize];

            for (int i = 0; i < arr.Length; i++)
            {
                var _r = rnd.Next(min, max);
                if (!(arr.Contains(_r)))
                {
                    arr[i] = _r;
                }
                else
                {
                    i--;
                }
            }

            return arr;
        }

        /*
        /// <summary>
        /// Метод для замены ключевых фраз в MS WOrd
        /// </summary>
        /// <param name="stubToReplace"></param>
        /// <param name="text"></param>
        /// <param name="WordDocument"></param>
        private static void ReplaceWordSub(string stubToReplace, string text, Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        /// <summary>
        /// To Do Report Word
        /// </summary>
        /// <param name="filenameSave"></param>
        /// <param name="score"></param>
        /// /
        
        public static void GenerateResultDoc(string filenameSave, ResultForm.Score score)
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;
            var doc = app.Documents.Open(Environment.CurrentDirectory + @"\Save.docx");
            try
            {
                ReplaceWordSub("{Name}", score._User.Name, doc);
                ReplaceWordSub("{score}", score.score.ToString(), doc);
                object start = 0;
                object end = 0;
                Range tableLocation = doc.Range(ref start, ref end);
                int maxI = score._User.Scores.Count;
                int maxJ = score._User.Scores.FirstOrDefault().ShownValues.Count;
                doc.Tables.Add(tableLocation, maxJ, maxI);
                doc.SaveAs(filenameSave);
                doc.Close();
                MessageBox.Show("Файл сгенерирован", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении Word", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doc.Close();
            }
        }
        */
    }
}
