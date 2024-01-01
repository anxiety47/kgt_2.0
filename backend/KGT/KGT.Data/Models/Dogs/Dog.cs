using KGT.Data.Repositories;
using System;
using System.Collections.Generic;

namespace KGT.Data.Models.Dogs
{
    public class Dog : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhotoBlobUrl { get; set; }
        public string Notes { get; set; }
        public DogGuideBasicInfo GuideDetails { get; set; }
        public IList<DogTrainingBasicInfo> DogTrainings { get; set; }
        public IList<DogEventBasicInfo> DogEvents { get; set; }
        public List<DogCertificateBasicInfo> DogCertificates { get; set; }
    }
}
