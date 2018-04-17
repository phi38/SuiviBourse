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

namespace SuiviBourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlerteListViewPage : ContentPage
    {



        RootObject h;
        // public ObservableCollection<string> Items { get; set; }
        MainPageViewModel vm;
        public AlerteListViewPage()
        {
            InitializeComponent();
            vm = new MainPageViewModel(this);
            Console.WriteLine("OK = ");

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

            //DataSourceMock1.GetAllNewsAsync();

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            string sentence = "-1,68%</div>";
            int i = sentence.IndexOf('%');

            float res = Tools.Utils.ExtractFloat(sentence, '%');

            string sentence2 = "102,700\n\t\t\t\t€";

            float res2 = Tools.Utils.ExtractFloat(sentence2, '\n');


            //h = await DataSourceMock1.GetTasksAsync();
            Console.WriteLine("OK : "+h.ToString() );
        }

        
    }
}
