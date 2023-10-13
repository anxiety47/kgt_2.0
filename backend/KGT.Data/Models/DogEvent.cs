using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KGT.Data.Models
{
    public class DogEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DogEventId { get; set; }
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public string? LostPerson { get; set; }
        public string DogTrackBlobUrl { get; set; }
        public string? LostPersonTrackBlobUrl { get; set; }
        public string? Notes { get; set; }
        public string? Weather { get; set; }
    }
}
