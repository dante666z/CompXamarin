using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alertas : ContentPage
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void btnAlertas_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Titutlo", "Mensaje", "OK");
            PopupNavigation.Instance.PushAsync(new AlertaN1());
        }
    }
}