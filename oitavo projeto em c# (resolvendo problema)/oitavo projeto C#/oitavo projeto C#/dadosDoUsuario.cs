using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oitavo_projeto_C_
{
    internal class dadosDoUsuario
    {
        //atributos da aplicação
        private List<cadastroDoUsuario> cadastrarUsuario;

        public void adicionarIndividuo(cadastroDoUsuario cUsuario)
        {
            cadastrarUsuario.Add(cUsuario);
        }
        public List<cadastroDoUsuario> procurarUsuarioTelefone(string pUsuario)
        {
            List<cadastroDoUsuario> listaUsuarioTemporaria = cadastrarUsuario.Where(x => x.usuarioTelefone == pUsuario).ToList();
            if ( listaUsuarioTemporaria.Count > 0)
            {
                return listaUsuarioTemporaria;
            } else
            {
                return null;
            }
        }

        public List<cadastroDoUsuario> removerUsuarioTelefone(string pUsuario)
        {
            List<cadastroDoUsuario> listaUsuarioTemporaria = cadastrarUsuario.Where(x => x.usuarioTelefone == pUsuario).ToList();
            if (listaUsuarioTemporaria.Count > 0)
            {
                foreach (cadastroDoUsuario usuario in listaUsuarioTemporaria)
                {
                    cadastrarUsuario.Remove(usuario);
                }
                return listaUsuarioTemporaria;
            }
            else
                return null;
        }

        //construtor dos dados do usuário

        public dadosDoUsuario()
        {
            cadastrarUsuario = new List<cadastroDoUsuario>();
        }
    }
}
