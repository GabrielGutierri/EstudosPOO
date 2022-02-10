using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Categoria> lista = Categoria.ListarCategorias();
            cbCategorias.DataSource = lista; //To string é aquele EX15.Categoria -> posso dar um override para mostrar bonitinho.
        }
        static List<Produto> listaProdutos = new List<Produto>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliar.VerificaCodigo(txtCodigo.Text))
                    throw new Exception("Código é obrigatório e deve ser maior que zero.");
                if (!Auxiliar.VerificaTexto(txtDescricao.Text))
                {
                    throw new Exception("Descrição obrigatória!");
                }
                Categoria categoriaSelecionada = cbCategorias.SelectedItem as Categoria;
                Produto produto = new Produto(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text, categoriaSelecionada);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
            foreach (var produto in listaProdutos)
            {
                lbLista.Items.Add($"{produto.Codigo} - {produto.Descricao} - {produto.Categoria.Descricao}");
            }
        }
    }
}
