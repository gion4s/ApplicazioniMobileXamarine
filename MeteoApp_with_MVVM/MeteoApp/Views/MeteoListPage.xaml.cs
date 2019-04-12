using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace MeteoApp
{
    public partial class MeteoListPage : ContentPage
    {
        MeteoListViewModel MeteoListViewModel = new MeteoListViewModel();

        public MeteoListPage()
        {
            InitializeComponent();

            BindingContext = MeteoListViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnItemAddedAsync(object sender, EventArgs e)
        {
            PromptResult pResult = await UserDialogs.Instance.PromptAsync(new PromptConfig
            {
                InputType = InputType.Name,
                OkText = "Add City",
                Title = "New City",
            });

            if (pResult.Ok && !string.IsNullOrWhiteSpace(pResult.Text))
            {
                MeteoListViewModel.addCityToList(pResult.Text);
            }

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
