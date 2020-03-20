using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dto
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get ; set;}
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Password should be between 8 and 4 caractère")]
        public string Password {get ; set;}

    }
}