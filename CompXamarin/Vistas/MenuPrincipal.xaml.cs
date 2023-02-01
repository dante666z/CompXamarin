using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public IList<Modelo.Mcomidas> Comidas { get; private set; }
        public MenuPrincipal()
        {
            InitializeComponent();
            Comidas = new List<Modelo.Mcomidas>();
            Comidas.Add(new Modelo.Mcomidas
            {
                Nombre = "Imagen circular",
                Imagen = "circulo.jpg"
            });
            Comidas.Add(new Modelo.Mcomidas
            {
                Nombre = "Alertas",
                Imagen = "alerta.png"
            });
            Comidas.Add(new Modelo.Mcomidas
            {
                Nombre = "Tarjetas",
                Imagen = "tarjeta.png"
            });
            Comidas.Add(new Modelo.Mcomidas
            {
                Nombre = "Fechas",
                Imagen = "calendario.png"
            });

            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Modelo.Mcomidas seleccion = e.Item as Modelo.Mcomidas;
            if(seleccion.Nombre == "Tarjetas")
            {
                Navigation.PushAsync(new Tarjetas());
            }
            if (seleccion.Nombre == "Alertas")
            {
                Navigation.PushAsync(new Alertas());
            }
            if (seleccion.Nombre == "Imagen circular")
            {
                Navigation.PushAsync(new CircularImagen());
            }
            if (seleccion.Nombre == "Fechas")
            {
                Navigation.PushAsync(new FechaHora());
            }
        }
    }
}