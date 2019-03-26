using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bugster.Models {

    public enum Role {
        MANAGER,
        FE_DEVELOPER,
        BE_DEVELOPER,
        TESTER
    };

    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 6)]
        public String Username { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 6)]
        public String Password { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public String Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String FullName { get; set; }
        public Role Role { get; set; }
        public ICollection<Bug> Bugs { get; set; }
    }
}
