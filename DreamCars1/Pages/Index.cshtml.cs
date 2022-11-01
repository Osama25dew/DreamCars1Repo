using DreamCars1.Models;
using DreamCars1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamCars1.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Car> Cars { get; private set; }
        public Services.JsonCarFile CarService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, Services.JsonCarFile carService)
        {
            _logger = logger;
            CarService = carService;
        }

        public void OnGet()
        {
            
        }
    }
}