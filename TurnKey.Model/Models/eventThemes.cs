using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnKey.Model.Models
{
   public class eventThemes
    {
        [Key]
        public Guid eventThemeID { get; set; }
        public string eventTheme { get; set; }
    }
}
