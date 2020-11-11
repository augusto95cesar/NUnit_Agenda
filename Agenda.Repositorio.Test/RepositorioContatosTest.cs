using Agenda.DAL;
using Agenda.Domain;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio.Test
{
    [TestFixture]
    public class RepositorioContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositorioContatos _repositorioContatos;


        [SetUp]
        public void SetUp() {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefone()
        {
            Guid telefoneId = Guid.NewGuid();
            Guid contatoId = Guid.NewGuid();
            List<ITelefone> lstTelefone = new List<ITelefone>();
            //montar
            //Criar MoCk de  IContatos
            Mock<IContato> mContato = new Mock<IContato>();
            mContato.SetupGet(x => x.Id).Returns(contatoId);
            mContato.SetupGet(x => x.Nome).Returns("João");
            //set
            mContato.SetupSet(x => x.Telefones = It.IsAny<List<ITelefone>>())
                    .Callback<List<ITelefone>>(p => lstTelefone = p);
            //Mock da função ObterPorI de IContatos
            _contatos.Setup(x => x.ObterContato(contatoId)).Returns(mContato.Object);

            //Criar Mock de ITelefone
            Mock<ITelefone> mTelefone = new Mock<ITelefone>();
            mTelefone.SetupGet(x => x.Id).Returns(telefoneId);
            mTelefone.SetupGet(x => x.Numero).Returns("12312-78594");
            mTelefone.SetupGet(x => x.ContatoId).Returns(contatoId);
            //Mock da funçaõ ObterTodosDoContato de ITelefone
            _telefones.Setup(x => x.ObterTotosDoContato(contatoId)).Returns(new List<ITelefone> { mTelefone.Object });

            //Excutar
            //Chamar o metodo ObterContatoPorId de RepositorioContatos
            IContato contatoResultado = _repositorioContatos.ObterContatoPorId(contatoId);
            mContato.SetupGet(x => x.Telefones).Returns(lstTelefone);
            //Verifica
            //Verificar se o Contato retornado Contém os mesmos dados do Moq
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(1, contatoResultado.Telefones.Count);
            Assert.AreEqual(mTelefone.Object.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mTelefone.Object.Id, contatoResultado.Telefones[0].Id);
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
        }


        [TearDown]
        public void TearDaown() 
        {
            _contatos = null;
            _telefones = null;                
        }
    }
}
