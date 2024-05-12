using System;

namespace KGT.Data.DataTransferObjects.Trainings
{
    public class TrainingBasicInfo
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string? Address { get; set; }
    }
}
