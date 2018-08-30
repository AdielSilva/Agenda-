using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class ListaContatos
    {

        private List<Contato> listaDeContatos;

        public List<Contato> ListaDeContatos { get { return listaDeContatos; } }

        public ListaContatos() { listaDeContatos = new List<Contato>(); }

        public void adicionar(Contato contato) { this.listaDeContatos.Add(contato); }

        public void remover(Contato contato) { this.listaDeContatos.Remove(contato); }

        public Contato pesquisar (Contato contato) { return this.listaDeContatos.FirstOrDefault(item => item.Equals(contato));  }

        public void alterar (Contato contato)
        {
            int index = this.ListaDeContatos.IndexOf(contato);
            this.ListaDeContatos[index] = contato;
        }   

        public bool excluir(Contato contato)
        {
            return listaDeContatos.Remove(contato);
        }

    }
}
