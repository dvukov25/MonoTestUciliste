using MonoTestUciliste.Service.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoTestUciliste.Service.Entities;

namespace MonoTestUciliste.Service.DAL
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly EFStudentContext context = new EFStudentContext();
        public IEnumerable<Student> Studenti
        {
            get
            {
                return context.Studenti;
            }
        }
    }
}
