using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario novo = new Funcionario();
            try
            {
                novo.Codigo = Convert.ToInt32(txtCodigo.Text);
                novo.Nome = txtNome.Text;
                novo.RG = maskedTextBox1.Text;
                novo.Salario = Convert.ToDouble(txtSalario.Text);

                txtResultados.Text = $"Código: {novo.Codigo}"+Environment.NewLine+$"Nome: {novo.Nome}"
                    +Environment.NewLine+$"RG: {novo.RG}"+Environment.NewLine+ $"Salário:{novo.Salario}"
                     + Environment.NewLine +$"INSS: {novo.Inss}"+Environment.NewLine+$"Salário com INSS: {novo.CalculaSalario}";
            }
            catch (FormatException fErr)
            {
                MessageBox.Show($"formato incorreto: {fErr.Message} - {fErr.StackTrace}");
            }
            catch(Exception err)
            {
                novo = null;
                MessageBox.Show(err.Message);
            }
        }
    }
}
