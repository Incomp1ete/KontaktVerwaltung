using KontaktVerwaltung.Buisness;
using KontaktVerwaltung.ViewModels.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace KontaktVerwaltung.ViewModels
{
    public class KontaktBuchAnzeigeViewModel : ViewModelBase
    {
        public string Filter { get; set; } = string.Empty;
        private readonly ObservableCollection<Kontakt> kontakte;
        public IEnumerable<Kontakt> Kontakte => kontakte;

        public KontaktBuchAnzeigeViewModel()
        {
            kontakte = new ObservableCollection<Kontakt>();
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
