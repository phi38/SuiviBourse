using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Model
{
    public class BourseAction
    {
        public BourseAction()
        {
            Cours = 0;
            Variation = 0;
        }

        public BourseAction(string code, string libelle)
        {
            Code = code;
            Libelle = libelle;
            Cours = 0;
            Variation = 0;
        }

        public BourseAction(string code, string libelle, float cours, float variation)
        {
            Code = code;
            Libelle = libelle;
            Cours = cours;
            Variation = variation;
        }

        public string Code { get; set ; }
        public string Libelle { get; set; }
        public float Cours { get ; set; }
        public float Variation { get; set; }
    }
}
