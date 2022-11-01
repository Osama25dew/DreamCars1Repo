using DreamCars1.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DreamCars1.Pages
{
    public class CarListModel : PageModel
    {
        public IEnumerable<Car> Cars { get; private set; }
        public Services.JsonCarFile CarService;
        private readonly ILogger<CarListModel> _logger;

        public CarListModel(ILogger<CarListModel> logger, Services.JsonCarFile carService)
        {
            _logger = logger;
            CarService = carService;
        }

       

        public void OnGet()
        {
            Cars = CarService.getCarsData();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
