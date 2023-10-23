using KuisPertemuan11_AryaDutaAdirajasa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_AryaDutaAdirajasa.View
{
    
    public partial class createMhs : Form
    {
        private MahasiswaController MhsCtrl;
        public createMhs()
        {
            InitializeComponent();
        }

        private void btnSavec_Click(object sender, EventArgs e)
        {
            MhsCtrl = new MahasiswaController();
            MhsCtrl.tambahMahasiswa(txtNIMc.Text, txtNamac.Text, txtAlamatc.Text, txtProdiC.Text, txthobic.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtNIMc.Focus();
            MessageBox.Show("Data disimpan");
            FormUtama lk = new FormUtama();

            lk.Show();
            this.Hide();
        }

        private void btnCancelc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar");
            FormUtama cl = new FormUtama();
            cl.Show(); 
            this.Hide();
        }
    }
}
