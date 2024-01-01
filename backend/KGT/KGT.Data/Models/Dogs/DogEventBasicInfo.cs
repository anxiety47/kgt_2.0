using System;

namespace KGT.Data.Models.Dogs
{
    public class DogEventBasicInfo
    {
        public Guid DogEventId { get; set; }
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string GeneralLocation { get; set; }
        public string LocationDetails { get; set; }
        public bool IsCommercial { get; set; }
        public string LostPerson { get; set; }
    }
}
