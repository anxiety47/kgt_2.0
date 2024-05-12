using System;

namespace KGT.Data.Models.DogTrainings
{
    public class DogTrainingBasicInfo
    {
        public Guid DogTrainingId { get; set; }
        public string DogName { get; set; }
        public string Info { get; set; }
        public string GuideName { get; set; }
        public string LostPersonName { get; set; }

    }
}
