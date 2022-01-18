using OtobusSeferApp.Dal;
using OtobusSeferApp.Data_Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusSeferApp.Models
{
    public partial class Anasayfa : Form
    {
        private int childFormNumber = 0;

        public Anasayfa()
        {
            InitializeComponent();
        }
        Execute execute = new Execute();
        Sefer sefer = new Sefer();
        Ticket ticket = new Ticket();
        User user = new User();
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    
        //sefer

        //çıkış yap
        private void tsm_cikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //sefer-listele
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = execute.executeDT(sefer.getSeferList_Sql(), null);
            dataGridView3.DataSource = dt;
        }
        //bilet-listele
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DataTable dt = execute.executeDT(ticket.getTicketList_Sql(), null);
            dataGridView2.DataSource = dt;
        }
        //kullanıcı-listele
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            DataTable dt = execute.executeDT(user.getUserList_Sql(), null);
            dataGridView1.DataSource = dt;
        }
        //sefer-ekle
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
                List<SqlParameter> _params = new List<SqlParameter>();
                _params.Add(new SqlParameter("@kalkisYeri", cmb_KalkisNoktasi.SelectedItem.ToString()));
                _params.Add(new SqlParameter("@varisYeri", cmb_VarisNoktasi.SelectedItem.ToString()));
                _params.Add(new SqlParameter("@kalkisSaati", dateTimePicker1.Value));
                bool sonuc = execute.execute(sefer.addSefer_Sql(), _params.ToArray());
                lbl_bilgi.Text = sonuc.ToString();

                DataTable dt = execute.executeDT(sefer.getSeferList_Sql(), null);
                dataGridView3.DataSource = dt;
        }
        //sefer-değiştir
        //düzenle
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlParameter> _params = new List<SqlParameter>();
                _params.Add(new SqlParameter("@id", dataGridView3.SelectedRows[0].Cells["id"].Value.ToString()));
                _params.Add(new SqlParameter("@kalkisYeri", cmb_KalkisNoktasi.SelectedItem.ToString()));
                _params.Add(new SqlParameter("@varisYeri", cmb_VarisNoktasi.SelectedItem.ToString()));
                _params.Add(new SqlParameter("@kalkisSaati", dateTimePicker1.Value));

                bool sonuc = execute.execute(sefer.updateSefer_Sql(), _params.ToArray());

                lbl_bilgi.Text = sonuc.ToString();

                DataTable dt = execute.executeDT(sefer.getSeferList_Sql(), null);
                dataGridView3.DataSource = dt;
            }
            catch
            {
                lbl_bilgi.Text = "Seçili kayıt okunamadı!";
            }
        }
        //sefer-sil
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlParameter> _params = new List<SqlParameter>();
                _params.Add(new SqlParameter("@id", dataGridView3.SelectedRows[0].Cells["id"].Value.ToString()));

                bool sonuc = execute.execute(sefer.deleteSefer_Sql(), _params.ToArray());

                lbl_bilgi.Text = sonuc.ToString();

                DataTable dt = execute.executeDT(sefer.getSeferList_Sql(), null);
                dataGridView3.DataSource = dt;
            }
            catch
            {
                lbl_bilgi.Text = "Seçili kayıt okunamadı!";
            }
        }
        //sefer - arama komutu
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@aranacakDeger", txt_aranacakDegerSefer.Text));
            DataTable dt = execute.executeDT(sefer.findSefer_Sql(), _params.ToArray());
            dataGridView3.DataSource = dt;
        }
        //bilet-arama komutu
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@aranacakDeger", txt_aranacakDegerBilet.Text));
            DataTable dt = execute.executeDT(ticket.findTicket_Sql(), _params.ToArray());
            dataGridView2.DataSource = dt;
        }
        //bilet-ekle
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@biletSahipAdi", txt_BiletSahipAdi.Text));
            _params.Add(new SqlParameter("@biletSahipSoyadi", txt_BiletSahipSoyadi.Text));
            _params.Add(new SqlParameter("@biletSahipCep", txt_biletSahipCep.Text));
            _params.Add(new SqlParameter("@biletNo", txt_biletNo.Text));
            _params.Add(new SqlParameter("@username_id", txt_username_id.Text));
            _params.Add(new SqlParameter("@sefer_id", txt_sefer_id.Text));

            bool sonuc = execute.execute(ticket.addTicket_Sql(), _params.ToArray());

            lbl_bilgi.Text = sonuc.ToString();

            DataTable dt = execute.executeDT(ticket.getTicketList_Sql(), null);
            dataGridView2.DataSource = dt;
        }
        //bilet-değiştir
        //bak
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlParameter> _params = new List<SqlParameter>();
                _params.Add(new SqlParameter("@id", dataGridView2.SelectedRows[0].Cells["id"].Value.ToString()));
                _params.Add(new SqlParameter("@biletSahipAdi",txt_BiletSahipAdi.Text));
                _params.Add(new SqlParameter("@biletSahipSoyadi",txt_BiletSahipSoyadi.Text));
                _params.Add(new SqlParameter("@biletSahipCep", txt_biletSahipCep.Text));
                _params.Add(new SqlParameter("@biletNo", txt_biletNo.Text));
                _params.Add(new SqlParameter("@username_id", txt_username_id.Text));
                _params.Add(new SqlParameter("@sefer_id", txt_sefer_id.Text));

                bool sonuc = execute.execute(ticket.updateTicket_Sql(), _params.ToArray());

                lbl_bilgi.Text = sonuc.ToString();

                DataTable dt = execute.executeDT(ticket.getTicketList_Sql(), null);
                dataGridView2.DataSource = dt;
            }
            catch
            {
                lbl_bilgi.Text = "Seçili kayıt okunamadı!";
            }

        }
        //bilet-sil
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlParameter> _params = new List<SqlParameter>();
                _params.Add(new SqlParameter("@id", dataGridView2.SelectedRows[0].Cells["id"].Value.ToString()));

                bool sonuc = execute.execute("delete from Bilet where id=@id", _params.ToArray());

                lbl_bilgi.Text = sonuc.ToString();
            }
            catch
            {
                lbl_bilgi.Text = "Seçili kayıt okunamadı!";
            }
        }
        //kullanıcı-ara
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@aranacakDeger", txt_aranacakDegerKullanici.Text));
            DataTable dt = execute.executeDT(user.findUser_Sql(), _params.ToArray());
            dataGridView1.DataSource = dt;
        }
        //kullanıcı-ekle 
        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@kullaniciadi", txt_kullaniciAdi.Text));
            _params.Add(new SqlParameter("@sifre", txt_sifre.Text));

            bool sonuc = execute.execute(user.addUser_Sql(), _params.ToArray());

            lbl_bilgi.Text = sonuc.ToString();

            DataTable dt = execute.executeDT(user.getUserList_Sql(), null);
            dataGridView1.DataSource = dt;
        }
        //kullanıcı-değiştir
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()));
            _params.Add(new SqlParameter("@kullaniciadi", txt_kullaniciAdi.Text));
            _params.Add(new SqlParameter("@sifre", txt_sifre.Text));

            bool sonuc = execute.execute(user.updateUser_Sql(), _params.ToArray());

            lbl_bilgi.Text = sonuc.ToString();

            DataTable dt = execute.executeDT(user.getUserList_Sql(), null);
            dataGridView1.DataSource = dt;
        }
        //kullanıcı-sil
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlParameter> _params = new List<SqlParameter>();
                _params.Add(new SqlParameter("@id", dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()));

                bool sonuc = execute.execute(user.deleteUser_Sql(), _params.ToArray());

                lbl_bilgi.Text = sonuc.ToString();
            }
            catch
            {
                lbl_bilgi.Text = "Seçili kayıt okunamadı!";
            }

            DataTable dt = execute.executeDT(user.getUserList_Sql(), null);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BiletSahipAdi.Text = dataGridView2.SelectedRows[0].Cells["biletSahipAdi"].Value.ToString();
            txt_BiletSahipSoyadi.Text = dataGridView2.SelectedRows[0].Cells["biletSahipSoyadi"].Value.ToString();
            txt_biletSahipCep.Text = dataGridView2.SelectedRows[0].Cells["biletSahipCep"].Value.ToString();
            txt_biletNo.Text = dataGridView2.SelectedRows[0].Cells["biletNo"].Value.ToString();
            txt_username_id.Text = dataGridView2.SelectedRows[0].Cells["username_id"].Value.ToString();
            txt_sefer_id.Text = dataGridView2.SelectedRows[0].Cells["sefer_id"].Value.ToString();
        }

        private void datagrid(object sender, DataGridViewCellEventArgs e)
        {
            cmb_KalkisNoktasi.SelectedItem = dataGridView3.SelectedRows[0].Cells["kalkisYeri"].Value.ToString();
            cmb_VarisNoktasi.SelectedItem = dataGridView3.SelectedRows[0].Cells["varisYeri"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView3.Rows[e.RowIndex].Cells["kalkisSaati"].Value.ToString());

            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", dataGridView3.SelectedRows[0].Cells["id"].Value.ToString()));
            DataTable dt = execute.executeDT(ticket.getSefer_Bilet_Sql(), _params.ToArray());
            dataGridView_Detay.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.SelectedRows[0].Cells["kullaniciadi"].Value.ToString();
            txt_sifre.Text = dataGridView1.SelectedRows[0].Cells["sifre"].Value.ToString();
        }

        private void txt_aranacakDegerSefer_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = txt_aranacakDegerSefer.TextLength;
        }
    }
}
