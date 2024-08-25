using rtl102._5.Components.Pages;

namespace rtl1025.Components.Models
{
    public class Radio
    {
        public List<Brano> branoList;
        public int durata;
        public Radio()
        {
            branoList = new List<Brano>();
            durata = 0;

        }
        public string InserimentoBrano(Brano brano)
        {
            DurataTempo();
            string risultato;
            risultato = string.Empty;
            if (brano.Durata + durata > 60)
            {
                risultato +=("OPS! sembra che abbia superato i minuti. ERROR: #2039");
            }
            else
            {
                branoList.Add(brano);
                risultato += ("Hai aggiunto con successo il brano" + brano.Titolo);

            }
            return risultato;
        }
        public string CancellaBrano(Brano brano)
        {
            string risultato;
            risultato = string.Empty;
            branoList.Remove(brano);
            risultato += ("E stato rimosso il brano con successo");
            return risultato;
        }
        public string Play()
        {
            string risultato;
            risultato = string.Empty;
            foreach (var brano in branoList)
            {
                risultato += ("Titolo " + brano.Titolo + Environment.NewLine);
                risultato += ("Autore " + brano.Autore + Environment.NewLine);
                risultato += ("Durata " + brano.Durata + Environment.NewLine);
            }
            return risultato;
        }
        public int DurataTempo()
        {
            durata = 0;
            foreach (var brano in branoList)
            {
                durata += brano.Durata;
            }
            return durata;
        }
    }
}
