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
                Telefonnummer = "54654881",
                BeziehungsArt = BeziehungsArt.Familie,
            });

            kontakte.Add(new Kontakt()
            {
                Vorname = "Martha",
                Nachname = "Mustermann",
                Adresse = "Musterstraße 5",
                Telefonnummer = "54654881",
                BeziehungsArt = BeziehungsArt.Familie,
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Billard",
                Nachname = "Bob",
                Adresse = "Bobstraße 12",
                Telefonnummer = "418515687",
                BeziehungsArt = BeziehungsArt.Privat,
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Anna",
                Nachname = "Author",
                Adresse = "Freideich 12",
                Telefonnummer = "84691515687",
                BeziehungsArt = BeziehungsArt.Geschäftlich,
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Charm",
                Nachname = "Cheussur",
                Adresse = "Reichenburg 12",
                Telefonnummer = "84188",
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Hinze",
                Nachname = "Ketchup",
                Adresse = "Heinrichstr. 9999",
                Telefonnummer = "85475312188",
                BeziehungsArt = BeziehungsArt.Privat,
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Nur",
                Nachname = "Nummer",
                Adresse = "",
                Telefonnummer = "854846531188",
                BeziehungsArt = BeziehungsArt.Geschäftlich,
            });
            kontakte.Add(new Kontakt()
            {
                Vorname = "Nur",
                Nachname = "Name",
                Adresse = "",
                Telefonnummer = "",
                BeziehungsArt = BeziehungsArt.Geschäftlich,
            });
        }
    }
}
