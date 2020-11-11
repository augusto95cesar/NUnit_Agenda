using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class BaseTest
    {
        string _script;
        string _conSetUpTest;
        string _con;
        string _catalogTest;
        public BaseTest()
        {
            this._script = @"DBAgendaTest.sql";
            this._conSetUpTest = ConfigurationManager.ConnectionStrings["conSetUpTest"].ConnectionString;
            this._con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            this._catalogTest = ConfigurationManager.ConnectionStrings["conSetUpTest"].ProviderName;
        }
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            CreateDBTest();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            DeleteDbTEst();
        }

        private void CreateDBTest()
        {
            using (var con = new SqlConnection(_conSetUpTest))
            {
                con.Open();
                //var scriptSql = File
                //    .ReadAllText($@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}\{_script}")
                //    .Replace("$(DefaultDataPath)", $@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}")
                //    .Replace("$(DefaultLogPath)", $@"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}")
                //    .Replace("$(DefaultFilePrefix)", _catalogTest)
                //    .Replace("$(DatabaseNAme)", _catalogTest)
                //    .Replace("WITH (DATA_COMPRESSION = PAGE)", string.Empty)
                //    .Replace("SET NOEXEC ON", string.Empty)
                //    .Replace("GO\r\n", "|");
               // ExecuteScriptSql(con, scriptSql);
                ExecuteScriptSql(con, "Create database AgendaTest");                
            }
            using (var con = new SqlConnection(_con))
            {
                con.Open(); 
                ExecuteScriptSql(con, $@"CREATE TABLE Contato (
                                        Id   UNIQUEIDENTIFIER NOT NULL,
                                        Nome VARCHAR (100)    NULL,
                                        PRIMARY KEY CLUSTERED (Id ASC));
                ");
            }
        }

        private void ExecuteScriptSql(SqlConnection con, string scriptSql)
        {
            using (var cmd = con.CreateCommand())
            {
                foreach (var sql in scriptSql.Split('|'))
                {
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch(Exception e)
                    {
                        Console.WriteLine(sql);
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        private void DeleteDbTEst()
        {
            using (var con = new SqlConnection(_con))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {                     
                    cmd.CommandText = $@"DROP TABLE Contato";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $@" USE MASTER DROP DATABASE {_catalogTest}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
