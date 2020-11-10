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

namespace Agenda.Aplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = textContatoNovo.Text;
            

            //string connection = @"Server=.;Database=Agenda;Trusted_Connection=True;Connection Timeout=60"; 

            //SqlConnection con = new SqlConnection(connection);
            //con.Open();

            //string guild =  Guid.NewGuid().ToString();

            //string  sql = $"select Nome from Contato where Id ='{guild}'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd =  new SqlCommand(sql, con);
            //textContatoSalvo.Text =  cmd.ExecuteScalar().ToString();
            //con.Close();
        }
    }
}
