using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DrugiProjekatTVP
{
    public partial class FrmPregledRacuna : Form
    {
        List<Racun> sviRacuni;
        public FrmPregledRacuna()
        {
            InitializeComponent();
            CenterToScreen();
            sviRacuni = new Baza().CitajRacune();          
            dtmOd.MinDate = sviRacuni.OrderBy(r => r.Datum).First().Datum;
            dtmOd.MaxDate = dtmDo.MaxDate = sviRacuni.OrderByDescending(r => r.Datum).First().Datum;
            vrmOd.Value = new DateTime(dtmOd.Value.Year, dtmOd.Value.Month, dtmOd.Value.Day, 0, 0, 0);
            vrmDo.Value = new DateTime(dtmOd.Value.Year, dtmOd.Value.Month, dtmOd.Value.Day, 23, 59, 59);
            dtmOd.ValueChanged += PromenaPerioda;
            dtmDo.ValueChanged += PromenaPerioda;
            vrmOd.ValueChanged += PromenaPerioda;
            vrmDo.ValueChanged += PromenaPerioda;
            PromenaPerioda(new object(), new EventArgs());
        }

        private void PromenaPerioda(object sender, EventArgs e)
        {
            dtmDo.MinDate = dtmOd.Value;
            vrmOd.MaxDate = vrmDo.Value;
            if (sender is DateTimePicker && (sender as DateTimePicker).Name.StartsWith("dtm"))
            {
                vrmDo.Value = new DateTime(dtmOd.Value.Year, dtmOd.Value.Month, dtmOd.Value.Day, 23, 59, 59);
                vrmOd.Value = new DateTime(dtmOd.Value.Year, dtmOd.Value.Month, dtmOd.Value.Day, 0, 0, 0);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sviRacuni.Where(r => r.Datum.Date >= dtmOd.Value.Date && r.Datum.Date <= dtmDo.Value.Date && r.Vreme.TimeOfDay >= vrmOd.Value.TimeOfDay && r.Vreme.TimeOfDay <= vrmDo.Value.TimeOfDay).ToList<Racun>();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["id_racun"].HeaderText = "Broj računa";
            dataGridView1.Columns["vreme"].DefaultCellStyle.Format = "HH:mm:ss";
            dataGridView1.Columns["datum"].DefaultCellStyle.Format = "dd.MM.yyyy.";
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dataGridView1.RowCount == 0)
                lblObavestenje.Text = "Nema nijedan račun u periodu: " + dtmOd.Value.ToString("dd.MM.yyyy.") + " - " + dtmDo.Value.ToString("dd.MM.yyyy.") + ", " + vrmOd.Value.ToString("HH:mm:ss") + " - " + vrmDo.Value.ToString("HH:mm:ss");
            else
                lblObavestenje.Text = "Računi za period: " + dtmOd.Value.ToString("dd.MM.yyyy.") + " - " + dtmDo.Value.ToString("dd.MM.yyyy.") + ", " + vrmOd.Value.ToString("HH:mm:ss") + " - " + vrmDo.Value.ToString("HH:mm:ss");
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
