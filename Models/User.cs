using System;
using System.ComponentModel.DataAnnotations;

namespace Solution.Models
{
    public class User : Base
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public DateTime CreateDateTime { get; set; }

        [Required]
        public string Location { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
    }
}