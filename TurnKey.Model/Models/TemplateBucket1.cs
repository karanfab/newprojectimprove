using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnKey.Model.Models
{
    public class TemplateBucket1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TemplateBucketName { get; set; }
        public string Description { get; set; }
        //public bool Delete { get; set; }
        //public bool IsActive { get; set; }

    }
}
