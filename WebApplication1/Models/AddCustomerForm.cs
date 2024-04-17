using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AddCustomerForm
    {
        [Required]
        public string name {  get; set; }
        [EmailAddress]
        public string email { get; set; }
        [RegularExpression("^([569]\\d{7})$")]
        public string phone { get; set; }
        [Required]
        public string country { get; set; }

    }
}
