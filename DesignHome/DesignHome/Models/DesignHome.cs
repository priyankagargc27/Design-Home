using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignHome.Models
{
    public class DesignHome
    {
        [Required]
        public virtual ApplicationUser User { get; set; }
        [Key]
        public int DesignHomeId { get; set; }

        [Required]
        public int ContractorId { get; set; }

        [Required]
        public int RoomId { get; set; }

        public virtual Contractor Contractor { get; set; }

        public virtual Room Room { get; set; }

        public string Description { get; set; }
    }
}