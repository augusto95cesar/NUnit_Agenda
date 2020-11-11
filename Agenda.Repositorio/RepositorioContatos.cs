using Agenda.DAL;
using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio
{
    public class RepositorioContatos
    {
       private readonly IContatos _contatos;
       private readonly ITelefones _telefones;

        public RepositorioContatos(IContatos contatos, ITelefones telefones)
        {
            _contatos = contatos;
            _telefones = telefones;
        }
        public IContato ObterContatoPorId(Guid id)
        {
            IContato contato = _contatos.ObterContato(id);
            contato.Telefones = _telefones.ObterTotosDoContato(id); 
            return contato;
        }
    }
}
