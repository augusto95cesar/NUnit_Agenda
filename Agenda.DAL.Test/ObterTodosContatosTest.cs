using Agenda.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class ObterTodosContatosTest: BaseTest
    {
        Contatos _contatos;
        Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Contatos();
            _fixture = new Fixture();
        } 

        [Test]
        public void ObterTodosOSContatosTest()
        {
            
            var contato1 =  _fixture.Create<Contato>();
            var contato2 = _fixture.Create<Contato>();

            //Executa
            _contatos.Adicionar(contato1);
            _contatos.Adicionar(contato2);

            var listaContatos = _contatos.ObterTodos();
            var contatoResultado01 = listaContatos.Where(x => x.Id == contato1.Id).FirstOrDefault();
            var contatoResultado02 = listaContatos.Where(x => x.Id == contato2.Id).FirstOrDefault();
            //Verificar
            Assert.AreEqual(listaContatos.Count() ,2);
            Assert.AreEqual(contato1.Id, contatoResultado01.Id);
            Assert.AreEqual(contato1.Nome, contatoResultado01.Nome);

            Assert.AreEqual(contato2.Id,    contatoResultado02.Id);
            Assert.AreEqual(contato2.Nome,  contatoResultado02.Nome);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}
