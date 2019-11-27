using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TravelApp.Models;
using TravelApp.Views;
using TravelApp.ViewModels;

namespace TravelApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ItemsViewModel(this);
        }

        private void showMenu_Tapped(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //ImageMain.ScaleTo(0, 500, Easing.Linear);
            
            //await BrowseItemsPage.FadeTo(0,300,Easing.Linear);
            //await BrowseItemsPage.FadeTo(0.5,300,Easing.Linear);
            //await BrowseItemsPage.FadeTo(1,300,Easing.Linear);
        }

        private async void detailAbout_Tapped(object sender, EventArgs e)
        {
            //this.ScaleTo(1.25, 500, Easing.Linear);
            //GridMain.FadeTo(0, 500);
            //ImageMain.IsVisible = true;
            //ImageMain.Opacity = 0;
            //ImageMain.FadeTo(0.5, 500);
            //ImageMain.FadeTo(1, 500);
            //ImageMain.ScaleTo(1, 500, Easing.Linear);
            //await Task.Delay(200);
            //await ImageMain.FadeTo(1, 500);
            await Navigation.PushAsync(new NewItemPage());
            
            //GridMain.FadeTo(1,0);
            //ImageMain.IsVisible = false;
            //this.ScaleTo(1, 0, Easing.Linear);



            //await this.ScaleTo(2, 500, Easing.Linear);
            //
            //await this.ScaleTo(1,0,Easing.Linear);
        }
    }
}