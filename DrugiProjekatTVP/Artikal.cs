using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekatTVP
{
    public class Artikal
    {
        int id_artikal;
        string naziv, slika;
        double cena;
        int? popust;
        int br_grupe;

        public Artikal() { }

        public int Id_artikal { get => id_artikal; set => id_artikal = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }
        public int? Popust { get => popust; set => popust = value; }
        public int Br_grupe { get => br_grupe; set => br_grupe = value; }
        public string NazivCena { get { return Naziv + ": " + Cena + " din."; } }
        public string Slika { get => slika; set => slika = value; }
    }
}
