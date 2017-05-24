using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Model
{
    public abstract class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string eMail { get; set; }
        public string brojTelefona { get; set; }
        public static int brojac = 0;
        public int id { get; set; }
        public byte[] slika { get; set; }
        public Osoba(){ }
        public Osoba(string pIme, string pPrezime, string pUser, string pPass, string pEMail, string pBrojTelefona, byte[] pSlika)
        {
            ime = pIme;
            prezime = pPrezime;
            user = pUser;
            pass = pPass;
            eMail = pPass;
            brojTelefona=pBrojTelefona;
            id = brojac++;
            slika = pSlika;
        }
    }
}
