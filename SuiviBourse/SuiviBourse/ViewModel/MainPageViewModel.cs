using SuiviBourse.DataSource;
using SuiviBourse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SuiviBourse.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        //public List<Alerte> ListeAlerte { get; set; }
        public List<BourseAction> BourseActionList{ get; set; }

        public ICommand NewWinCommand { protected set; get; }
        Page page;

        public MainPageViewModel( Page page)
        {
            //ListeAlerte = DataSourceMock1.;
            BourseActionList = DataSourceMock1.GetBourseActionList();
            this.page = page;
            NewWinCommand = new Command<string>((key) =>
            {
                //page.Navigation.PushAsync(new AlertListViewPage());
                //page.DisplayAlert("No Selection", "You did not select any Garages", "OK", null);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }


}
