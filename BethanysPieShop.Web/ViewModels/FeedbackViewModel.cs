using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Web.ViewModels
{
    public class FeedbackViewModel
    {   
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name is too long!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100, ErrorMessage = "Name is too long!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Message is required.")]
        [StringLength(500, ErrorMessage = "Message is too long!")]
        public string Message { get; set; }
        [Required]
        public bool ContactMe { get; set; }
    }
}
