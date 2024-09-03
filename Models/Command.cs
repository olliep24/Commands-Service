﻿using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    public class Command
    {
        [Key]
        [Required]
        public required int Id { get; set; }

        [Required]
        public required string HowTo { get; set; }

        [Required]
        public required string CommandLine { get; set; }

        [Required]
        public required int PlatformId { get; set; }

        public Platform? Platform { get; set; }
    }
}
