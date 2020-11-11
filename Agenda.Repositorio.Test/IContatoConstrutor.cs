using Agenda.Domain;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio.Test
{
    class IContatoConstrutor
    {
        private readonly Mock<IContato> _mockContato;
        private readonly Fixture _fixture;
        protected IContatoConstrutor(Mock<IContato> mockcontato, Fixture fixture)
        {
            _mockContato = mockcontato;
            _fixture = fixture;
        }
        public static IContatoConstrutor Um()
        {
            return new IContatoConstrutor(new Mock<IContato>(), new Fixture());
        }

        public IContato Construir()
        {
            return _mockContato.Object;
        }

        public Mock<IContato> Obter()
        {
            return _mockContato;
        }

        public IContatoConstrutor ComNome(string nome)
        {
            _mockContato.SetupGet(x => x.Nome).Returns(nome);
            return this;
        }

        public IContatoConstrutor ComId(Guid id)
        {
            _mockContato.SetupGet(x => x.Id).Returns(id);
            return this;
        }
    }
}
