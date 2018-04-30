using SuiviBourse.DataSource;
using SuiviBourse.Model;
using SuiviBourse.Models;
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

        public ObservableCollection<AlerteCotation> AlerteList { get; set; }

        public void InitListWithRef( List<Alerte> _bourseALerteList)
        {
            this.AlerteList.Clear();
            Cotation cotation; // = new Cotation("FR0000120073", "AirLiquide", 105, -5);
            foreach ( Alerte alert in _bourseALerteList)
            {
                cotation = App.getCotation(alert.Code);
                this.AlerteList.Add(new AlerteCotation(alert, cotation) );
            }
            
        }

        Page page;



        public MainPageViewModel( Page page)
        {
            this.page = page;
            this.AlerteList = new ObservableCollection<AlerteCotation>();
            //this.AlerteList = new ObservableCollection<Alerte>(DataSourceMock1.GetAlerteList());

            AddAlerteCommand = new Command<string>((key) =>
            {
                page.Navigation.PushAsync(new AlertePage( new Alerte("FR0000120073", "AirLiquide", 105, 0, 10, 10, 15, 15)));
                
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }


}
