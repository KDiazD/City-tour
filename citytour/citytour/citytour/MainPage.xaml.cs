using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace citytour
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Inicia_app_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }

    }
}
