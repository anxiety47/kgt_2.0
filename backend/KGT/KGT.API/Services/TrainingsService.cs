using AutoMapper;
using KGT.Data.CosmosDb;
using KGT.Data.DataTransferObjects.Trainings;
using KGT.Data.Models.Trainings;

namespace KGT.API.Services
{
    public class TrainingsService : ITrainingsService
    {
        private readonly ITrainingsRepository _trainingsRepository;
        private readonly IMapper _mapper;


        public TrainingsService(ITrainingsRepository trainingsRepository, IMapper mapper)
        {
            _trainingsRepository = trainingsRepository;
            _mapper = mapper;
        }

        public async Task<TrainingDetails> AddTraining(AddNewTraining newTraining)
        {
            var training = _mapper.Map<AddNewTraining, Training>(newTraining);
            training.Id = Guid.NewGuid();
            var createdTraining = await _trainingsRepository.CreateTrainingAsync(training);
            TrainingDetails trainingDetails = _mapper.Map<Training, TrainingDetails>(createdTraining);

            return trainingDetails;
        }

        public async Task<List<TrainingBasicInfo>> GetAllTrainingsBasicInfo()
        {
            var trainings = (await _trainingsRepository.GetTrainingsAsync()).ToList();
            List<TrainingBasicInfo> trainingsBasicInfoList = _mapper.Map<List<Training>, List<TrainingBasicInfo>>(trainings);
            return trainingsBasicInfoList;
        }

        public async Task<TrainingDetails> GetTrainingDetails(Guid id)
        {
            var training = await _trainingsRepository.GetTrainingAsync(id);
            TrainingDetails trainingDetails = _mapper.Map<Training, TrainingDetails>(training);
            return trainingDetails;
        }
    }
}
