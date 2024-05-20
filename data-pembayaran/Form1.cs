using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data_pembayaran
{
    public partial class Form_jenis_pembayaran : Form
    {
        private string conStr = "Data Source=LAPTOP-J7FB2H0P\\SQLEXPRESS; " +
                            "Initial Catalog=dbAdmSekolah; Integrated Security=True";
        private SqlConnection sqlCon;

        public Form_jenis_pembayaran()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conStr);
        }

        private void tampilDataPembayaran()
        {
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM jenis_pembayaran";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            sda.Fill(ds, "jenis_pembayaran");
            dgPembayaran.DataSource = ds;
            dgPembayaran.DataMember = "jenis_pembayaran";
            sqlCon.Close();
        }

        private void Form_jenis_pembayaran_Load(object sender, EventArgs e)
        {
            tampilDataPembayaran();
        }

        // Clear data
        private void clearData()
        {
            txtKodePembayaran.Clear();
            txtNamaPembayaran.Clear();
            txtJumlahPembayaran.Clear();
            txtKodePembayaran.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAdmSekolahDataSet.jenis_pembayaran' table. You can move, or remove it, as needed.
            this.jenis_pembayaranTableAdapter.Fill(this.dbAdmSekolahDataSet.jenis_pembayaran);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO jenis_pembayaran(kode_jenispembayaran, nama_pembayaran, jumlah_pembayaran) " +
                "VALUES('" + txtKodePembayaran.Text + "', '" + txtNamaPembayaran.Text + "', '" + txtJumlahPembayaran.Text + "')";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            tampilDataPembayaran();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE jenis_pembayaran SET nama_pembayaran = '" + txtNamaPembayaran.Text + "', jumlah_pembayaran = '" + 
                txtJumlahPembayaran.Text + "' WHERE kode_jenispembayaran = '" + txtKodePembayaran.Text + "'";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            tampilDataPembayaran();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM jenis_pembayaran WHERE kode_jenispembayaran = '" + txtKodePembayaran.Text + "'";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            tampilDataPembayaran();
        }
    }
}
