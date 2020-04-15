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
    public partial class AddLoans : Form
    {
        public AddLoans()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MLoans Back = new MLoans();
            Back.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-78L61PQ\SQLEXPRESS;
            Initial Catalog=Sistema de Prestamos; Integrated Security=True;"))
            {
                int Id;
                int Quant;
                double Interest;
                int Quotes;

                Id = int.Parse(ClientId.Text);
                Quant = int.Parse(Quantity.Text);
                Interest = int.Parse(InterestRate.Text);
                Quotes = int.Parse(Quote.Text);


                Conect.Open();
                SqlCommand cmd = new SqlCommand("GenerateLoans", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientId", Id);
                cmd.Parameters.AddWithValue("@Amount", Quant);
                cmd.Parameters.AddWithValue("@InterestRate", Interest);
                cmd.Parameters.AddWithValue("@feesamount", Quotes);
                cmd.ExecuteNonQuery();
                ClientId.Clear();
                Quantity.Clear();
                InterestRate.Clear();
                Quote.Clear();
                this.Hide();
            }
        }

        private void AddLoans_Load(object sender, EventArgs e)
        {

        }

        private void ClientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
