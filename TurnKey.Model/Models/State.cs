using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnKey.Model.Models
{
   public class state
    {
        public int id { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public int sort { get; set; }
        public string status { get; set; }
        public string occupied { get; set; }
        public string notes { get; set; }
        public string fips_state { get; set; }
        public string assoc_press { get; set; }
    }
}
