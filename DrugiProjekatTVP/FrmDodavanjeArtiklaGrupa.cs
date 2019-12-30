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
    public partial class FrmDodavanjeArtiklaGrupa : Form
    {
        Form roditelj;
        public FrmDodavanjeArtiklaGrupa()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public FrmDodavanjeArtiklaGrupa(Form f):this()
        {
            roditelj = f;
        }

        private void FrmNoviArtikal_Load(object sender, EventArgs e)
        {
            FrmGlavna.PrikaziGrupe(flowLayoutPanel1, btnGrupa_Click);
        }

        private void FrmNoviArtikal_FormClosing(object sender, FormClosingEventArgs e)
        {
            roditelj.Close();
        }

        private void btnGrupa_Click(object sender, EventArgs e)
        {
            FrmDodajArtikal frmDodajArtikal = new FrmDodajArtikal(int.Parse((sender as Button).Name));
            frmDodajArtikal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            roditelj.Show();
            if (roditelj is FrmGrupa)
            {
                (roditelj as FrmGrupa).Vreme = new Task((roditelj as FrmGrupa).prikaziVreme);
                (roditelj as FrmGrupa).Vreme.Start();
                (roditelj as FrmGrupa).PrikaziArtikle();
            }
                
        }
    }
}
