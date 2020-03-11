using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace citytour
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lugares : ContentPage
	{
		public Lugares ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista_elementos elementos = new Lista_elementos();
            Listselementos.ItemsSource = elementos._elementos;
            Listselementos.ItemSelected += Listselementos_ItemSelected;

        }
        private void Listselementos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var element = e.SelectedItem as Elemento;
                DisplayAlert(element.Nombre, element.Descripcion, "Aceptar");
            }
        }
    }
}