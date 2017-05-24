using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Model
{
    public class Lokacija
    {
        public List<byte []> slike { get; set; }
        public string informacije { get; set; }
        public List<string> prevoznaSredstva { get; set; }
        public List<double> cijene { get; set; }
        public string hotel { get; set; }
        public List<string> fakultativniIzleti { get; set; }
        public List<int> putnici { get; set; }
        public static int brojac = 0;
        public int id { get; set; }
        public Lokacija() { }
        public Lokacija(List<byte[]> pSlike, string pInformacije, List<string> pPrevoznaSredstva, List<double> pCijene, string pHotel, List<string> pFakultativniIzleti, List<int> pPutnici)
        {
            slike = pSlike;
            informacije = pInformacije;
            prevoznaSredstva = pPrevoznaSredstva;
            cijene = pCijene;
            hotel = pHotel;
            fakultativniIzleti = pFakultativniIzleti;
            putnici = pPutnici;
            id = brojac++;
        }
        public void obrisiSliku(byte[] slika)
        {
            for(int i=0; i<slike.Count; i++)
            {
                if (slike[i] == slika) slike.RemoveAt(i);
            }
        }
        public void doajSLiku(byte[] slika)
        {
            if (slike.Contains(slika)) return;
            slike.Add(slika);
        }
        public void obrisiPrevoznoSredstvo(string prevoz)
        {
            for(int i=0; i<prevoznaSredstva.Count; i++)
            {
                if (prevoznaSredstva[i] == prevoz) prevoznaSredstva.RemoveAt(i);
            }
        }
        public void dodajPrevoznoSredstvo(string prevoz)
        {
            if (prevoznaSredstva.Contains(prevoz)) return;
            prevoznaSredstva.Add(prevoz);
        }
        public void obrisiCIjenu(double cijena)
        {
            for(int i=0; i<cijene.Count; i++)
            {
                if (cijene[i] == cijena) cijene.RemoveAt(i);
            }
        }
        public void dodajCijenu(double cijena)
        {
            if (cijene.Contains(cijena)) return;
            cijene.Add(cijena);
        }
        public void obrisiFakultativniIzlet(string fakultativniIzlet)
        {
            for (int i = 0; i < fakultativniIzleti.Count; i++)
            {
                if (fakultativniIzleti[i] == fakultativniIzlet) fakultativniIzleti.RemoveAt(i);
            }
        }
        public void dodajFakultativniIzlet(string fakultativniIzlet)
        {
            if (fakultativniIzleti.Contains(fakultativniIzlet)) return;
            fakultativniIzleti.Add(fakultativniIzlet);
        }
        public void dodajPutnika(int putnik)
        {
            if (putnici.Contains(putnik)) return;
            putnici.Add(putnik);
        }
        public void obrisiPutnika(int putnik)
        {
            for(int i=0; i<putnici.Count; i++)
            {
                if (putnici[i] == putnik) putnici.RemoveAt(i);
            }
        }
    }
}
