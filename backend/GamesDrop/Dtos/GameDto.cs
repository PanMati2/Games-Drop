namespace GamesDrop.Dtos
{
    public class GameDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public int OperatingSystemId { get; set; }
        public string OperatingSystemName { get; set; }
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int PercentDiscount { get; set; }
        public bool Recommended { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public string TrailerUrl { get; set; }
        public int KeysInStock { get; set; }
    }
}