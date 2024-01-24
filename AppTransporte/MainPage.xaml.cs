using AppTransporte.Services;

namespace AppTransporte
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly IServicioAutobus _servicioAutobus;

        public MainPage(IServicioAutobus servicioAutobus)
        {
            InitializeComponent();
            _servicioAutobus = servicioAutobus;
        }

       

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _servicioAutobus.ObtenerLista();
            listViewAutobuses.ItemsSource = data;

            loading.IsVisible = false;
        }
    }

}
