using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace JN_Gamebase.Models
{
    public class TroubleTicket
    {
        [Required]
        public int TicketID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int GameID { get; set; }

        [Required]
        public int PlatformID { get; set; }

        [Required, StringLength(50)]
        public String Email { get; set; }

        [Required, StringLength(50)]
        public String Subject { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        [Display(Name = "Original Date Added")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime TicketDate { get; set; }

        public String Feedback { get; set; }
    }
}
