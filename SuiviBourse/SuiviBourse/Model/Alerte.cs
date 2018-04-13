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
        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float Cours { get => cours; set => cours = value; }

        private string code;
        private string libelle;
        private float cours;
    }
}
