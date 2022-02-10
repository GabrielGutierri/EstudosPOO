using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoHeranca
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri RA:082200014 EC3
        List<AlunoBase> alunos = new List<AlunoBase>();

        public Form1()
        {
            InitializeComponent();
            cbFiltro.DataSource = Enum.GetValues(typeof(EnumCursos));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoEM a = new AlunoEM();
                a.RA = Convert.ToInt32(txtRA.Text);
                a.Nome = txtNomeAluno.Text;
                a.N1 = Convert.ToDouble(txtN1.Text);
                a.Faltas = Convert.ToInt32(txtFaltas.Text);
                a.N2 = Convert.ToDouble(txtN2_EM.Text);
                a.N3 = Convert.ToDouble(txtN3_EM.Text);
                a.Responsavel = txtResponsavel.Text;
                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoFTT a = new AlunoFTT();
                a.RA = Convert.ToInt32(txtRA.Text);
                a.Nome = txtNomeAluno.Text;
                a.Faltas = Convert.ToInt32(txtFaltas.Text);
                a.N1 = Convert.ToDouble(txtN1.Text);
                a.N2 = Convert.ToDouble(txtN2_FTT.Text);
                a.HorasEstagio = Convert.ToInt32(txtHorasEstagio.Text);

                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new AlunoPos();
                a.RA = Convert.ToInt32(txtRA.Text);
                a.Nome = txtNomeAluno.Text;
                a.N1 = Convert.ToDouble(txtN1.Text);
                a.Faltas = Convert.ToInt32(txtFaltas.Text);
                a.InstituicaoEnsinoSuperior = txtGraduacao.Text;

                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();

            foreach (AlunoBase aluno in alunos)
            {
                sb.AppendLine("RA: " + aluno.RA);
                sb.AppendLine("Nome: " + aluno.Nome);
                sb.AppendLine("N1: " + aluno.N1.ToString("0.0"));
                sb.AppendLine("Situação: " + aluno.VerificaSituacao().ToString());
                if (aluno is AlunoEM)
                {
                    sb.AppendLine("N2: " + (aluno as AlunoEM).N2.ToString("0.0"));
                    sb.AppendLine("N3: " + (aluno as AlunoEM).N3.ToString("0.0"));
                    sb.AppendLine("Responsável: " + (aluno as AlunoEM).Responsavel);
                }
                else if (aluno is AlunoFTT)
                {
                    sb.AppendLine("N2: " + (aluno as AlunoFTT).N2.ToString("0.0"));
                    sb.AppendLine("Horas de estágio: " + (aluno as AlunoFTT).HorasEstagio);
                }
                else
                {
                    sb.AppendLine("Graduado em: " + ((AlunoPos)aluno).InstituicaoEnsinoSuperior);
                }

                sb.AppendLine("Média: " + aluno.CalcularMedia().ToString("0.0"));
                sb.AppendLine("");
                sb.AppendLine("");
            }

            txtListagem.Text = sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();
            if (cbFiltro.SelectedIndex == 1)
            {
                foreach (AlunoBase aluno in alunos)
                {
                    if (aluno is AlunoEM)
                    {
                        sb.AppendLine(aluno.ToString());
                        sb.AppendLine("");
                        sb.AppendLine("");
                    }
                }
            }
            else if (cbFiltro.SelectedIndex == 2)
            {
                foreach (AlunoBase aluno in alunos)
                {
                    if (aluno is AlunoFTT)
                    {
                        sb.AppendLine(aluno.ToString());
                        sb.AppendLine("");
                        sb.AppendLine("");
                    }
                }
            }

            else if (cbFiltro.SelectedIndex == 3)
            {
                foreach (AlunoBase aluno in alunos)
                {
                    if (aluno is AlunoPos)
                    {
                        sb.AppendLine(aluno.ToString());
                        sb.AppendLine("");
                        sb.AppendLine("");
                    }
                }
            }
            else
            {
                foreach (AlunoBase aluno in alunos)
                {
                    sb.AppendLine(aluno.ToString());
                    sb.AppendLine("");
                    sb.AppendLine("");
                }
            }
            txtListagem.Text = sb.ToString();
        }


    }
}
