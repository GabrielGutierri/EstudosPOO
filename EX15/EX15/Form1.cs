using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX15
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        public Form1()
        {
            InitializeComponent();
            List<Categoria> lista = Categoria.ListarCategorias();
            cbCategorias.DataSource = lista;
            cbCategorias.DisplayMember = "Descricao";

        }

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
                Categoria categoriaSelecionada = (Categoria)cbCategorias.SelectedItem;
               
                Produto produto = new Produto(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text, categoriaSelecionada.Descricao);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            foreach (var produto in Auxiliar.listaProdutos)
            {
                lbLista.Items.Add($"Produto: {produto.Descricao} - Código: {produto.Codigo} - Categoria: {produto.Categoria}");
            }
        }
    }
}
