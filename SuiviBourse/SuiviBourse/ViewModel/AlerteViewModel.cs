using SuiviBourse.Model;
using SuiviBourse.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SuiviBourse.ViewModel
{
    class AlerteViewModel : INotifyPropertyChanged
    {
        Page page;
        public Alerte alerte { get; set; }
        public ICommand SaveAlerteCommand { get; private set; }
        public ICommand DeleteAlerteCommand { get; private set; }
        public ICommand CancelAlerteCommand { get; private set; }



        public AlerteViewModel(Page page, Alerte _alerte)
        {
            this.page = page;
            alerte = _alerte;
            
            SaveAlerteCommand = new Command<string>((key) =>
            {
                //await 
                App.Database.SaveItemAsync(alerte);
                page.Navigation.PopAsync();
            });
            DeleteAlerteCommand = new Command<string>((key) =>
            {
                App.Database.DeleteItemAsync(alerte);
                page.Navigation.PopAsync();
            });
            CancelAlerteCommand = new Command<string>((key) =>
            {
                 page.Navigation.PopAsync();   //   OR   ...  Application.Current.MainPage.Navigation.PopAsync();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
