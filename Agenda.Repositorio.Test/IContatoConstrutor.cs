using Agenda.Domain;
using Agenda.Repositorio.Test.Base;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio.Test
{
    class IContatoConstrutor: BaseConstrutorTest<IContato>
    {
        public IContatoConstrutor() : base() { }
        public static IContatoConstrutor Um()
        {
            return new IContatoConstrutor();
        } 

        public IContatoConstrutor ComNome(string nome)
        {
            _mock.SetupGet(x => x.Nome).Returns(nome);
            return this;
        }

        public IContatoConstrutor ComId(Guid id)
        {
            _mock.SetupGet(x => x.Id).Returns(id);
            return this;
        }
    }
}
