using AppTransporte.Models;
using System.Text.Json;

namespace AppTransporte.Services
{
    public class ServicioAutobus : IServicioAutobus
    {
        private string urlApi = "http://www.apisistematransporte.somee.com/api/autobus/lista";
        public async Task<List<AutobusViewModel>> ObtenerLista()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                var autobusData = JsonSerializer.Deserialize<List<AutobusViewModel>>(responseBody);
                return autobusData;
            }
            else
            {
                // Manejar el caso cuando la solicitud no es exitosa.
                Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
                return new List<AutobusViewModel>();
            }
        }
    }
}
