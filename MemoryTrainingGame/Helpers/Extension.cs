using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Helper
{
    public static class Extension
    {
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
