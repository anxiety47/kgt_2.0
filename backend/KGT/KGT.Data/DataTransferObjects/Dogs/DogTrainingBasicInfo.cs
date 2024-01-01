using System;

namespace KGT.Data.DataTransferObjects.Dogs
{
    public class DogTrainingBasicInfo
    {
        public Guid DogTrainingId { get; set; }
        public Guid TrainingId { get; set; }
        public DateTime Date { get; set; }
        public string GeneralLocation { get; set; }
        public string LocationDetails { get; set; }
        public string LostPerson { get; set; }
    }
}
