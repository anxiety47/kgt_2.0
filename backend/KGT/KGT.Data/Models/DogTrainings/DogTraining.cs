using System;

namespace KGT.Data.Models.DogTrainings
{
    public class DogTraining
    {
        public Guid Id { get; set; }
        public Guid TrainingId { get; set; }
        public Guid DogId { get; set; }
        public DateTime TrainingDate { get; set; }
        public required string Location { get; set; }
        public string? Address { get; set; }
        public string? DogName { get; set; }
        public string? GuideName { get; set; }
        public string? LostPerson { get; set; }
        // so far we used Trkseg, not sure what will be easier to store, this or Gpx?
        public Trkseg? DogTrack { get; set; }
        public Trkseg? LostPersonTrack { get; set; }
        public string? Notes { get; set; }
        public string? Weather { get; set; }
        public string? GroundType { get; set; }
        public Uri? AdditionalPictureBlobUrl { get; set; }

        // TODO should these be calculated upfront and saved or calculated dynamically?
        // public double LostPersonTrackLength { get; set; }
        // public TimeSpan DelayTime { get; set; }
        // public TimeSpan Duration { get; set; }

    }
}
