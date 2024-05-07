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
    public partial class frm_addAuthor : Form
    {
        public frm_addAuthor()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglan = new SqlConnection("server=NEXA\\SQLEXPRESS;database=Kutuphane;integrated security=True");

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into yazarlar values('"+ txt_yazar.Text +"')",baglan);

            baglan.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt eklendi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglan.Close();

            txt_yazar.Text = "";
        }
    }
}
