using SuiviBourse.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuiviBourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlerteListViewPage : ContentPage
    {
        // public ObservableCollection<string> Items { get; set; }
        MainPageViewModel vm;
        public AlerteListViewPage()
        {
            InitializeComponent();
            vm = new MainPageViewModel(this);

            /*
                        Items = new ObservableCollection<string>
                        {
                            "Item 1",
                            "Item 2",
                            "Item 3",
                            "Item 4",
                            "Item 5"
                        };
                        MyListView.ItemsSource = Items;
                        */
            // MyListView.ItemsSource = vm.ListeAlerte   ;
            BindingContext = vm;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
