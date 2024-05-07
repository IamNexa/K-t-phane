using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class frm_deleteAuthor : Form
    {
        public frm_deleteAuthor()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=NEXA\\SQLEXPRESS;database=Kutuphane;integrated security=True");
        DataTable dt = new DataTable();
        //int identity;

        private void frm_deleteAuthor_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select yazar from yazarlar", baglan);
            adp.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_authors.Items.Add(dt.Rows[i]["yazar"].ToString());
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from yazarlar where CONVERT(NVARCHAR(MAX), yazar)='" + cb_authors.SelectedItem.ToString() + "'", baglan);

            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter("select top 1 yazarNo from yazarlar order by yazarNo desc", baglan);
            //adp.Fill(dt);

            //identity = Convert.ToInt16(dt.Rows[0]["yazarNo"].ToString());

            //SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT('yazarlar',RESEED," + identity + ")", baglan);

            //cmd2.ExecuteNonQuery();

            MessageBox.Show("Kayıt silindi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglan.Close();

            cb_authors.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
