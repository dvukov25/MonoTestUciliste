using System.Collections;
using System.Collections.Generic;

namespace MonoTestUciliste.Service.Entities
{
    public class Predmet
    {
        public int PredmetID { get; set; }
        public string NazivPredmeta { get; set; }
        public int Kredit { get; set; }
        public int OdjelID { get; set; }

        public virtual Odjel Odjeli { get; set; }
        public virtual ICollection<DatumUpisa> DatumiUpisa { get; set; }
        public virtual ICollection<Predavac> Predavaci { get; set; }

    }
}