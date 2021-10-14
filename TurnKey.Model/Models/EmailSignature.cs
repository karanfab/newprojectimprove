using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnKey.Model.Models
{
  public class EmailSignature
    {
        [Display(Name = "Select dynamic field :")]
        public string DynamicField { get; set; }
        [Display(Name = "Select Image :")]
        public string Image { get; set; }
        [Display(Name = "Signature Template")]
        public string SignatureTemplate { get; set; }
    }
}
