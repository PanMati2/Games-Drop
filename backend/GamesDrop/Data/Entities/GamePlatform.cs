using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class GamePlatform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OperatingSystemId { get; set; }

        public IEnumerable<Game> Games { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
    }
}