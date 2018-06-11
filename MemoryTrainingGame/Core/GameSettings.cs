using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Core
{
    /// <summary>
    /// Свойтва настроеек
    /// </summary>
    public static class GameSettings
    {
        public static int MaxShownValue { get; set; } = 8;

        public static int ShowIntervalSecond { get; set; } = 1;

        public static int StartRangeValue { get; set; } = 1;

        public static int MinTrueAnswerForNextLvl { get; set; } = 3;
    }
}
