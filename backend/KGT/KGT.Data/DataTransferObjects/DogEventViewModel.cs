﻿using System;
using System.Collections.Generic;
using KGT.Data.DataTransferObjects.Dogs;

namespace KGT.Data.DataTransferObjects
{
    public class DogEventViewModel
    {
        public EventModel Event { get; set; }
        public int EventId { get; set; }
        public DogBasicInfo Dog { get; set; }
        public int DogId { get; set; }
        public string LostPerson { get; set; }
        public string DogTrackFilename { get; set; }
        public string LostPersonTrackFilename { get; set; }
        public List<Trkpt> DogTrackPoints { get; set; }
        public List<Trkpt> LostPersonTrackPoints { get; set; }
        public DateTime TimeOfLostPersonStart { get; set; }
        public DateTime TimeOfDogStart { get; set; }
        public TimeSpan Duration { get; set; }
        public double LostPersonTrackLength { get; set; }
        public double DogTrackLength { get; set; }
        public string Notes { get; set; }
        public string Goal { get; set; }
        public string Weather { get; set; } //overrides entire training's weather if not empty
    }
}
