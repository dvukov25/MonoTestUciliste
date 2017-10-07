using MonoTestUciliste.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestUciliste.Service.Abstarct
{
    public interface IStudentRepository
    {
        IEnumerable<Student> Studenti { get; }
    }
}