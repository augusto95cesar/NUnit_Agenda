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
    public class ContatosTest: BaseTest
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
        public void IncluirContatoTest()
        {
            //Monta
            var contato = _fixture.Create<Contato>();
            //Executa
            _contatos.Adicionar(contato);

            //Verifica
            Assert.IsTrue(true);
        }

        [Test]
        public void ObterContatoTest()
        {
            //Monta
            var contato = _fixture.Create<Contato>();

            //Executa
            _contatos.Adicionar(contato);
            var nomeResult = _contatos.ObterContato(contato);

            //Verificar
            Assert.AreEqual(contato.Id, nomeResult.Id);
            Assert.AreEqual(contato.Nome, nomeResult.Nome);

        } 
        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}
