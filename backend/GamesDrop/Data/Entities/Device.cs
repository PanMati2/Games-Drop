using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<OperatingSystem> OperatingSystems { get; set; }
    }
}