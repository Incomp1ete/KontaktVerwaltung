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
using KontaktVerwaltung.ViewModels.Store;


namespace KontaktVerwaltung.ViewModels
{
    public class KontaktBuchAnzeigeViewModel : ViewModelBase
    {
        public string Filter { get; set; }
        private readonly KontaktBuchStore store;
        private readonly ObservableCollection<Kontakt> kontakte;
        public IEnumerable<Kontakt> Kontakte => kontakte;

        public KontaktBuchAnzeigeViewModel()
        {
            this.store = new KontaktBuchStore(new KontaktBuch());
            Filter = string.Empty;
            kontakte = new ObservableCollection<Kontakt>();
            foreach(var kontakt in store.Kontakte)
            {
                kontakte.Add(kontakt);
            }
        }
    }
}
