using System;

namespace KGT.Data.DataTransferObjects.DogTrainings
{
    public class DogTrainingDetails
    {
        public Guid Id { get; set; }
        public DateTime TrainingDate { get; set; }
        public required string Location { get; set; }
        public string? Address { get; set; }
        public string? DogName { get; set; }
        public string? GuideName { get; set; }
        public string? LostPerson { get; set; }
        public Trkseg? DogTrack { get; set; }
        public Trkseg? LostPersonTrack { get; set; }
        public string? Notes { get; set; }
        public string? Weather { get; set; }
        public string? GroundType { get; set; }
        public Uri? AdditionalPictureBlobUrl { get; set; }
    }
}
