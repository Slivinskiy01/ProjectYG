using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Core
{
    public class GameInit
    {
        /// <summary>
        /// Инициализация сохраненых настроек
        /// </summary>
        public GameInit()
        {
            string _MaxShownValue = Properties.Settings.Default["MaxShownValue"].ToString();
            string _ShowIntervalSecond = Properties.Settings.Default["ShowIntervalSecond"].ToString();
            string _MinTrueAnswerForNextLvl = Properties.Settings.Default["MinTrueAnswerForNextLvl"].ToString();
            
            if(!string.IsNullOrEmpty(_MaxShownValue))
                GameSettings.MaxShownValue = int.Parse(_MaxShownValue);
            if(!string.IsNullOrEmpty(_ShowIntervalSecond))
                GameSettings.ShowIntervalSecond = int.Parse(_ShowIntervalSecond);
            if(!string.IsNullOrEmpty(_MinTrueAnswerForNextLvl))
                GameSettings.MinTrueAnswerForNextLvl = int.Parse(_MinTrueAnswerForNextLvl);
        }
    }
}
