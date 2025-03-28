using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolProject
{
    public class Person
    {
        private string _geschlecht;
        public string Geschlecht
        {
            get => _geschlecht;
            set
            {
                if (value != "männlich" && value != "weiblich")
                {
                    Console.WriteLine("Ungültiges Geschlecht eingegeben!");
                }
                else
                {
                    _geschlecht = value;
                }
            }
        }
        public DateTime Geburtstag { get; set; }
        public Person(DateTime geburtstag, string geschlecht)
        {
            Geburtstag = geburtstag;
            Geschlecht = geschlecht;
        }
    }
}