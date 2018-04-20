using SuiviBourse.DataSource;
using SuiviBourse.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SuiviBourse.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        //private List<BourseAction> bourseActionList;

        //public List<BourseAction> BourseActionList { get => bourseActionList; set => bourseActionList = value; }        //public List<BourseAction> BourseActionList { get; set; }
        public ObservableCollection<BourseAction> BourseActionList { get; set; }

        public void InitListWithRef(ref List<BourseAction> _bourseActionList)
        {
            this.BourseActionList = new ObservableCollection<BourseAction>(_bourseActionList);
        }

        Page page;
        public ICommand NewWinCommand { protected set; get; }
        public MainPageViewModel( Page page)
        {
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
