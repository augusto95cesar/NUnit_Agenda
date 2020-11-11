using Agenda.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.DAL
{
    public class Contatos
    {
       
        string _connection;  
        public Contatos()
        {           
            _connection = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        }
        public void Adicionar(Contato contato)
        {
            using (var con = new SqlConnection(_connection))
            {               
                var sql = $"insert into Contato (Id,Nome) values('{contato.Id}', '{contato.Nome}')";
                con.Execute(sql); 
            }
        }

        public Contato ObterContato(Contato contato)
        {
            using (var con = new SqlConnection(_connection))
            {                
                var sql = $"select Nome, Id from Contato where Id ='{contato.Id}'";
                return con.Query<Contato>(sql).FirstOrDefault();
            }
        }

        public List<Contato> ObterTodos()
        {
            using (var con = new SqlConnection(_connection))
            {                
               var sql = $"select Nome, Id from Contato";
               return con.Query<Contato>(sql).ToList(); 
            }
        }
    }
}
