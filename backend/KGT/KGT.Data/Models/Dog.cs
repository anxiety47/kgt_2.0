using KGT.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KGT.Data.Models
{
    public class Dog : IEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Breed { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string? PhotoBlobUrl { get; set; }
        public string? Notes { get; set; }
        [Required]
        public virtual Guide Guide { get; set; }
        public virtual IList<DogTraining>? DogTrainings { get; set; }
        public virtual IList<DogEvent>? DogEvents { get; set; }
        public virtual List<DogCertificate>? DogCertificates { get; set; }
    }
}
