using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TravelApp.Models;

namespace TravelApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {

        public NewItemPage()
        {
            InitializeComponent();
        }

        private void showMenu_Tapped(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

           //await headerImage.TranslateTo(0, -1000, 0, Easing.Linear);
            await content_wrapper.TranslateTo(0, 1000, 0, Easing.Linear);
            //await headerImage.TranslateTo(0, 0, 150, Easing.Linear);
            await content_wrapper.TranslateTo(0, 0, 600, Easing.Linear);

            while (true)
            {
                arrow.TranslateTo(-5, 0, 450, Easing.Linear);
                await arrow.FadeTo(0, 100, Easing.Linear);
                await arrow.FadeTo(0.25, 300, Easing.Linear);
                arrow.TranslateTo(0, 0, 450, Easing.Linear);
                await arrow.FadeTo(0.5, 300, Easing.Linear);
                arrow.TranslateTo(5, 0, 450, Easing.Linear);
                await arrow.FadeTo(0.75, 300, Easing.Linear);
                arrow.TranslateTo(10, 0, 450, Easing.Linear);
                await arrow.FadeTo(1, 300, Easing.Linear);


                //heartIcon Animation
                 heartIcon.ScaleTo(1.3, 500, Easing.SpringIn);
                await heartIcon.ScaleTo(1.2, 500, Easing.SpringOut);
                await heartIcon.ScaleTo(1, 1000, Easing.SpringOut);
            }
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }



    }
}