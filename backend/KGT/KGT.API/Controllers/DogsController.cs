using KGT.Data.DataTransferObjects;
using KGT.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KGT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogsController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDogsRepository _dogsRepository;

        public DogsController(ILogger<WeatherForecastController> logger, IDogsRepository dogsRepository)
        {
            _logger = logger;
            _dogsRepository = dogsRepository;
        }

        [HttpGet]
        public List<DogBasicInfo> GetAll()
        {
            _logger.LogInformation("It works!");
            return _dogsRepository.GetAllDogsBasicInfo();
        }

        [HttpGet("{id}")]
        public async Task<DogDetails> Get(int id)
        {
            return await _dogsRepository.GetDogDetails(id);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddNewDog newDogDetails)
        {
            var id = await _dogsRepository.AddAsync(newDogDetails);
            return Ok(id);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateDogDetails updatedDetails)
        {
            await _dogsRepository.UpdateAsync(updatedDetails);
            return Ok();
        }
    }
}