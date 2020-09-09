using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace JN_Gamebase.Models
{
    public class User
    {
        [Required]
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public String Email { get; set; }

        [Required, StringLength(50)]
        public String Username { get; set; }

        [Required, StringLength(50)]
        public String Password { get; set; }

        public String Feedback { get; set; }
    }
}
