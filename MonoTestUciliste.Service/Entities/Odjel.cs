using System;
using System.Collections.Generic;

namespace MonoTestUciliste.Service.Entities
{
    public class Odjel
    {
        public int OdjelID { get; set; }

        public string Naziv { get; set; }

        public decimal Budzet { get; set; }

        public DateTime PocetakRada { get; set; }
        public int? PredavacID { get; set; }
        public virtual Predavac Administrator { get; set; }
        public virtual ICollection<Predmet> Predmeti { get; set; }
    }
}