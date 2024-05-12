using KGT.Data.Models.DogTrainings;
using System;
using System.Collections.Generic;

namespace KGT.Data.Models.Trainings
{
    public class Training : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string? Address { get; set; }
        public string? Notes { get; set; }
        public string? Weather { get; set; }
        public IList<DogTrainingBasicInfo>? DogTrainings { get; set; }
    }
}