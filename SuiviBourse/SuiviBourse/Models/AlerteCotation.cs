using SuiviBourse.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Models
{
    public class AlerteCotation
    {
        public AlerteCotation(Alerte al)
        {
            Alerte = al;
        }
        public AlerteCotation(Alerte al, Cotation cotation)
        {
            Alerte = al;
            Cotation = cotation;
        }

        public Alerte Alerte { get; set; }
        public Cotation Cotation { get ; set ; }
    }
}
