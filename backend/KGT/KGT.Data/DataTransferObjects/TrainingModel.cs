using System;
using System.Collections.Generic;

namespace KGT.Data.DataTransferObjects
{
    public class TrainingModel
    {
        public int TrainingId { get; set; }
        public DateTime Date { get; set; }
        public List<DogTrainingModel> DogTrainings { get; set; }
        public string GeneralLocation { get; set; }
        public string LocationDetails { get; set; }
        public string Notes { get; set; }
        public string Weather { get; set; }
    }
}
