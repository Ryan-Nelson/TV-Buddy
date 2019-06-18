using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TV_Buddy.Models
{
    public class TVSInRooms
    {
        [Key]
        public int TVSInRoomsId { get; set; }

        [Required]
        public int TVSId { get; set; }
        public TVS TVS { get; set; }

        [Required]
        public int RoomsId { get; set; }
        public Rooms Rooms { get; set; }
    }
}
