namespace MonoTestUciliste.Service.Entities
{
    public enum Ocjena
    { A, B, C, D, E }
    public class DatumUpisa
    {
        public int DatumUpisaID { get; set; }
        public int PredmetID { get; set; }
        public int StudentID { get; set; }
        public Ocjena? Ocjena { get; set; }

        public virtual Predmet Predmeti { get; set; }
        public virtual Student Studenti { get; set; }

    }
}