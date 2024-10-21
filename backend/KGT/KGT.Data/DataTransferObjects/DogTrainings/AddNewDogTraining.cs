using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGT.Data.DataTransferObjects.DogTrainings
{
    public class AddNewDogTraining
    {
        public Guid DogId { get; set; }
        // DogName, GuideName, TrainingDate etc to be taken from other CosmosDb containers? 
        public Guid TrainingId { get; set; }
        public string? LostPersonName { get; set; }
        public string? Notes { get; set; }
        public string? Weather { get; set; }
        // TODO what to do with .gpx files that will be sent from frontend? will they be part of this model?
    }
}
