using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Helper
{
    /// <summary>
    /// Методы расширения
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Метод расширения, для определения
        /// содержания числа в масиве
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool Contains(this int[] arr, int a)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a) return true;
            }
            return false;
        }
    }
}
