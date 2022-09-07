﻿using System.ComponentModel.DataAnnotations;

namespace WebAppDETAug2022.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }
        public int Price { get; set; }
        public int MaxLimit { get; set; }
        
    }
}
