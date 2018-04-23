using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Model
{
    public class DataContext
    {
        // TODO : Connection to DB [if is need]
        public DataContext()
        {

        }

        public List<UserModel> Users { get; set; }

        public List<ScoreModel> Scores { get; set; }
    }
}
