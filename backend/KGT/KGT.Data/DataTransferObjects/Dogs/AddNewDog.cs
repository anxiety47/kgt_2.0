using System;

namespace KGT.Data.DataTransferObjects.Dogs
{
    public class AddNewDog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Notes { get; set; }
        public string PhotoBlobUrl { get; set; }
        public int GuideId { get; set; }
    }
}