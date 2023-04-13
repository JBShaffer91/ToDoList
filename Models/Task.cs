using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; } // Allow null value

        public string? Description { get; set; } // Allow null value

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
