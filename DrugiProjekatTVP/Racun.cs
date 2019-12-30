using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekatTVP
{
    public class Racun
    {
        int id_racun;
        double cena;
        DateTime datum;
        DateTime vreme;
        public Racun() { }

        public int Id_racun { get => id_racun; set => id_racun = value; }
        public double Cena { get => cena; set => cena = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public DateTime Vreme { get => vreme; set => vreme = value; }
    }
}
