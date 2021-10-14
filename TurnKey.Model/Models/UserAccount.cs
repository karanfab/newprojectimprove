using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnKey.Model.Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        //[NotMapped]
        //public string EncryptedId { get; set; }

        [Required(ErrorMessage = "First name  is required")]
        //[RegularExpression(@"[A-Za-z]+", ErrorMessage = "Alphabets only")]
        // [StringLength(20, MinimumLength = 5, ErrorMessage = "First Name Should be min 5 and max 20 length")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name  is required")]
      //  [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Alphabets only")]
        //  [StringLength(20, MinimumLength = 5, ErrorMessage = "Last Name Should be min 5 and max 20 length")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "User name  is required")]
        // [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "NO Special Characters ,Only Alphabets and Numbers allowed.")]
        // [StringLength(20, MinimumLength = 5, ErrorMessage = "User Name Should be min 5 and max 20 length")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password  is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Combination of Letters, Numbers, Characters and special symbol")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm password is required")]
        // [RegularExpression(@"/[^A-Za-z0-9]+/", ErrorMessage = "Letters and Numbers")]
        [DataType(DataType.Password)]
        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Role Name")]
        [Required(ErrorMessage = "Choose Role name")]
        public Guid RoleID { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        //[RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public Nullable<bool> Status { get; set; }
       
        [DisplayName("NSight Live Email")]
        public string turnkeyEmail { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Alternate Email Address")]
        [DisplayName("Alternate Email ")]
        public string alternateEmail { get; set; }
        public Nullable<bool> Menu_Button { get; set; }
        public Nullable<bool> Accounts { get; set; }
        public Nullable<bool> Events { get; set; }
        public Nullable<bool> Data { get; set; }
        public Nullable<bool> Documents { get; set; }
        public Nullable<bool> Profile { get; set; }
        public Nullable<bool> Logout { get; set; }
        public Nullable<bool> Manage_Accounts { get; set; }
        public Nullable<bool> Manage_Events { get; set; }
        public Nullable<bool> Manage_Data { get; set; }
        public Nullable<bool> Manage_Documents { get; set; }
        public Nullable<bool> My_Profile { get; set; }
        public Nullable<bool> Create_New_Event { get; set; }
        public Nullable<bool> Event_Passcode { get; set; }
        public Nullable<bool> Dealer { get; set; }
        public Nullable<bool> Prospects { get; set; }
        public Nullable<bool> Prospects_Alerts { get; set; }
        public Nullable<bool> Email_Alerts { get; set; }
        public Nullable<bool> SMS_MMS_Alerts { get; set; }
        public Nullable<bool> Select_Prospect { get; set; }
        public Nullable<bool> DeleteProspect { get; set; }
        public Nullable<bool> Bulk_SMS_MMS { get; set; }

        public Nullable<bool> Bulk_Email { get; set; }
        public Nullable<bool> ReturnToDashboard { get; set; }
        public Nullable<bool> AddAProspect { get; set; }
        public Nullable<bool> Pagination { get; set; }
        public Nullable<bool> Send_MMS_SMS { get; set; }
        public Nullable<bool> Compose_Email { get; set; }
        public Nullable<bool> Flag_Resolution { get; set; }
        public Nullable<bool> Prospects_Registered { get; set; }
        public Nullable<bool> Email_Clicks { get; set; }
        public Nullable<bool> Duplication_Prospects { get; set; }
        public Nullable<bool> Prospects_Email_Clicks { get; set; }
        public string EncPassword { get; set; }
    }
}
