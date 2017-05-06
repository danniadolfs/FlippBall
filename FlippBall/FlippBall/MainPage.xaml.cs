using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlippBall
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void OnStartClicked(object sender, EventArgs args)
        {
            var page = new gameActivity();

            await Navigation.PushModalAsync(page);
            //await DisplayAlert("FlippBall", "This will start the game.", "OK");
        }
    }
}
