using KuisPertemuan11_AryaDutaAdirajasa.Controller;
using KuisPertemuan11_AryaDutaAdirajasa.Model;
using KuisPertemuan11_AryaDutaAdirajasa.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_AryaDutaAdirajasa
{
    public partial class FormUtama : Form
    {
        private MahasiswaController MhsCtrl;
        public FormUtama()
        {
            MhsCtrl = new MahasiswaController();
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            tampilkan();
        }

        private void tampilkan()
        {
            dataGridView1.DataSource = MhsCtrl.tampilMahasiswa();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            createMhs cMhs = new createMhs();
            cMhs.Show();
            this.Hide();
        }

        private void btnUPD_Click(object sender, EventArgs e)
        {
            UpdateMhs upd = new UpdateMhs();
            upd.Show();
            this.Hide();
        }
    }
}
