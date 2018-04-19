using SuiviBourse.DataSource;
using SuiviBourse.Model;
using SuiviBourse.ViewModel;
using SuiviBourse.Tools;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace SuiviBourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlerteListViewPage : ContentPage
    {
        BourseRestService bourseRestService;
        List<BourseAction> listBourseAction;

        MainPageViewModel vm;
        public AlerteListViewPage()
        {
            listBourseAction = DataSourceMock1.GetBourseActionList();
            bourseRestService = new BourseRestService();
            InitializeComponent();
            vm = new MainPageViewModel(this);
            BindingContext = vm;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //DataSourceMock1.GetAllNewsAsync();

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            /*
            listBourseAction = await bourseRestService.GetCoursDataAsync(listBourseAction);
            vm.BourseActionList = listBourseAction;
            */
            Console.WriteLine("OK : "+ listBourseAction.ToString() );
        }

        
    }
}
