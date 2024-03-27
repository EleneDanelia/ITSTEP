using System.ComponentModel.DataAnnotations;

namespace MTWebApi.DATA.MODEL
{
    public class Lector
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public int Phone { get; set; }
        public ICollection <Student> Student { get; set; }
    }
}
