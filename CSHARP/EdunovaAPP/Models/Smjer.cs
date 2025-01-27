namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {
        public string Naziv { get; set; } = "";
        public decimal Cijena { get; set; }
        public DateTime? IzdoviSeOd { get; set; }
        public bool Vaucer { get; set; }

    }
}
