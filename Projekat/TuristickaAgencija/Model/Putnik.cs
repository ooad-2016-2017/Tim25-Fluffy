﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Klase
{
    public class Putnik : Osoba
    {
        public Putnik(string pIme, string pPrezime, string pUser, string pPass, string pEMail, string pBrojTelefona, byte[] pSlika) : base( pIme,  pPrezime,  pUser,  pPass,  pEMail, pBrojTelefona, pSlika) { }
        public Putnik() { } 
    }
}
