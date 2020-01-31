using System.ComponentModel.DataAnnotations;

namespace PhoneGames.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}