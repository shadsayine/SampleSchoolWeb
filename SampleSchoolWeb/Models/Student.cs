using System.ComponentModel.DataAnnotations;

namespace SampleSchoolWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set;  }

        public string Address { get; set; }
    }
}
