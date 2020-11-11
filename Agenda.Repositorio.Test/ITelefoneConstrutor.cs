using Agenda.Domain;
using Agenda.Repositorio.Test.Base; 
using System; 

namespace Agenda.Repositorio.Test
{
    public class ITelefoneConstrutor : BaseConstrutorTest<ITelefone>
    {
        public ITelefoneConstrutor(): base() { }
        
        public static ITelefoneConstrutor Um()
        {
            return new ITelefoneConstrutor();
        } 

        public ITelefoneConstrutor ComId(Guid id)
        {
            _mock.SetupGet(x => x.Id).Returns(id);
            return this;
        }

        public ITelefoneConstrutor ComNumero(string numero)
        {
            _mock.SetupGet(x => x.Numero).Returns(numero);
            return this;
        }
        public ITelefoneConstrutor ComContatoId(Guid contatoId)
        {
            _mock.SetupGet(x => x.ContatoId).Returns(contatoId);
            return this;
        }
    }
}
