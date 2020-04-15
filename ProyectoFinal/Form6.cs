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
    public partial class PayLoans : Form
    {
        public PayLoans()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MLoans Back = new MLoans();
            Back.ShowDialog();
        }

        private void PayLoans_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                int Pay;
            

                Id = int.Parse(Idprestamo.Text);
                Pay = int.Parse(Pago.Text);


                Conect.Open();
                SqlCommand cmd = new SqlCommand("generatePaidments", Conect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idprestamo", Id);
                cmd.Parameters.AddWithValue("@Paidment", Pay);
                cmd.ExecuteNonQuery();
                Pago.Clear();
                Idprestamo.Clear();
                this.Hide();

            }
        }
    }
}
