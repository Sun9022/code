using System.ComponentModel.DataAnnotations;

namespace Code_First_Approach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public int cls { get; set; }
    }
}
