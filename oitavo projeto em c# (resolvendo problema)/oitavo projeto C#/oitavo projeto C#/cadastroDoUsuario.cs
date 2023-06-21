using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oitavo_projeto_C_
{
    internal class cadastroDoUsuario
    {
        private string nomeDoUsuario;
        private UInt32 idadeDoUsuario;
        private DateTime dataDeNascimento;
        private string nomeDaMae;
        private string numeroDoTelefone;

        public string usuarioNome
        {
            get { return nomeDoUsuario; }
            set { nomeDoUsuario = value; }
        }
        public UInt32 usuarioIdade
        {
            get { return idadeDoUsuario; }
            set { idadeDoUsuario = value; }
        }
        public DateTime usuarioNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }
        public string usuarioMae
        {
            get { return nomeDaMae; }
            set { nomeDaMae = value; }
        }

        public string usuarioTelefone
        {
            get { return numeroDoTelefone; }
            set { numeroDoTelefone = value; }
        }

        public cadastroDoUsuario(string nomeDoUsuario, uint idadeDoUsuario, DateTime dataDeNascimento, string nomeDaMae, string numeroDeTelefone)
        {
            this.nomeDoUsuario = nomeDoUsuario;
            this.idadeDoUsuario = idadeDoUsuario;
            this.dataDeNascimento = dataDeNascimento;
            this.nomeDaMae = nomeDaMae;
            this.numeroDoTelefone = numeroDeTelefone;

        }
    }
}

