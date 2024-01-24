using System.Text.Json.Serialization;

namespace AppTransporte.Models
{
    public class AutobusViewModel
    {
        [JsonPropertyName("idAutobus")]
        public int IdAutobus { get; set; }

        [JsonPropertyName("marca")]
        public string Marca { get; set; }

        [JsonPropertyName("modelo")]
        public string Modelo { get; set; }

        [JsonPropertyName("capacidad")]
        public int Capacidad { get; set; }
    }

}
