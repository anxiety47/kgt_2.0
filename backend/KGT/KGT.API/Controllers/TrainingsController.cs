using KGT.API.Services;
using KGT.Data.DataTransferObjects.Trainings;
using Microsoft.AspNetCore.Mvc;

namespace KGT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingsController : ControllerBase
    {

        private readonly ILogger<TrainingsController> _logger;
        private readonly ITrainingsService _trainingsService;

        public TrainingsController(ILogger<TrainingsController> logger, ITrainingsService trainingsService)
        {
            _logger = logger;
            _trainingsService = trainingsService;
        }

        [HttpGet]
        public async Task<List<TrainingBasicInfo>> GetAll()
        {
            _logger.LogInformation("Getting all trainings");
            return await _trainingsService.GetAllTrainingsBasicInfo();
        }

        [HttpGet("{id}")]
        public async Task<TrainingDetails> Get(Guid id)
        {
            return await _trainingsService.GetTrainingDetails(id);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddNewTraining newTrainingDetails)
        {
            var trainingDetails = await _trainingsService.AddTraining(newTrainingDetails);
            return Ok(trainingDetails);
        }
    }
}