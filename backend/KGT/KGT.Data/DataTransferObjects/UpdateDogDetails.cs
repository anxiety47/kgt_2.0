using System;

namespace KGT.Data.DataTransferObjects
{
    public class UpdateDogDetails
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Notes { get; set; }
        public string PhotoBlobUrl { get; set; }
    }
}