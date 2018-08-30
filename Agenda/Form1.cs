using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        ListaContatos listaContatos;
        public Form1()
        {
            InitializeComponent();
            IniciarComponentes();
            listaContatos = new ListaContatos();
        }

       public void IniciarComponentes()
       {
            //Eventos ONCLICK

            this.buttonNovo.Click+= new System.EventHandler(this.limparCampos);
            this.buttonGravar.Click += new System.EventHandler(adicionar);
            this.buttonAlterar.Click += new System.EventHandler(pesquisar);
            this.buttonListar.Click += new System.EventHandler(listar);
            this.buttonExcluir.Click += new System.EventHandler(excluir);
            
          
       }

        public void limparCampos(object e, EventArgs sender)
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefone.Text = "";

        }

        public void adicionar(object e, EventArgs sender )
        {
            listaContatos.adicionar(new Contato(this.textBoxNome.Text, this.textBoxEmail.Text, this.textBoxTelefone.Text));
            MessageBox.Show("O contato " + this.textBoxNome.Text + " foi incluido");
        }

        public void pesquisar(object e, EventArgs sender)
        {
            var x = this.listaContatos.pesquisar(new Contato(textBoxEmail.Text));

            if (listaContatos.pesquisar(new Contato(textBoxEmail.Text)) != null)
            {
                textBoxNome.Text = x.Nome;
                textBoxTelefone.Text = x.Numero;
            }
            else
                MessageBox.Show("Nenhum item encontrado!");

        }

        public void listar (object e, EventArgs sender)
        {
            listBox1.Items.Clear();

            this.listaContatos.ListaDeContatos.ForEach(item => listBox1.Items.Add(item.Email + " | " + item.Nome + " | " + item.Numero));
        }

        public void excluir (object e, EventArgs sender)
        {

            if (textBoxEmail.Text == "") MessageBox.Show("Digite o e-mail");


            if (this.listaContatos.excluir(new Contato(textBoxEmail.Text)))
            {
                MessageBox.Show("Excluído com Sucesso!");
                textBoxEmail.Text = "";
                textBoxNome.Text = "";
                textBoxTelefone.Text = "";
            }
            else
                MessageBox.Show("Falha ao excluir!");
        }

        
    }
}
