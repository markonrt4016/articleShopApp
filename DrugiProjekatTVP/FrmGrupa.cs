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
    public delegate void AzuriranjeRacuna(List<Artikal> lista);
    public delegate void AzurirajVreme();
    public partial class FrmGrupa : Form
    {
        FrmGlavna glavna;
        Baza baza;
        List<Artikal> artikliNaRacunu;
        AzuriranjeRacuna azuriranjeRacuna;
        AzurirajVreme azurirajVreme;
        double ukupnaCena;
        Task vreme;
        int id_grupe;
        public AzuriranjeRacuna AzuriranjeRacuna { get => azuriranjeRacuna; set => azuriranjeRacuna = value; }
        public Task Vreme { get => vreme; set => vreme = value; }

        public FrmGrupa()
        {
            InitializeComponent();
            CenterToScreen();
            azurirajVreme += promenaVremena;
        }

        public FrmGrupa(FrmGlavna f, int id_grupa, List<Artikal> artikliRacunGlavna) :this()
        {
            glavna = f;
            id_grupe = id_grupa;
            artikliNaRacunu = artikliRacunGlavna;
            azuriranjeRacuna += AzurirajRacun;
            azuriranjeRacuna(artikliNaRacunu);
            baza = new Baza();
            PrikaziArtikle();
            Vreme = new Task(prikaziVreme);
            Visible = true;
            Vreme.Start();
        }

        private void B_Click(object sender, EventArgs e)
        {
            FrmArtikal frmArtikal = new FrmArtikal(int.Parse((sender as Button).Name), artikliNaRacunu);
            frmArtikal.StartPosition = FormStartPosition.CenterParent;
            frmArtikal.ShowDialog();
            azuriranjeRacuna(artikliNaRacunu);
        }

        public void PrikaziArtikle()
        {
            List<Artikal> artikli = (from artikal in baza.CitajArtikle()
                                     where artikal.Br_grupe == id_grupe
                                     select new Artikal { Id_artikal = artikal.Id_artikal, Naziv = artikal.Naziv, Br_grupe = artikal.Br_grupe, Cena = artikal.Cena, Popust = artikal.Popust, Slika = artikal.Slika }).ToList<Artikal>();
            int dimenzije = 130;
            flowLayoutPanel1.Controls.Clear();
            if (artikli.Count > 0)
            {
                label3.Text = "Odaberite artikal:";
                int maxHeight = artikli.OrderBy(x => x.Naziv.Length).Last().Naziv.Length;
                for (int i = 0; i < artikli.Count; i++)
                {
                    Button b = new Button();
                    b.Name = artikli[i].Id_artikal.ToString();
                    b.Text = artikli[i].Naziv;
                    b.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    b.Width = b.Height = dimenzije + maxHeight * 2;
                    b.BackgroundImageLayout = ImageLayout.None;
                    b.TextAlign = ContentAlignment.BottomCenter;
                    if (artikli[i].Slika == "")
                        artikli[i].Slika = null;
                    //b.BackgroundImage = new Bitmap(Image.FromFile(artikli[i].Slika ?? @"grupe\nepoznato.jpg"), new Size(b.Width, b.Height - (int)(maxHeight * (50/maxHeight))));
                    b.BackgroundImage = new Bitmap(Image.FromFile(artikli[i].Slika ?? @"grupe\nepoznato.jpg"), new Size(b.Width, b.Height - (artikli[i].Naziv.Length/12 + 1) * 30));
                    b.Click += B_Click;
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
            else
            {
                label3.Text = "Trenutno nema nijedan artikal u grupi " + baza.CitajGrupe().Where(x => x.Id_grupa == id_grupe).First().Naziv;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            glavna.Show();
            Hide();
            glavna.AzurirajRacun(artikliNaRacunu);
        }

        private void FrmGrupa_FormClosing(object sender, FormClosingEventArgs e)
        {
            glavna.Close();
        }

        public void AzurirajRacun(List<Artikal> artikli)
        {
            foreach (Artikal a in artikli)
            {
                ukupnaCena += a.Cena;
            }
            lblUkupnaCena.Text = Math.Round(ukupnaCena, 2).ToString() + " din.";
            lstRacun.DataSource = null;
            lstRacun.DataSource = artikli;
            lstRacun.DisplayMember = "NazivCena";
            lstRacun.ValueMember = "id_artikal";
            ukupnaCena = 0;
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            if (lstRacun.SelectedValue != null)
            {
                artikliNaRacunu.RemoveAt(lstRacun.SelectedIndex);
                azuriranjeRacuna(artikliNaRacunu);
            }
            else
            {
                MessageBox.Show("Morate kliknuti na artikal koji zelite da stornirate!");
            }
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            Racun r = new Racun();
            r.Cena = (lstRacun.DataSource as List<Artikal>).Select(x=>x.Cena).Sum();
            r.Vreme = DateTime.Now;
            r.Datum = DateTime.Now;
            if (r.Cena != 0)
            {
                artikliNaRacunu.Clear();
                azuriranjeRacuna(artikliNaRacunu);
                baza.UpisiRacun(r);
                MessageBox.Show("Račun izdat!");
            }
            else
            {
                MessageBox.Show("Dodajte neki artikal da bi ste izdali račun!");
            }
        }

        private void pregledSvihRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPregledRacuna frmPregledRacuna = new FrmPregledRacuna();
            frmPregledRacuna.ShowDialog();
        }

        public void promenaVremena()
        {
            menuStrip1.Items[2].Text = "Datum: " + DateTime.Now.ToString("dd.MM.yyyy.") + " Trenutno vreme: " + DateTime.Now.ToString("HH:mm:ss");
        }

        public void prikaziVreme()
        {
            while (Visible)
                menuStrip1.Invoke(azurirajVreme);
        }

        private void noviArtikalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDodavanjeArtiklaGrupa frmNoviArtikal = new FrmDodavanjeArtiklaGrupa(this);
            frmNoviArtikal.Show();
        }
    }
}
