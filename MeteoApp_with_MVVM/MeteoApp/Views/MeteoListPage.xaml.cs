using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MeteoApp
{
    public partial class MeteoListPage : ContentPage
    {
        public MeteoListPage()
        {
            InitializeComponent();

            BindingContext = new MeteoListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnItemAdded(object sender, EventArgs e)
        {
            OnAlertYesNoClicked(sender, e);
        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }

        void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushAsync(new MeteoItemPage()
                {
                    BindingContext = new MeteoItemViewModel(e.SelectedItem as City)
                });
            }
        }
    }
}
