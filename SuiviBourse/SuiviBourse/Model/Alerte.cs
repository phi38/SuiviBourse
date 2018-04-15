using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Model
{
    class Alerte
    {
        public Alerte()
        {
        }
        public Alerte( string code, string libelle )
        {
            Code = code;
            Libelle = libelle;
        }

       
        public Alerte(string code, string libelle , float variation , float alerteHCours, float alerteBCours, float alerteHVar, float alerteBVar)
        {
            Code = code;
            Libelle = libelle;
            Variation = variation;
            AlerteHCours = alerteHCours;
            AlerteBCours =  alerteBCours;
            AlerteHVar= alerteHVar;
            AlerteBVar= alerteBVar;
        }
        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float Cours { get => cours; set => cours = value; }

        public float Variation { get; set; }
        public float AlerteHCours { get; set; }
        public float AlerteBCours { get; set; }
        public float AlerteHVar { get; set; }
        public float AlerteBVar { get; set; }


        private string code;
        private string libelle;
        private float cours;


    }
}
