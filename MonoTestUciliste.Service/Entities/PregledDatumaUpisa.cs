using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestUciliste.Service.Entities
{
    public class PregledDatumaUpisa
    {
        [DataType(DataType.Date)]
        public DateTime? DatumUpisa { get; set; }
        public int BrojStudenata { get; set; }
    }
}
