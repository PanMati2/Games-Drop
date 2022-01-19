using System.ComponentModel.DataAnnotations;

namespace GamesDrop.Contracts.Requests
{
    public class CreateGameRequest
    {
        [Required] [Range(0, int.MaxValue)] public int CategoryId { get; set; }

        [Required] [Range(0, int.MaxValue)] public int PlatformId { get; set; }

        [Required] public string Title { get; set; }

        [Required] public decimal Price { get; set; }

        [Required] public bool Recommended { get; set; }

        [Required] public string Description { get; set; }

        [Required] public string CoverUrl { get; set; }

        [Required] public string TrailerUrl { get; set; }
    }
}