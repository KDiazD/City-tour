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
	public partial class Comidas : ContentPage
	{
		public Comidas ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista_Comidas comidas = new Lista_Comidas();
            Listscomidas.ItemsSource = comidas._comidas;
            Listscomidas.ItemSelected += Listscomidas_ItemSelected;
        }

        private void Listscomidas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var food = e.SelectedItem as Comida;
                DisplayAlert(food.Nombre, food.Descripcion, "Aceptar");
            }
        }
    }
}