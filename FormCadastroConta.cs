using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoBanco.Contas;

namespace projetoBanco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            ContaCorrente novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
           //novaConta.Numero = Convert.ToInt32(textoNumero.Text);
            this.formPrincipal.AddConta(novaConta);
            this.Dispose();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
}
