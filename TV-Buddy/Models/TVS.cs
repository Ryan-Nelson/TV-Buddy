using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TV_Buddy.Models
{
    public class TVS
    {
        [Key]
        public int TVSId { get; set; }

        [Required]
        [Display(Name = "What Is the Brand Name")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "What Is the ModelNumber of the TV")]
        public int ModelNumber { get; set; }

        [Required]
        [Display(Name = "What Is the SerialNumber of the TV")]
        public int SerialNumber { get; set; }

        [Required]
        [Display(Name = "What Is the Size of the TV in Inch")]
        public int Size { get; set; }

        [Required]
        [Display(Name = "Is the Tv 1080 or 4k")]
        public int Quality { get; set; }

        [Required]
        [Display(Name = "does the Tv have HDR")]
        public bool HDR { get; set; }

        [Required]
        [Display(Name = "does the Tv have OLED")]
        public bool OLED { get; set; }

        [Required]
        [Display(Name = "does the Tv have QLED")]
        public bool QLED { get; set; }

        [Required]
        [Display(Name = "does the Tv have LED")]
        public bool LED { get; set; }

        [Required]
        [Display(Name = "What Is the ContrastLevels of the TV")]
        public int ContrastLevels { get; set; }

        [Required]
        [Display(Name = "What Is the Price of the TV")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "What is the Tvs Refresh Rate")]
        public int Hrz { get; set; }

        [Required]
        [Display(Name = "What is the Tvs BitRate")]
        public int BitRate { get; set; }

    }
}

