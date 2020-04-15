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

namespace ProyectoFinal
{
    public partial class MClientes : Form
    {
        SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
        Initial Catalog=Sistema de Prestamos; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public MClientes()
        {
            InitializeComponent();
            showData("select * from cliente");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClients AddClient = new AddClients();
            AddClient.ShowDialog();
            showData("select * from cliente");
        }

        public void showData(string Query)
        {
            adpt = new SqlDataAdapter(Query, Conect);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ListClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home BackHome = new Home();
            BackHome.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData("select * from cliente");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showData($"select * from cliente where id = {int.Parse(SearchBar.Text)}");
            SearchBar.Clear();
        }

        private void DeleteCl_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
            Initial Catalog=Sistema de Prestamos; Integrated Security=True;"))
            {

                Conect.Open();
                SqlCommand cmd = new SqlCommand("DeleteClients", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", SearchBar.Text);
                cmd.ExecuteNonQuery();
                SearchBar.Clear();
            }
        }

        private void ModCl_Click(object sender, EventArgs e)
        {
            AddClients AddClient = new AddClients();
            AddClient.ShowDialog();
            showData("select * from cliente");
        }
    }
}
