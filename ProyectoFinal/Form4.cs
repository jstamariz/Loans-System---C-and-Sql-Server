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
    public partial class AddClients : Form
    {
        public AddClients()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClients BackHome = new AddClients();
            BackHome.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
             using (SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
            Initial Catalog=Sistema de Prestamos; Integrated Security=True;"))
            {
                string Name;
                string Dir;
                string PhoneNumber;

                Name = Nombre.Text;
                Dir = Direction.Text;
                PhoneNumber = Phone.Text;

                Conect.Open();
                SqlCommand cmd = new SqlCommand("AddClients", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre",Name);
                cmd.Parameters.AddWithValue("@Direccion", Dir);
                cmd.Parameters.AddWithValue("@Telefono", PhoneNumber);
                cmd.ExecuteNonQuery();
                Nombre.Clear();
                Direction.Clear();
                Phone.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateClient_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
            Initial Catalog=Sistema de Prestamos; Integrated Security=True;"))
            {
                Conect.Open();
                SqlCommand cmd = new SqlCommand("addClients", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", ClientName.Text);
                cmd.Parameters.AddWithValue("@Direccion", Dir.Text);
                cmd.Parameters.AddWithValue("@Telefono", Pho.Text);
                cmd.ExecuteNonQuery();
                ClientName.Clear();
                Dir.Clear();
                Pho.Clear();
            }
        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
            Initial Catalog=Sistema de Prestamos; Integrated Security=True;"))
            {
                Conect.Open();
                SqlCommand cmd = new SqlCommand("ModifyClients", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientId", int.Parse(Id.Text));
                cmd.Parameters.AddWithValue("@Nombre", ClientName.Text);
                cmd.Parameters.AddWithValue("@Direccion", Dir.Text);
                cmd.Parameters.AddWithValue("@Telefono", Pho.Text);
                cmd.ExecuteNonQuery();
                ClientName.Clear();
                Dir.Clear();
                Pho.Clear();
                Id.Clear();
            }
        }
    }
}
