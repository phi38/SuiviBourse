using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Model
{
    public class Alerte 
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public float AlerteHCours { get; set; }
        public float AlerteBCours { get; set; }
        public float AlerteHVar { get; set; }
        public float AlerteBVar { get; set; }
        public string Code { get; set; }


        public Alerte()
        {
            AlerteHCours = 0;
            AlerteBCours = 0;
            AlerteHVar = 0;
            AlerteBVar = 0;
        }

        public Alerte(BourseAction bourseAction)
        {
            //this.bourseAction = bourseAction;
            AlerteHCours = 0;
            AlerteBCours = 0;
            AlerteHVar = 0;
            AlerteBVar = 0;
        }


        public Alerte(string code, string libelle, float cours, float variation, float alerteHCours, float alerteBCours, float alerteHVar, float alerteBVar)
        {
            //bourseAction = new BourseAction(code, libelle, cours, variation);
            AlerteHCours = alerteHCours;
            AlerteBCours = alerteBCours;
            AlerteHVar = alerteHVar;
            AlerteBVar = alerteBVar;
        }

        public Alerte(string code, string libelle , float alerteHCours, float alerteBCours, float alerteHVar, float alerteBVar)
        {
          //  bourseAction = new BourseAction(code, libelle);
            AlerteHCours = alerteHCours;
            AlerteBCours =  alerteBCours;
            AlerteHVar= alerteHVar;
            AlerteBVar= alerteBVar;
        }


        /*

        public BourseAction BourseAction { get => bourseAction; set => bourseAction = value; }


        private BourseAction bourseAction;
        */

       
    }
}
