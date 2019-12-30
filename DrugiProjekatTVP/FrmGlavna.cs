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
    public partial class FrmGlavna : Form
    {
        Baza baza;
        List<Artikal> artikliNaRacunu;
        AzuriranjeRacuna azuriranjeRacuna;
        Task vreme;
        public FrmGlavna()
        {
            InitializeComponent();
            baza = new Baza();
            CenterToScreen();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            artikliNaRacunu = new List<Artikal>();
            lstRacun.DataSource = artikliNaRacunu;
            
            azuriranjeRacuna = new AzuriranjeRacuna(AzurirajRacun);
            vreme = new Task(prikaziVreme);
            vreme.Start();
            PrikaziGrupe(flowLayoutPanel1, B_Click);
        }

        public static void PrikaziGrupe(FlowLayoutPanel fl, EventHandler az)
        {
            List<Grupa> grupe = new Baza().CitajGrupe();
            const int dimenzije = 130;
            for (int i = 0; i < grupe.Count; i++)
            {
                Button b = new Button();
                b.Height = b.Width = dimenzije;
                b.Name = grupe[i].Id_grupa.ToString();
                b.Text = grupe[i].Naziv;
                b.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                b.BackgroundImageLayout = ImageLayout.None;
                b.TextAlign = ContentAlignment.BottomCenter;
                b.BackgroundImage = new Bitmap(Image.FromFile(grupe[i].Slika ?? @"grupe\nepoznato.jpg"), new Size(b.Width, b.Height - 30));

                fl.Controls.Add(b);
                b.Click += az;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGrupa frmGrupa = new FrmGrupa(this, int.Parse((sender as Button).Name), artikliNaRacunu);
            frmGrupa.AzuriranjeRacuna += AzurirajRacun;
            frmGrupa.Show();
        }

        public void AzurirajRacun(List<Artikal> artikli)
        {
            double ukupnaCena = 0;
            foreach (Artikal a in artikli)
            {
                ukupnaCena += a.Cena;
            }
            lblUkupnaCena.Text = ukupnaCena.ToString() + " din.";
            lstRacun.DataSource = null;
            lstRacun.DataSource = artikli;
            lstRacun.DisplayMember = "NazivCena";
            lstRacun.ValueMember = "NazivCena";
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            if (lstRacun.SelectedValue != null)
            {
                MessageBox.Show("Stornirano: " + lstRacun.SelectedValue + " !");
                artikliNaRacunu.RemoveAt(lstRacun.SelectedIndex);
                AzurirajRacun(artikliNaRacunu);
            }
            else
            {
                MessageBox.Show("Morate kliknuti na artikal koji zelite da stornirate!");
            }
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            Racun r = new Racun();
            r.Cena = (lstRacun.DataSource as List<Artikal>).Select(x => x.Cena).Sum();
            r.Vreme = DateTime.Now;
            r.Datum = DateTime.Now;
            if(r.Cena != 0)
            {
                artikliNaRacunu.Clear();
                AzurirajRacun(artikliNaRacunu);
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

        public void prikaziVreme()
        {
            while (menuStrip1.Items.Count > 2)
                menuStrip1.Items[2].Text = "Datum: " + DateTime.Now.ToString("dd.MM.yyyy.") + " Trenutno vreme: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void noviArtikalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodavanjeArtiklaGrupa frmNoviArtikal = new FrmDodavanjeArtiklaGrupa(this);
            frmNoviArtikal.Show();
        }
    }
}
