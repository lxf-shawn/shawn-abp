using System.ComponentModel.DataAnnotations;

namespace ShawnProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}