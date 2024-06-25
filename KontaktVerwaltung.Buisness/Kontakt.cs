using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktVerwaltung.Buisness
{
    public class Kontakt
    {
        public string? Vorname { get; set; }
        public string? Nachname { get; set; }
        public string? Telefonnummer { get; set;}
        public string? Adresse { get; set; }
        public BeziehungsArt? BeziehungsArt { get; set; }

    }
}
