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
    public partial class MLoans : Form
    {
        SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
        Initial Catalog=Sistema de Prestamos; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public MLoans()
        {
            InitializeComponent();
            showDataFirstDataGridView("SELECT DISTINCT P.id, C.Nombre, P.Monto, P.Interes, P.Cuotas, P.TasaDeInteres FROM Prestamo P, Cliente C WHERE P.idCliente = C.Id");
        }

        private void MLoans_Load(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddLoans NewLoan = new AddLoans();
            NewLoan.ShowDialog();
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            PayLoans Pay = new PayLoans();
            Pay.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showDataFirstDataGridView(string Query)
        {
            adpt = new SqlDataAdapter(Query, Conect);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void showDataSecondDataGridView()
        {
            adpt = new SqlDataAdapter($"select sum(InteresCuota) + SUM(Capital) from Amortizacion WHERE IdPrestamo = {int.Parse(IdPrestamo.Text)} ", Conect);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Back = new Home();
            Back.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeeDebts_Click(object sender, EventArgs e)
        {
            showDataSecondDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
            Initial Catalog=Sistema de Prestamos; Integrated Security=True;"))
            {

                Conect.Open();
                SqlCommand cmd = new SqlCommand("DeleteLoans", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLoans", int.Parse(Search.Text));
                cmd.ExecuteNonQuery();
                Search.Clear();
            }
        }

        private void SummitSeach_Click(object sender, EventArgs e)
        {
            showDataFirstDataGridView($"Select * From Prestamo where ID = {int.Parse(Search.Text)}");
        }
    }
}
