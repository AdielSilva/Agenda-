using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contato
    {
        #region Atributos 

        private string nome;
        private string numero;
        private string email;
        #endregion

        #region Propriedades
        public string Nome { get { return nome; } set { nome = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string Email { get { return email; } set { email = value; } }

        #endregion

        #region Construtores

        public Contato(string nome, string numero, string email)
        {

            this.nome = nome;
            this.numero = numero;
            this.email = email;
        }



        public Contato() : this("", "", "")
        { }

        public Contato(string email)
        {
            this.email = email;
        }
        #endregion

        #region Sobreescrita Equals

        public override bool Equals(object obj)
          {
              Contato amostra = (Contato)obj;
              return this.email.Equals(amostra.email);
          }
          #endregion 

        #region Metodos Funcionais
        public string dados()
        {
            return  this.nome + this.numero  + this.email ;
        }

        #endregion
    }
}
