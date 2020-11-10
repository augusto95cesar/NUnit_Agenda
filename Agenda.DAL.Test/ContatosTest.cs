﻿using Agenda.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class ContatosTest
    {
        Contatos _contatos;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Contatos();
        }

        [Test]
        public void IncluirContatoTest()
        {
            //Monta
            var contato = new Contato() { Id = Guid.NewGuid(), Nome = "Marcos" }; 
            //Executa
            _contatos.Adicionar(contato);

            //Verifica
            Assert.IsTrue(true);
        }

        [Test]
        public void ObterContatoTest()
        {
            //Monta
            var contato = new Contato() { Id = Guid.NewGuid(), Nome = "Maria" };

            //Executa
            _contatos.Adicionar(contato);
            var nomeResult = _contatos.Obter(contato);

            //Verificar
            Assert.AreEqual(contato.Id, nomeResult.Id);
            Assert.AreEqual(contato.Nome, nomeResult.Nome);

        }

        [Test]
        public void ObterTodosOSContatosTest()
        {
            //Monta
            var contato1 = new Contato() { Id = Guid.NewGuid(), Nome = "Contato001" };
            var contato2 = new Contato() { Id = Guid.NewGuid(), Nome = "Contato002" };

            //Executa
            _contatos.Adicionar(contato1);
            _contatos.Adicionar(contato2);

            var listaContatos = _contatos.ObterTodos();
            var contatoResultado01 = listaContatos.Where(x => x.Id == contato1.Id).FirstOrDefault();
            var contatoResultado02 = listaContatos.Where(x => x.Id == contato2.Id).FirstOrDefault();
            //Verificar
            Assert.IsTrue(listaContatos.Count() > 1);
            Assert.AreEqual(contato1.Id, contatoResultado01.Id);
            Assert.AreEqual(contato1.Nome, contatoResultado01.Nome);

            Assert.AreEqual(contato2.Id,    contatoResultado02.Id);
            Assert.AreEqual(contato2.Nome,  contatoResultado02.Nome);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
        }
    }
}