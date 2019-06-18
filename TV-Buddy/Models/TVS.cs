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
        public string Brand { get; set; }

        [Required]
        public int ModelNumber { get; set; }

        [Required]
        public int SerialNumber { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int Quality { get; set; }

        [Required]
        public bool HDR { get; set; }

        [Required]
        public bool OLED { get; set; }

        [Required]
        public bool QLED { get; set; }

        [Required]
        public bool LED { get; set; }

        [Required]
        public int ContrastLevels { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Hrz { get; set; }

        [Required]
        public int BitRate { get; set; }

    }
}

