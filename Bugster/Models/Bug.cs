using Bugster.Models.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bugster.Models
{
    public enum Status {
        OPEN,
        IN_PROGRESS,
        TESTING,
        CLOSED
    }

    public enum Priority {
        LOWEST,
        LOW,
        MEDIUM,
        HIGH,
        HIGHEST
    }

    public class Bug
    {
        public Bug() {
            Status = Status.OPEN;
            Priority = Priority.MEDIUM;
            DateCreated = DateTime.Now;
        }

        [Key]
        public long Id { get; set; }
        [Required]
        public String Reporter { get; set; }
        public long? ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public String Title { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 3)]
        public String Description { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public Priority Priority { get; set; }
        public long? AssigneeId { get; set; }
        public User Assignee { get; set; }
        [Required]
        [CustomDateValidation]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
