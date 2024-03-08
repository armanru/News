using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string UserName{ get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public int Password { get; set; }
    }
}
