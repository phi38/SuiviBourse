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
using SuiviBourse.Models;

namespace SuiviBourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlerteListViewPage : ContentPage
    {
        BourseRestService bourseRestService;
        
        MainPageViewModel vm;
 

        public AlerteListViewPage()
        {

            bourseRestService = new BourseRestService();

            //List<Cotation> listBourseAction;  listBourseAction = DataSourceMock1.GetBourseActionList();

            InitializeComponent();
            vm = new MainPageViewModel(this);
            //vm.InitListWithRef(ref listBourseAction);
            BindingContext = vm;

            TimerContext s = new TimerContext();

            // Create the delegate that invokes methods for the timer.
            TimerCallback timerDelegate = new TimerCallback(TimerRaised);

            // Create a timer that waits one second, then invokes every second.
            Timer timer = new Timer(timerDelegate, s, 20, 20000);

            // Keep a handle to the timer, so it can be disposed.
            s.tmr = timer;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            Navigation.PushAsync(new AlertePage( ( ((AlerteCotation)e.Item)).Alerte));

            ((ListView)sender).SelectedItem = null;
        }
        
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            List<Alerte> listAlerte = await App.Database.GetItemsAsync();
            vm.InitListWithRef( listAlerte );
            //ToolbarItems.Clear();
            //listBourseAction = await bourseRestService.GetCoursDataAsync(listBourseAction);
            //vm.InitListWithRef( ref listBourseAction );


        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new AlertePage() );
            
        }
        async void TimerRaised(Object state)
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
            else
            {
                ICollection<Cotation> icoll = App.CotationMap.Values; 
                foreach ( Cotation cot in icoll)
                {
                    await bourseRestService.GetCoursDataAsync(cot);
                }
               
              
              //  

              //  List<Cotation> listBourseAction = await bourseRestService.GetCoursDataAsync(vm.BourseActionList.GetEnumerator());
              

                Console.WriteLine("OK : " + "Timer Ring");
               
            }

        }

    }

    class TimerContext
    {
        public int state = 0;  // 0 arret  // 1 run  // 2 requested to stop
        public Timer tmr;
    }

}
