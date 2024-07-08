using System.ComponentModel.DataAnnotations;

namespace Taxi_Volos.Models
{
    public class SendEmailModel
    {
        [Required]
        public string Fullname { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Comments { get; set; }
    }
}
