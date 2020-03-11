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
	public partial class detail : ContentPage
	{
		public detail ()
		{
			InitializeComponent ();

		}

        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void Registrate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrate());
        }
    }
}