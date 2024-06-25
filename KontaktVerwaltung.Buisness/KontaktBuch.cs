using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktVerwaltung.Buisness
{
    public class KontaktBuch
    {
        private readonly List<Kontakt> kontakte;
        public IEnumerable<Kontakt> Kontakte => kontakte;

        public KontaktBuch() 
        { 
            kontakte = new List<Kontakt>();
            kontakte.Add(new Kontakt()
            {
                Vorname = "Max",
                Nachname = "Mustermann",
                Adresse = "Musterstraße 5",
                Telefonnummer = "54654881"
            });

            kontakte.Add(new Kontakt()
            {
                Vorname = "Martha",
                Nachname = "Mustermann",
                Adresse = "Musterstraße 5",
                Telefonnummer = "54654881"
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Billard",
                Nachname = "Bob",
                Adresse = "Bobstraße 12",
                Telefonnummer = "418515687"
            });
        }
    }
}
