using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AddCustomerForm
    {
        [Required]
        [Display(Name = "Customer Name")]
        public string name { get; set; }

        [EmailAddress]
        [Display(Name = "Customer Email")]
        public string email { get; set; }

        [RegularExpression("^([569]\\d{7})$", ErrorMessage ="Invalid phone number. please enter an kuwait phone number")]
        [Display(Name = "Customer Phone number")]
        public string phone { get; set; }

        [Required]
        [Display(Name = "Customer Country")]
        public string country { get; set; }

        //[DataType(DataType.Date)]
        //[Display(Name = "Date of Birth")]
        //public DateOnly Dob { get; set; }
    }
}
