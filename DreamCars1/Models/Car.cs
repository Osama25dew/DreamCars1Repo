using System.Text.Json;
using System.Text.Json.Serialization;

namespace DreamCars1.Models
{
    public class Car
    {
        internal string name;
        internal string image;

        [JsonPropertyName("id")] //if we are using same name in both json and in class...then we dont need to sync jsonpropertyname
        public int carId { get; set; }
       
        [JsonPropertyName("name")]
        public string carName { get; set; }

        [JsonPropertyName("image")]
        public string carImg { get; set; }

        public override string ToString() //yani jab b mai ToString fn ko call karoon ga to hamesha yahi fn call ho ga bcz mai ne isse override kiya (fnoverriding means k same fn likha jaye with same parameters)
        {
            return JsonSerializer.Serialize<Car>(this); //yeh hum is liye use kar rahe k jo json file specific format mai hai isse hum string format mai change kar sake or <Car> se matlab yeh hai k hum <Car> k hisab se future mai serialize kare ge or "this" is liye k jon sa b current obj ho ga uusee.. 
        }
    }
}
