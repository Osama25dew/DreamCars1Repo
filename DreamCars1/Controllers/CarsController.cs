using DreamCars1.Models;
using DreamCars1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamCars1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        JsonCarFile CarService { get; }
        public CarsController(JsonCarFile carService)
        {
            this.CarService = carService;
        }
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return CarService.getCarsData();
        }
    }
}
