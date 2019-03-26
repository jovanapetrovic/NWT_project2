using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bugster.Models
{
    public class Tag
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public String Name { get; set; }
        [Required]
        public long BugId { get; set; }
        public Bug Bug { get; set; }
    }
}
