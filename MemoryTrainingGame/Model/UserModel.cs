using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTrainingGame.Model
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ScoreModel> Scores { get; set; }
    }
}
