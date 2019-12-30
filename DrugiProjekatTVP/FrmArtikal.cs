using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiProjekatTVP
{
    public partial class FrmArtikal : Form
    {
        Baza baza;
        List<Artikal> artikliNaRacunu;
        Artikal artikal;
        public FrmArtikal()
        {
            InitializeComponent();
        }

        public FrmArtikal(int id_artikla, List<Artikal> trenutniArtikli) :this()
        {
            artikliNaRacunu = trenutniArtikli;
            for (int i = 10; i > 0; i--)
                updownKolicina.Items.Add(i);
            updownKolicina.SelectedIndex = 9;
            baza = new Baza();
            artikal = (from art in baza.CitajArtikle()
                        where id_artikla == art.Id_artikal
                        select new Artikal { Id_artikal=id_artikla, Br_grupe = art.Br_grupe, Cena = art.Cena, Naziv = art.Naziv, Popust = art.Popust }).First();
            artikal.Cena = Math.Round(artikal.Cena - (artikal.Cena * ((artikal.Popust ?? 0) / 100.0)), 2);
            lblNaziv.Text = artikal.Naziv;
            lblCena.Text = Math.Round(artikal.Cena, 2).ToString() + " rsd";
            lblPopust.Text = artikal.Popust.ToString() + " %";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (int.Parse(updownKolicina.Text) > 10)
            {   
                if(MessageBox.Show("Da li ste sigurni, kolicina artikala je: " + updownKolicina.Text, "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < int.Parse(updownKolicina.Text); i++)
                    {
                        artikliNaRacunu.Add(artikal);
                    }
                    MessageBox.Show("Dodato!");
                    Close();
                }
            }
            else
            {
                for(int i=0;i<int.Parse(updownKolicina.Text);i++)
                {
                    artikliNaRacunu.Add(artikal);
                }
                MessageBox.Show("Dodato!");
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmArtikal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
