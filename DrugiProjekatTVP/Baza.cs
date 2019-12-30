using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DrugiProjekatTVP
{
    class Baza
    {
        OleDbConnection konekcija;

        public Baza()
        {
            konekcija = new OleDbConnection();
            konekcija.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Prodavnica.accdb";
        }

        public List<Grupa> CitajGrupe()
        {
            List<Grupa> grupe = new List<Grupa>();
            OleDbCommand upit = new OleDbCommand();

            konekcija.Open();

            upit.Connection = konekcija;
            upit.CommandText = "select * from Grupa";
            OleDbDataReader procitano = upit.ExecuteReader();

            while (procitano.Read())
            {
                Grupa g = new Grupa();
                g.Id_grupa = (int)procitano["id_grupa"];
                g.Naziv = (string)procitano["naziv"];
                g.Slika = procitano["slika"] as string;
                grupe.Add(g);
            }
            konekcija.Close();

            return grupe;
        }

        public List<Artikal> CitajArtikle()
        {
            List<Artikal> artikli = new List<Artikal>();
            OleDbCommand upit = new OleDbCommand();

            konekcija.Open();

            upit.Connection = konekcija;
            upit.CommandText = "select * from Artikal";
            OleDbDataReader procitano = upit.ExecuteReader();

            while (procitano.Read())
            {
                Artikal a = new Artikal();
                a.Id_artikal = (int)procitano["id_artikal"];
                a.Naziv = (string)procitano["naziv"];
                a.Cena = (double)procitano["cena"];
                a.Popust = (procitano["popust"] as int?) ?? 0;
                a.Br_grupe = (int)procitano["br_grupe"];
                a.Slika = procitano["slika"] as string;
                artikli.Add(a);
            }
            konekcija.Close();

            return artikli;
        }

        public void UpisiRacun(Racun r)
        {
            konekcija.Open();

            OleDbCommand upit = new OleDbCommand();
            upit.CommandText = "INSERT INTO Racun (cena, datum, vreme) " +
                               "VALUES ('" + r.Cena + "','" + r.Datum + "','" + r.Vreme + "');";
            upit.Connection = konekcija;

            upit.ExecuteNonQuery();

            konekcija.Close();

        }

        public List<Racun> CitajRacune()
        {
            List<Racun> racuni = new List<Racun>();
            OleDbCommand upit = new OleDbCommand();

            konekcija.Open();

            upit.Connection = konekcija;
            upit.CommandText = "select * from Racun";
            OleDbDataReader procitano = upit.ExecuteReader();

            while (procitano.Read())
            {
                Racun r = new Racun();
                r.Id_racun = (int)procitano["id_racun"];
                r.Datum = (DateTime)procitano["datum"];
                r.Vreme = (DateTime)procitano["vreme"];
                r.Cena = (double)procitano["cena"];
                racuni.Add(r);
            }
            konekcija.Close();
            return racuni;
        }

    }
}
