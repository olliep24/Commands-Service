using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public required int Id { get; set; }

        /// <summary>
        /// Primary key of platfrom in platform service.
        /// </summary>
        [Required]
        public required int ExternalId { get; set; }

        [Required]
        public required string Name { get; set; }

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}
