using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Week5CodeChallenge.Models
{
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactInfo
    {
        //not the function you're looking for
    }

    public class ContactFormValidation
    {
        [Required(ErrorMessage="Need valid first name."), Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Need valid last name."), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Need valid email address."), EmailAddress(ErrorMessage="Valid email address required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Need valid company name."), Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Need valid product description."), Display(Name = "Product Description")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Comment Required."), DataType(DataType.MultilineText), MaxLength(144)]
        public string Comment { get; set; }
        [Required(ErrorMessage="Valid phone number required"), Display(Name="Phone Number"), MaxLength(12)]
        public string PhoneNum { get; set; }

    }

}
