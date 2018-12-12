using System.ComponentModel.DataAnnotations;


namespace DesignHome.Models
{
    public class Room
    {
        [Required]
        public virtual ApplicationUser User { get; set; }
        [Key]
        public int RoomId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        public string Style { get; set; }

    }
}