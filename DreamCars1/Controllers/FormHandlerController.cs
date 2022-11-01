using DreamCars1.Models;
using DreamCars1.Pages;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DreamCars1.Controllers
{
    [Route("[controller")]
    public class FormHandlerController : Controller
    {
        JsonCarFile CarService;
        FormHandlerController(JsonCarFile carService)
        {
            this.CarService = carService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Car obj = new Car();
            obj.carId = id;
            obj.name = name;
            obj.image = image;
            IEnumerable<Car> carsData=CarService.getCarsData();
            List<Car>listOfCars =carsData.ToList();
            listOfCars.Add(obj);
            return JsonSerializer.Serialize<List<Car>>(listOfCars);
        }
    }
}
