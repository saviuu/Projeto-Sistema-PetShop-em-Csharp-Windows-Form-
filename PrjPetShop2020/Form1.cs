using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjPetShop2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja SAIR?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            //Adiciona o form de cliente no painel central

            FormCadCliente formCadCliente = new FormCadCliente();
            formCadCliente.TopLevel = false;
            formCadCliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); //Limpa o painel
            panelCentral.Controls.Add(formCadCliente);
            formCadCliente.Show();

            //apica a posição do eixo X do botao ao panelSelecao
            panelSelecao.Top = buttonCliente.Top;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {

            panelCentral.Controls.Clear(); //Limpa o painel
            panelSelecao.Top = buttonInicio.Top;
        }

        private void panelSelecao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            //Adiciona o form de Animal no painel central

            FormAnimais formAnimais = new FormAnimais();
            formAnimais.TopLevel = false;
            formAnimais.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); //Limpa o painel
            panelCentral.Controls.Add(formAnimais);
            formAnimais.Show();

            //apica a posição do eixo X do botao ao panelSelecao
            panelSelecao.Top = buttonAnimal.Top;
        }

        private void buttonRaca_Click(object sender, EventArgs e)
        {
            FormRacas formRacas = new FormRacas();
            formRacas.TopLevel = false;
            formRacas.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formRacas);
            formRacas.Show();

            //apica a posição do eixo X do botao ao panelSelecao
            panelSelecao.Top = buttonRaca.Top;


        }

        private void buttonServico_Click(object sender, EventArgs e)
        {
            FormServicos formServicos = new FormServicos();
            formServicos.TopLevel = false;
            formServicos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formServicos);
            formServicos.Show();

            //apica a posição do eixo X do botao ao panelSelecao
            panelSelecao.Top = buttonServico.Top;

        }

        private void buttonAgendamento_Click(object sender, EventArgs e)
        {
            FormAgendamentos formAgendamentos = new FormAgendamentos();
            formAgendamentos.TopLevel = false;
            formAgendamentos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formAgendamentos);
            formAgendamentos.Show();

            //apica a posição do eixo X do botao ao panelSelecao
            panelSelecao.Top = buttonAgendamento.Top;
        }
    }
}
