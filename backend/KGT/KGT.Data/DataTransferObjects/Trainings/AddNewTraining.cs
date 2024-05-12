using System;

namespace KGT.Data.DataTransferObjects.Trainings
{
    public class AddNewTraining
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string? Address { get; set; }
        public string? Notes { get; set; }
        public string? Weather { get; set; }
    }
}