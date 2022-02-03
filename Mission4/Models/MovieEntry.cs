using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieEntry
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        //foreign key relationship below for category
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required (ErrorMessage = "Please enter a movie Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a valid year.")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Please enter a Director First Name.")]
        public string DirectorFirstName { get; set; }
        [Required(ErrorMessage = "Please enter a Director Last Name.")]
        public string DirectorLastName { get; set; }
        [Required(ErrorMessage = "Please enter a movie rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
//category string
//    title string
//    year number
//    director first name string
//    director last name string
//    rating string use drop down 
//    optional:
//    edited bool yes no true fals
//    lent to
//    notes limit 25 charachters
