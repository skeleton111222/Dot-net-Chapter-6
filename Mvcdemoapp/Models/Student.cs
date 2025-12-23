using System.ComponentModel.DataAnnotations;
namespace Mvcdemoapp.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        [Range(1,120)]
        public int Age { get; set; }
    }
}
