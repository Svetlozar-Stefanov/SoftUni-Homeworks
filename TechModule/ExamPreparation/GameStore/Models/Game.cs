﻿using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Game
    {
        public int Id { set; get; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Dlc { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
