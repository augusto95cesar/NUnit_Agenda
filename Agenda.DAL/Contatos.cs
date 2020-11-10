using Agenda.Domain;
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
                con.Open();
                var sql = $"insert into Contato (Id,Nome) values('{contato.Id}', '{contato.Nome}')";
                var cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

        public Contato Obter(Contato contato)
        {
            using (var con = new SqlConnection(_connection))
            {
                con.Open();
                var sql = $"select Nome, Id from Contato where Id ='{contato.Id}'";
                var cmd = new SqlCommand(sql, con);
                var result = cmd.ExecuteReader();
                result.Read();

                return new Contato
                {
                    Id = Guid.Parse(result["Id"].ToString()),
                    Nome = result["Nome"].ToString()
                };
            }
        }

        public List<Contato> ObterTodos()
        {
            using (var con = new SqlConnection(_connection))
            {
                con.Open();
                var sql = $"select Nome, Id from Contato";
                var cmd = new SqlCommand(sql, con);
                var sqlDataReader = cmd.ExecuteReader();
                List<Contato> list = new List<Contato>();
                while (sqlDataReader.Read())
                {
                    list.Add(new Contato
                    {
                        Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                        Nome = sqlDataReader["Nome"].ToString()
                    });
                }
                return list;
            }
        }
    }
}
