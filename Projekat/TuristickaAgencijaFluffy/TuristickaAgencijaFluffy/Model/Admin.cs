using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Model
{
    public class Admin : Osoba
    {
        public Admin(string pIme, string pPrezime, string pUser, string pPass, string pEMail, string pBrojTelefona, byte[] pSlika) : base( pIme,  pPrezime,  pUser,  pPass,  pEMail, pBrojTelefona, pSlika) { }
        public Admin() { }
        
    }
}
