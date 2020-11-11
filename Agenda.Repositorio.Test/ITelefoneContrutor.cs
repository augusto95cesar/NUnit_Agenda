using Agenda.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio.Test
{
    public class ITelefoneContrutor
    {
        //Criar Mock de ITelefone
        Mock<ITelefone> _mTelefone;
        public ITelefoneContrutor(Mock<ITelefone> mTelefone)
        {
            _mTelefone = mTelefone;
        }
        //mTelefone.SetupGet(x => x.Id).Returns(telefoneId);
        //mTelefone.SetupGet(x => x.Numero).Returns("12312-78594");
        //mTelefone.SetupGet(x => x.ContatoId).Returns(contatoId);
    }
}
