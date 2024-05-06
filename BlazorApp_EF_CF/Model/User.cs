using System.ComponentModel.DataAnnotations;

namespace BlazorApp_EF_CF.Model
{
    public class User
    {
       
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W]{1,})$", ErrorMessage = "Rossz e-mail.")]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage = "A jelszónak kisbető nagybetű és számot kell tartalmaznia")]
        public string? Password { get; set; }

    }
}
