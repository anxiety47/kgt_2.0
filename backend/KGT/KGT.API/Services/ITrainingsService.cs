using KGT.Data.DataTransferObjects.Trainings;

namespace KGT.API.Services
{
    public interface ITrainingsService
    {
        public Task<List<TrainingBasicInfo>> GetAllTrainingsBasicInfo();
        public Task<TrainingDetails> GetTrainingDetails(Guid id);
        public Task<TrainingDetails> AddTraining(AddNewTraining newTraining);
    }
}
