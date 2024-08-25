namespace rtl1025.Components.Models
{
    public class Brano
    {
        public string Titolo;
        public int Durata;
        public string Autore;
        public Brano(string titolo, int durata, string autore)
        {
            Titolo = titolo;
            Durata = durata; 
            Autore = autore;
        }
    }
}
