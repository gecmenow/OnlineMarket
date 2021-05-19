using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KramDeliverFoodCompleted.Serialize
{
    public class Serializer
    {
        public static string DoSerialization(Product product)
        {
            var serialized = JsonSerializer.Serialize(product);

            return serialized;
        }

        public static Product DoDeserialization(string file)
        {
            var deserialized = JsonSerializer.Deserialize<Product>(file);

            return deserialized;
        }
    }
}
