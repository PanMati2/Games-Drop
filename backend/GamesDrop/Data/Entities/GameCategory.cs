using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class GameCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Game> Games { get; set; }
    }
}