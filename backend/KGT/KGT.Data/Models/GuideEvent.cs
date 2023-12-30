using System;

namespace KGT.Data.Models
{
    public class GuideEvent
    {
        public int GuideId { get; set; }
        public virtual Guide Guide { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}

