using System.ComponentModel.DataAnnotations;

namespace MVCDudu.Models
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "DUDU** Please enter your First name")]
        public string Firstname { get; set; }
    }
}
