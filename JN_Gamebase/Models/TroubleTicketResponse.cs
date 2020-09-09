using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JN_Gamebase.Models
{
    public class TroubleTicketResponse
    {
        [Required]
        public int ResponseID { get; set; }

        [Required]
        public int TicketID { get; set; }

        public string Response { get; set; }

        public String Feedback { get; set; }
    }
}
