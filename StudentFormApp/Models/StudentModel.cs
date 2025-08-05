using System.ComponentModel.DataAnnotations;

namespace StudentFormApp.Models
{
    public class StudentModel
    {
        [Key]  //Mark this as primary key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Standard { get; set; }

        [Required]
        public int RollNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }
    }
}
