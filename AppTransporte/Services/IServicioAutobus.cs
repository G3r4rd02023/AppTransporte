using AppTransporte.Models;

namespace AppTransporte.Services
{
    public interface IServicioAutobus
    {
        public Task<List<AutobusViewModel>> ObtenerLista();

    }
}
