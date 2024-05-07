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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=NEXA\\SQLEXPRESS;database=Kutuphane;integrated security=True");
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public void listele()
        {
            dt.Clear();
            
            SqlCommand cmd = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo order by kitapNo", baglan);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgw_show.DataSource = dt;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgw_show.BackgroundColor =  Color.FromArgb(230, 230, 230);
            listele();
        }

        private void cb_listele_Enter(object sender, EventArgs e)
        {
            cb_filter.Text = "";
            cb_filter.ForeColor = SystemColors.WindowText;
        }

        private void cb_listele_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_find.Enabled = true;
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            frm_addBookReg bookReg = new frm_addBookReg();
            bookReg.ShowDialog();
            listele();
        }

        private void btn_addAuthor_Click(object sender, EventArgs e)
        {
            frm_addAuthor author = new frm_addAuthor(); 
            author.ShowDialog();
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            frm_deleteBook delete = new frm_deleteBook();
            delete.ShowDialog();
            listele();
        }

        private void btn_deleteAuthor_Click(object sender, EventArgs e)
        {
            frm_deleteAuthor deleteAuthor = new frm_deleteAuthor();
            deleteAuthor.ShowDialog();
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            if (cb_filter.SelectedIndex == 0)
            {
                dt2.Clear();

                SqlCommand bilgiler = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo where kitapNo like '%" + txt_find.Text + "%'", baglan);
                SqlDataAdapter x = new SqlDataAdapter(bilgiler);
                x.Fill(dt2);

                dgw_show.DataSource = dt2;
            }
            else if (cb_filter.SelectedIndex == 1)
            {
                dt2.Clear();

                SqlCommand bilgiler = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo where kitapAdi like '%" + txt_find.Text + "%'", baglan);
                SqlDataAdapter x = new SqlDataAdapter(bilgiler);
                x.Fill(dt2);

                dgw_show.DataSource = dt2;
            }
            else if (cb_filter.SelectedIndex == 2)
            {
                dt2.Clear();

                SqlCommand bilgiler = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo where sayfaSayisi like '%" + txt_find.Text + "%'", baglan);
                SqlDataAdapter x = new SqlDataAdapter(bilgiler);
                x.Fill(dt2);

                dgw_show.DataSource = dt2;
            }
            else if (cb_filter.SelectedIndex == 3)
            {
                dt2.Clear();

                SqlCommand bilgiler = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo where kitaplar.yazarNo like '%" + txt_find.Text + "%'", baglan);
                SqlDataAdapter x = new SqlDataAdapter(bilgiler);
                x.Fill(dt2);

                dgw_show.DataSource = dt2;
            }
            else if (cb_filter.SelectedIndex == 4)
            {
                dt2.Clear();

                SqlCommand bilgiler = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo where yazarlar.yazar like '%" + txt_find.Text + "%'", baglan);
                SqlDataAdapter x = new SqlDataAdapter(bilgiler);
                x.Fill(dt2);

                dgw_show.DataSource = dt2;
            }
            else if (cb_filter.SelectedIndex == 5)
            {
                dt2.Clear();

                SqlCommand bilgiler = new SqlCommand("select kitapNo as [Kitap Numarası], kitapAdi as [Kitap Adı], sayfaSayisi as [Sayfa Sayısı], kayitTarihi as [Kayıt Tarihi], yazarlar.yazarNo as [Yazar Nuamrası], yazarlar.yazar as [Yazar] from kitaplar join yazarlar on kitaplar.yazarNo=yazarlar.yazarNo where kayitTarihi like '%" + txt_find.Text + "%'", baglan);
                SqlDataAdapter x = new SqlDataAdapter(bilgiler);
                x.Fill(dt2);

                dgw_show.DataSource = dt2;
            }
        }
    }
}
