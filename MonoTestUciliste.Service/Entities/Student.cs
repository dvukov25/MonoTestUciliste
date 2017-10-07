using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestUciliste.Service.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public DateTime DatumUpisa { get; set; }

        public virtual ICollection<DatumUpisa> DatumiUpisa { get; set; }
    }
}
