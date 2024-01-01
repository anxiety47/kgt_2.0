using KGT.API.Services;
using KGT.Data.DataTransferObjects.Dogs;
using Microsoft.AspNetCore.Mvc;

namespace KGT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogsController : ControllerBase
    {

        private readonly ILogger<DogsController> _logger;
        private readonly IDogsService _dogsService;

        public DogsController(ILogger<DogsController> logger, IDogsService dogsService)
        {
            _logger = logger;
            _dogsService = dogsService;
        }

        [HttpGet]
        public async Task<List<DogBasicInfo>> GetAll()
        {
            _logger.LogInformation("Getting all dogs");
            return await _dogsService.GetAllDogsBasicInfo();
        }

        [HttpGet("{id}")]
        public async Task<DogDetails> Get(Guid id)
        {
            return await _dogsService.GetDogDetails(id);
        }

        //[HttpPost]
        //public async Task<IActionResult> Add(AddNewDog newDogDetails)
        //{
        //    var id = await _dogsRepository.AddAsync(newDogDetails);
        //    return Ok(id);
        //}

        //[HttpPut]
        //public async Task<IActionResult> Update(UpdateDogDetails updatedDetails)
        //{
        //    await _dogsRepository.UpdateAsync(updatedDetails);
        //    return Ok();
        //}
    }
}