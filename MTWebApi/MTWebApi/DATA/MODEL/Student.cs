using System.ComponentModel.DataAnnotations;

namespace MTWebApi.DATA.MODEL
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength (20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength (20)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }  
        public ICollection <Lector> Lector { get; set; }

    }
}
