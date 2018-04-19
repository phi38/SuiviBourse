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
using System.Threading;

namespace SuiviBourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlerteListViewPage : ContentPage
    {
        BourseRestService bourseRestService;
        List<BourseAction> listBourseAction;
        int count = 0;

        MainPageViewModel vm;
        public AlerteListViewPage()
        {
            listBourseAction = DataSourceMock1.GetBourseActionList();
            bourseRestService = new BourseRestService();
            InitializeComponent();
            vm = new MainPageViewModel(this);
            vm.initListWithRef(ref listBourseAction);
            BindingContext = vm;

            TimerContext s = new TimerContext();

            // Create the delegate that invokes methods for the timer.
            TimerCallback timerDelegate = new TimerCallback(TimerRaised);

            // Create a timer that waits one second, then invokes every second.
            Timer timer = new Timer(timerDelegate, s, 1000, 1000);

            // Keep a handle to the timer, so it can be disposed.
            s.tmr = timer;

        }

        private bool RefreshListes()
        {
            Console.WriteLine("OK: " + count++);
            return true;
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
            Console.WriteLine("OK : " + listBourseAction.ToString());
        }

        static void TimerRaised(Object state)
        {
            TimerContext s = (TimerContext)state;
            
            if (s.state == 2)
            {
                s.state = 0;
                s.tmr.Dispose();
                s.tmr = null;
            }
            else
            if (s.state == 0)
            {
                s.state = 1;
            }

        }

    }

    class TimerContext
    {
        public int state = 0;  // 0 arret  // 1 run  // 2 requested to stop
        public Timer tmr;
    }

}
