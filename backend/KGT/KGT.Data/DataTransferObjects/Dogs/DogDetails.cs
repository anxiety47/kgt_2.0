using System;
using System.Collections.Generic;
using KGT.Data.DataTransferObjects.DogTrainings;

namespace KGT.Data.DataTransferObjects.Dogs
{
    public class DogDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Notes { get; set; }
        public string PhotoBlobUrl { get; set; }
        public IdNameModel GuideIdAndName { get; set; }
        public List<DogTrainingBasicInfo> Trainings { get; set; }
        public List<DogEventBasicInfo> Events { get; set; }
        public List<DogCertificateBasicInfo> Certificates { get; set; }
    }
}