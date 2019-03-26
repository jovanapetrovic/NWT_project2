using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bugster.Models
{
    public class Project
    {   
        [Key]
        public long Id { get; set; }
        [Required]
        public long CreatorId { get; set; }
        public User Creator { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public String Name { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public String Description { get; set; }
        public ICollection<Bug> Bugs { get; set; }
    }
}
