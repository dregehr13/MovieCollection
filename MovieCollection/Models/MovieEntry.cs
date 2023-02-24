using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Models
{
    public class MovieEntry
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Movie Title Required")]
        public string Title { get; set; }
        [Required (ErrorMessage ="Movie Year Required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Movie Director Required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Movie Rating Required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25, ErrorMessage = "Notes limited to 25 characters.")]
        public string Notes { get; set; }

        //Build foreign key
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
