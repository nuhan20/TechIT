using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TechIT.Models
{
    public class CustomerModel
    {

        [Required]
        [StringLength(30, ErrorMessage = "Please do not enter values over 30 characters")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "Do not enter more then 11 digit")]
        [MinLength(11, ErrorMessage = "Do not enter less then 11 digit")]
        [Display(Name = "Mobile No")]
        public int MobileNo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Your Gender")]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Current Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DOB { get; set; }

        public int Cus_Id { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

   
}