using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Model
{
    /// <summary>
    /// Модель счета
    /// </summary>
    public class ScoreModel
    {
        public int Id { get; set; }

        public int RangeLvl { get; set; }

        public List<int> ShownValues { get; set; }

        public List<int> MemorizedValues { get; set; }
    }
}
