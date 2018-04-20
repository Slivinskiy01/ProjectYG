using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
