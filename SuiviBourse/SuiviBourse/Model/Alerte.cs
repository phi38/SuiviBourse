using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Model
{
    class Alerte : BourseAction
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



        public float AlerteHCours { get; set; }
        public float AlerteBCours { get; set; }
        public float AlerteHVar { get; set; }
        public float AlerteBVar { get; set; }


        private string code;
        private string libelle;
        private float cours;


    }
}
