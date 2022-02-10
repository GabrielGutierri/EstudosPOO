using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX05
{
    public partial class frmCadastro : Form
    {
        private static int _posicaoAtual = 0;
        Aluno[] alunos = new Aluno[10];
        //Aluno aluno;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Nome = txtNome.Text.Trim();
                aluno.Nota1 = Convert.ToDouble(txtNota1.Text.Trim());
                aluno.Nota2 = Convert.ToDouble(txtNota2.Text.Trim());
                alunos[_posicaoAtual] = aluno;
                _posicaoAtual++;

                if(_posicaoAtual == 10)
                {
                    btnCadastrar.Enabled = false;
                }
            }
            
            catch(Exception err)
            {
                //aluno = null;
                MessageBox.Show(err.Message, "Dado inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //private void AdicionarAluno(int posicao, Aluno aluno)
        //{
        //    if (posicao >= alunos.Length)
        //        throw new Exception("Já foram cadastrados 10 alunos!");
        //    alunos[posicao] = aluno;
        //    txtDados.Text += $"{posicao + 1}: {aluno.Nome} - {aluno.Media}" + Environment.NewLine;
        //}

        private void btnExibir_Click(object sender, EventArgs e)
        {
            for(int i=0; i< _posicaoAtual; i++)
            {
                txtDados.Text += $" Nome: {alunos[i].Nome} - Nota 1: {alunos[i].Nota1} - Nota 2: {alunos[i].Nota2} - Média: {alunos[i].Media}" + Environment.NewLine;
            }
        }
    }
}
