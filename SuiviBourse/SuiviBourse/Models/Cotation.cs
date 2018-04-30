using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SuiviBourse.Model
{
    public class Cotation : INotifyPropertyChanged
    {
        public Cotation()
        {
            Cours = 0;
            Variation = 0;
        }

        public Cotation(string code, string libelle)
        {
            Code = code;
            Libelle = libelle;
            Cours = 0; 
            Variation = 0;
        }
        public Cotation(string code)  
        {
            Code = code;
            Libelle = "--";
            Cours = 0;
            Variation = 0;
        }
        public Cotation(string code, string libelle, float cours, float variation)
        {
            Code = code;
            Libelle = libelle;
            Cours = cours;
            Variation = variation;
        }

        public string Code { get; set ; }
        public string Libelle { get; set; }
        float cours;
        float variation;
        public float Cours {
            get { return cours; }
            set
            {
                cours = value;
                OnPropertyChanged("Cours");
            }
        }
        public float Variation
        {
            get { return variation; }
            set
            {
                variation = value;
                OnPropertyChanged("Variation");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
