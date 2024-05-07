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

namespace Kütüphane
{
    public partial class frm_addBookReg : Form
    {
        public frm_addBookReg()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=NEXA\\SQLEXPRESS;database=Kutuphane;integrated security=True");
        DataTable dt = new DataTable();
        string yazarNo;

        private void frm_addBookReg_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select yazar from yazarlar",baglan);
            adp.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_authors.Items.Add(dt.Rows[i]["yazar"].ToString());
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("select yazarNo from yazarlar where CONVERT(NVARCHAR(MAX), yazar)='" + cb_authors.SelectedItem.ToString() + "'", baglan);
            adp.Fill(dtt);

            yazarNo = dtt.Rows[0]["yazarNo"].ToString();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into kitaplar(kitapAdi,sayfaSayisi,yazarNo,kayitTarihi) values('"+ txt_bookName.Text +"',"+ txt_pages.Text +","+ yazarNo +",'"+ dtp_date.Value.ToString("yyyy-MM-dd") +"')",baglan);
            baglan.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt eklendi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglan.Close();

            txt_bookName.Text = "";
            txt_pages.Text = "";
            cb_authors.Text = "";
            dtp_date.Value = DateTime.Now;
        }

    }
}
