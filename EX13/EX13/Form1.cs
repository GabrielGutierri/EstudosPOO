using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbSexo.Text = cbSexo.Items[0].ToString();
            cbEstadoCivil.Text = cbEstadoCivil.Items[0].ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, sexo, estadoCivil;
            DateTime dataNasc;
            int idade;
            try
            {
                bool auxiliarNome = Auxialiares.VerificaNome(txtNome.Text);
                DateTime dataConvertida = Convert.ToDateTime(mskData.Text);
                bool auxiliarData = Auxialiares.VerificaData(dataConvertida, out idade);
                Funcionario func = new Funcionario(txtNome.Text, cbSexo.SelectedIndex, cbEstadoCivil.SelectedIndex, dataConvertida);
                MessageBox.Show($"{func.Sexo} - {idade}");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
