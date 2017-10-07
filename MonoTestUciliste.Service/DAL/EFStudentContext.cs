using MonoTestUciliste.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestUciliste.Service.DAL
{
    public class EFStudentContext : DbContext
    {

        public DbSet<Student> Studenti { get; set; }

        public DbSet<Predmet> Predmets { get; set; }
    }
}