using System;
using System.Collections.Generic;

namespace KGT.Data.DataTransferObjects
{
    public class DogModel
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Notes { get; set; }
        public string PhotoBlobUrl { get; set; }
        public IdNameModel GuideIdAndName { get; set; }
        public List<int> TrainingIds { get; set; }
        public List<int> EventIds { get; set; }
        public List<int> CertificateIds { get; set; }

    }
}