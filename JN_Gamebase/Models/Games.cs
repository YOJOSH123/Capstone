using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JN_Gamebase.App_Code
{
    public class Games
    {
        [Required]
        public int GameID { get; set; }

        [Required, StringLength(50)]
        public String GameTitle { get; set; }

        [Required, StringLength(50)]
        public String Developer { get; set; }

        [Required]
        [Display(Name = "Original Release Date")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(50)]
        public String Genre { get; set; }

        [Required, StringLength(5)]
        public String ESRB { get; set; }

        [Required]
        public String Descrpition { get; set; }

        [Required]
        [Display(Name = "Original Date Added")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        public String Feedback { get; set; }

        

    }
}
