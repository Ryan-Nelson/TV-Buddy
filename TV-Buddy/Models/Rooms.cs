using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TV_Buddy.Models
{
    public class Rooms
    {
        [Key]
        public int RoomsId { get; set; }


        [Required]
        [Display(Name = "Enter Room Name")]
        public string RoomName { get; set; }

        [Required]
        [Display(Name = "Enter Wall Height In FT")]
        public int WallHeight { get; set; }

        [Required]
        [Display(Name = "Enter Wall Length In FT")]
        public int WallLength { get; set; }

 
        public ApplicationUser User { get; }

        [Required]
        [Display(Name = "Enter Distance From your seat In FT")]
        public int DistanceFromSeat { get; set; }


        [Required]
        [Display(Name = "Do you have an Xbox One S, Xbox One X")]
        public bool Xbox { get; set; }

        [Required]
        [Display(Name = "Do you have a 4k Blu-ray player")]
        public bool bluray { get; set; }



    }
}
