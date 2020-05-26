using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class FrmAtleta : Form
    {
        public FrmAtleta()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.Idade = int.Parse(txt_idade.Text);
                obj.Altura = double.Parse(txt_altura.Text);
                obj.Peso = double.Parse(txt_peso.Text);
                MessageBox.Show("Dados Armazenados.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_imc_Click(object sender, EventArgs e)
        {
            txt_result.Text = obj.CalcularIMC().ToString("0.00");
        }
    }
}
