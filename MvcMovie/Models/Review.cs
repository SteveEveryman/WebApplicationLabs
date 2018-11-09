using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }

        [Required]
        public string Reviewer { get; set; }

        [Required]
        public string UserReview { get; set; }

        [Required]
        public int MovieID { get; set; }

        [Required]
        public string MovieTitle { get; set; }

    }
    }
