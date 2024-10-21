using System;

namespace KGT.Data.DataTransferObjects.DogTrainings
{
    public class DogTrainingBasicInfo
    {
        public Guid Id { get; set; }
        public required string Location { get; set; }
        public string? Address { get; set; }
        public string? LostPerson { get; set; }
        public string? GuideName { get; set; }
        public required string DogName { get; set; }
    }
}
