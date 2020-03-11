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
	public partial class master : ContentPage
	{
		public master ()
		{
			InitializeComponent ();
		}

        private async void Historia_neiva_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Historia());
        }

        private async void Comidas_neiva_Clicked_1(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Comidas());
        }

        private async void Lugares_neiva_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Lugares());
        }

        private async void Fiestas_neiva_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Fiestas());
        }
    }
}