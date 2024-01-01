using System;
using KGT.Data.DataTransferObjects.Dogs;

namespace KGT.Data.DataTransferObjects
{
    public class DogTrainingModel
    {
        public int TrainingId { get; set; }
        public TrainingModel Training { get; set; }
        public int DogId { get; set; }
        public DogBasicInfo Dog { get; set; }
        public string LostPerson { get; set; }
        public string DogTrackBlobUrl { get; set; }
        public string LostPersonTrackBlobUrl { get; set; }
        public string Notes { get; set; }
        public string GroundType { get; set; }
        public string Weather { get; set; }
        public double LostPersonTrackLength { get; set; }
        public TimeSpan DelayTime { get; set; }
        public string AdditionalPictureBlobUrl { get; set; }
    }
}
