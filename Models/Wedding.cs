using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        
        [Required]
        public string SpouseOne { get; set; }
        
        [Required]
        public string SpouseTwo { get; set; }
        
        [Required]
        [FutureDateAttibute]
        public DateTime WeddingDate { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        public DateTime CreatedAt = DateTime.Now;
        
        public DateTime UpdatedAt = DateTime.Now;

        public List<Wedding> Party { get; set; }
        public int UserId { get; set; }
        public User Creator { get; set; }
    }
}

