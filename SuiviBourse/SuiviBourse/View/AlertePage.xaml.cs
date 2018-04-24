using SuiviBourse.Model;
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
    public partial class AlertePage : ContentPage
    {
        AlerteViewModel vm;

        public AlertePage()
        {
            InitializeComponent();
            vm = new AlerteViewModel(this, new Alerte());
            BindingContext = vm;
        }

        
    }
}
