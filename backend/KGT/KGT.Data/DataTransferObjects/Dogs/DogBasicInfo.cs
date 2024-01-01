using System;

namespace KGT.Data.DataTransferObjects.Dogs
{
    public class DogBasicInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public IdNameModel GuideIdAndName { get; set; }
    }
}
