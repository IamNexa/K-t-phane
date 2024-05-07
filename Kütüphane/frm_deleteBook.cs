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
    public partial class frm_deleteBook : Form
    {
        public frm_deleteBook()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=NEXA\\SQLEXPRESS;database=Kutuphane;integrated security=True");
        DataTable dt = new DataTable();
        int identity;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from kitaplar where kitapNo="+ txt_bookNum.Text,baglan);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter("select top 1 kitapNo from kitaplar order by kitapNo desc", baglan);
            adp.Fill(dt);

            identity = Convert.ToInt16(dt.Rows[0]["kitapNo"].ToString());

            SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT('kitaplar',RESEED," + identity+ ")", baglan);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Kayıt silindi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglan.Close();

            txt_bookNum.Text = "";
        }
    }
}
