using System;
using SchoolProject;

namespace SchoolProject.Models
{
    public class Lehrer : Person
    {
        public int Id { get; set; }

        public string Fachgebiet { get; set; }

        public Lehrer() : base(DateTime.MinValue, "unbekannt") { }

        public Lehrer(string name, DateTime geburtstag, string geschlecht, string fachgebiet)
            : base(geburtstag, geschlecht)
        {
            Name = name;
            Fachgebiet = fachgebiet;
        }
    }
}
