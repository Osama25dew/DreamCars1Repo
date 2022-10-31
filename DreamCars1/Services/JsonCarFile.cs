using DreamCars1.Models;
using System.Text.Json;

namespace DreamCars1.Services
{
    public class JsonCarFile
    {
        public JsonCarFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "dreamCars1.json");
            }
        }
        public IEnumerable<Car> getCarsData() //IEnumerable ham ne is liye use kiya bcz hamare pas Car ka single record ni multipple record aye ga
        {
            using(var jsonFile = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Car[]>(jsonFile.ReadToEnd()); 
            }
        }
    }
}
