using System.ComponentModel.DataAnnotations;

namespace Friends.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}