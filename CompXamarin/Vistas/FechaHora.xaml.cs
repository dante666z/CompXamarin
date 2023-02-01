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
    public partial class FechaHora : ContentPage
    {
        public FechaHora()
        {
            InitializeComponent();
        }

        private void dtfecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblResultado.Text = dtfecha.Date.ToString("dd/MM/yyyy");
        }

        private void TpHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblHora.Text = TpHora.Time.ToString();
        }
    }
}