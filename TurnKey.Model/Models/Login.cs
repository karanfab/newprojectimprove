using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnKey.Model.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter Your Valid UserName")]
        [Display(Name = "Enter UserName :")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Valid Password")]
        [Display(Name = "Enter Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid UserID { get; set; }
    }
}
