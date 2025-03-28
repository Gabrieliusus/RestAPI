using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Objects
{
    public class Klassenraum
    {
        public float RaumInQm { get; set; }
        public int Plaetze { get; set; }
        public bool HasCynap { get; set; }

        public List<Schueler> SchuelerImRaum = new List<Schueler>();
        public Klassenraum(float raumInQm, int plaetze, bool hasCynap)
        {
            RaumInQm = raumInQm;
            Plaetze = plaetze;
            HasCynap = hasCynap;
        }
    }
}