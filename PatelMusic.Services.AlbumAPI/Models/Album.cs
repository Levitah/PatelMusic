using System.ComponentModel.DataAnnotations;

namespace PatelMusic.Services.AlbumAPI.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1), MaxLength(500)]
        public string Name { get; set; }
        [Required]
        [MinLength(1), MaxLength(500)]
        public string Artist { get; set; }
    }
}