using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    abstract class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string eMail { get; set; }
        public byte[] slika { get; set; }

        public Osoba() { }
        public Osoba(string Ime, string Prezime, string Username, string Password, string EMail, byte[] Slika)
        {
            ime = Ime;
            prezime = Prezime;
            username = Username;
            password = Password;
            eMail = EMail;
            slika = Slika;
        }


        
    }
}
