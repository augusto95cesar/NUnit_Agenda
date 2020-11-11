using Agenda.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio.Test
{
    public class ITelefoneConstrutor
    {
        //Criar Mock de ITelefone
        Mock<ITelefone> _mockTelefone;
        protected ITelefoneConstrutor(Mock<ITelefone> mTelefone)
        {
            _mockTelefone = mTelefone;
        }

        public static ITelefoneConstrutor Um()
        {
            return new ITelefoneConstrutor(new Mock<ITelefone>());
        }
        public ITelefone Construir()
        {
            return _mockTelefone.Object;
        }

        public ITelefoneConstrutor ComId(Guid id)
        {
            _mockTelefone.SetupGet(x => x.Id).Returns(id);
            return this;
        }

        public ITelefoneConstrutor ComNumero(string numero)
        {
            _mockTelefone.SetupGet(x => x.Numero).Returns(numero);
            return this;
        }
        public ITelefoneConstrutor ComContatoId(Guid contatoId)
        {
            _mockTelefone.SetupGet(x => x.ContatoId).Returns(contatoId);
            return this;
        }
    }
}
