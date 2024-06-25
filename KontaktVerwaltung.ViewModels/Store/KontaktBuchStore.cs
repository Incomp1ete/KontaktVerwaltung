using KontaktVerwaltung.Buisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktVerwaltung.ViewModels.Store
{
    public class KontaktBuchStore
    {
        private readonly List<Kontakt> kontakte;
        public IEnumerable<Kontakt> Kontakte => kontakte;
        private readonly KontaktBuch kontaktBuch;

        public KontaktBuchStore(KontaktBuch kontaktBuch) 
        {
            this.kontaktBuch = kontaktBuch;
            kontakte = new List<Kontakt>();
            UpdateKontaktBuch();
        }

        public void UpdateKontaktBuch()
        {
            kontakte.Clear();
            kontakte.AddRange(kontaktBuch.Kontakte);
        }
    }
}
