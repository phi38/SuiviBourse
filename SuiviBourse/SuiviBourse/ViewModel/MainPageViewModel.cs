using SuiviBourse.DataSource;
using SuiviBourse.Model;
using SuiviBourse.View;
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
        public ICommand AddAlerteCommand { get; private set; }

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
            AddAlerteCommand = new Command<string>((key) =>
            {
                page.Navigation.PushAsync(new AlertePage( ));
                
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }


}
