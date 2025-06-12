﻿using System.ComponentModel.DataAnnotations;


namespace SchoolProject.Objects
{
    public class Klassenraum
    {
        public float RaumInQm { get; set; }
        public int Plaetze { get; set; }
        public bool HasCynap { get; set; }

        [Key]
        public int Id { get; set; }

        public List<Schueler> SchuelerImRaum = new List<Schueler>();
        public Klassenraum(float raumInQm, int plaetze, bool hasCynap)
        {
            RaumInQm = raumInQm;
            Plaetze = plaetze;
            HasCynap = hasCynap;
        }
    }
}