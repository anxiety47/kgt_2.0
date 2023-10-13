using System;
using System.Collections.Generic;

namespace KGT.Data.DataTransferObjects
{
    public class EventModel
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string StreetOrLocation { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsCommercialTraining { get; set; }
        public List<int> GuideIds { get; set; }
        public List<int> DogIds { get; set; }
    }
}
