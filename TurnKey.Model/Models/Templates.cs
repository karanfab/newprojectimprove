using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TurnKey.Model.Models
{
    public class Templates
    {
        [Key]
        public int Id { get; set; }     
        public string Name { get; set; }
        public int Type { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public string? MmsImageUrl { get; set; }
        public int BucketId { get; set; }
    }
}
