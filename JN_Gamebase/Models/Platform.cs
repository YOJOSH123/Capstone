using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace JN_Gamebase.Models
{
    public class Platform
    {
        [Required]
        public int PlatformID { get; set; }

        [Required]
        public int GameID { get; set; }

        [Required, StringLength(50)]
        public String PlatformName { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        [Display(Name = "Original Release Date")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public String Feedback { get; set; }
    }
}
