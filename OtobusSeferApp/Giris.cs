using OtobusSeferApp.Dal;
using OtobusSeferApp.Data_Sql;
using OtobusSeferApp.Models;
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

namespace OtobusSeferApp
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            User user = new User();
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@kullaniciadi", txt_kullaniciAdi.Text));
            _params.Add(new SqlParameter("@sifre", txt_sifre.Text));

            Execute execute = new Execute();
            DataTable dtSonuc = execute.executeDT(user.getUser_Sql(), _params.ToArray());

            if (dtSonuc.Rows[0]["Sayi"].ToString() != "0")
            {
                Anasayfa fAna = new Anasayfa();
                fAna.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Hatalı giriş denemesi! Tekrar denemek ister misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.ToString() == "Yes")
                {
                    txt_kullaniciAdi.Text = "";
                    txt_sifre.Text = "";
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
