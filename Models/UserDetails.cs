using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectYogaMed.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            UserDisease = new HashSet<UserDisease>();
        }
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        [Display(Name =" Full Name")]
        public string Username { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Id")]
        public string Useremail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Contact Number")]
        [Required(ErrorMessage ="Phone number required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number")]
        public long  Usercontact { get; set; }
        
        [DataType(DataType.Date)]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName="Date")]
        public DateTime Dob { get; set; }
        public string Userpassword { get; set; }

        public virtual ICollection<UserDisease> UserDisease { get; set; }
    }
}
