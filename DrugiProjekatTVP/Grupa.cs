using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekatTVP
{
    class Grupa
    {
        int id_grupa;
        string naziv, slika;

        public Grupa() { }

        public int Id_grupa { get => id_grupa; set => id_grupa = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Slika { get => slika; set => slika = value; }
    }
}
