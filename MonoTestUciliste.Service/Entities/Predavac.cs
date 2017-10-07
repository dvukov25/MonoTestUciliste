using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestUciliste.Service.Entities
{
    public class Predavac
    {
        public int PredavacID { get; set; }

        public string Prezime { get; set; }

        public string Ime { get; set; }


        public DateTime DatumZaposlenja { get; set; }

        public string FullName
        {
            get { return Prezime + ", " + Ime; }
        }
        public virtual ICollection<Predmet> Predmeti { get; set; }
        //public virtual DodjeljeniUred DodjeljenUred { get; set; }
    }
}
