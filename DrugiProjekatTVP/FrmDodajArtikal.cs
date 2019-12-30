using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiProjekatTVP
{
    public partial class FrmDodajArtikal : Form
    {
        string putanjaSlike;
        int idGrupa;
        public FrmDodajArtikal()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public FrmDodajArtikal(int id_grupe) : this()
        {
            lblGrupa.Text = new Baza().CitajGrupe().Where(x => x.Id_grupa == id_grupe).First().Naziv;
            idGrupa = id_grupe;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cao");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog nadjiSliku = new OpenFileDialog();
            nadjiSliku.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (nadjiSliku.ShowDialog() == DialogResult.OK)
            {
                putanjaSlike = nadjiSliku.FileName;
                btnSlika.BackgroundImage = new Bitmap(Image.FromFile(putanjaSlike), new Size(btnSlika.Width, btnSlika.Height));
                btnSlika.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Artikal");
            string greske = "";
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Artikal", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Prodavnica.accdb");
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);

                da.InsertCommand = cb.GetInsertCommand();
                da.UpdateCommand = cb.GetUpdateCommand();

                double cena;
                int popust;

                if (string.IsNullOrEmpty(txtNaziv.Text))
                    greske += "Morate dati ime artiklu! " + Environment.NewLine;

                if (!double.TryParse(txtCena.Text, out cena) || cena <=0)
                    greske += "Nepravilan unos cene!" + Environment.NewLine;
                if (string.IsNullOrEmpty(txtPopust.Text))
                    popust = 0;
                else if(!int.TryParse(txtPopust.Text, out popust) || popust < 0 || popust > 99)
                    greske += "Nepravilan unos popusta, popust može biti od 0 do 99, okrugao broj!" + Environment.NewLine;


                if (greske != "")
                    throw new Exception(greske);

                da.Fill(dt);

                int idSlike;
                if (dt.Rows.Count == 0)
                    idSlike = 1;
                else
                    idSlike = (int)dt.Select().Last()["id_artikal"] + 1;

                string putanjaSacuvaneSlike;
                if (putanjaSlike == null)
                    putanjaSacuvaneSlike = "";
                else
                    putanjaSacuvaneSlike = "artikli\\artikal" + idSlike + Path.GetExtension(putanjaSlike);
                dt.Rows.Add(null, txtNaziv.Text, cena, popust, idGrupa, putanjaSacuvaneSlike);
                da.Update(dt);
                
                MessageBox.Show("Dodato!");
                if(putanjaSlike != null)
                    File.Copy(putanjaSlike, putanjaSacuvaneSlike);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
