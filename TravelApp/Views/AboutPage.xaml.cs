using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
           
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //your code here;
            while (true)
            {
                 arrow.TranslateTo(-5,0, 450, Easing.Linear);
                await arrow.FadeTo(0, 100, Easing.Linear);
                await arrow.FadeTo(0.25, 300, Easing.Linear);
                 arrow.TranslateTo(0,0, 450, Easing.Linear);
                await arrow.FadeTo(0.5, 300, Easing.Linear);
                 arrow.TranslateTo(5,0, 450, Easing.Linear);
                await arrow.FadeTo(0.75, 300, Easing.Linear);
                 arrow.TranslateTo(10,0, 450, Easing.Linear);
                await arrow.FadeTo(1, 300, Easing.Linear);
            }
        }

    }

    


}   