using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class OperatingSystem
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Name { get; set; }

        public Device Device { get; set; }
        public IEnumerable<GamePlatform> GamePlatforms { get; set; }
    }
}