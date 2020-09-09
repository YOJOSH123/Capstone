using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace JN_Gamebase.Models
{
    public class Reviews
    {
        [Required]
        public int ReviewID { get; set; }

        [Required]
        public int GameID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public float RatingScore { get; set; }

        [Required]
        public string Review { get; set;  }

        public String Feedback { get; set; }
    }
}
