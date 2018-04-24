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

        public ICommand SaveAlerteCommand { get; private set; }
        public ICommand DeleteAlerteCommand { get; private set; }
        public ICommand CancelAlerteCommand { get; private set; }



        public AlerteViewModel(Page page, Alerte alerte)
        {
            this.page = page;
            SaveAlerteCommand = new Command<string>((key) =>
            {
                //var todoItem = (TodoItem)BindingContext;
                //await App.Database.SaveItemAsync(todoItem);
                //await Navigation.PopAsync();
            });
            DeleteAlerteCommand = new Command<string>((key) =>
            {
                //var todoItem = (TodoItem)BindingContext;
                //await App.Database.DeleteItemAsync(todoItem);
                //await Navigation.PopAsync();

            });
            CancelAlerteCommand = new Command<string>((key) =>
            {
                //await Navigation.PopAsync();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
