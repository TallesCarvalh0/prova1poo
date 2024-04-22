using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prova2Talles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GerarGradelistView();
        }

        private void GerarGradelistView()
        {
            listView1.Columns.Add("Placa", 120).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Ano", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Assentos", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Eixos", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Diaria", 100).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;
        }
        private void Limpar()
        {
            tbAno.Text = "";
            tbQtdAssentos.Text="";
            tbQtdEixos.Text=""; 
            mtbPlaca.Text="";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mtbPlaca.Mask = "AAA-0000";


            pbOnibus.Visible = true;
            lbQtdAssentos.Visible = true;
            tbQtdAssentos.Visible = true;

            lbPlaca.Visible = true;
            mtbPlaca.Visible = true;
            lbAno.Visible = true;
            tbAno.Visible = true;
            btCadastrar.Visible = true;
            btLimpar.Visible = true;
            listView1.Visible = true;

            pbCaminhao.Visible = false;
            lbQtdEixos.Visible = false;
            tbQtdEixos.Visible = false;
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtbPlaca.Mask = "AAA-0000";

            pbCaminhao.Visible = true;
            lbQtdEixos.Visible = true;
            tbQtdEixos.Visible = true;

            lbPlaca.Visible = true;
            mtbPlaca.Visible = true;
            lbAno.Visible = true;
            tbAno.Visible = true;
            btCadastrar.Visible = true;
            btLimpar.Visible = true;
            listView1.Visible = true;

      
            pbOnibus.Visible = false;
            lbQtdAssentos.Visible = false;
            tbQtdAssentos.Visible = false;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            
            string placa = mtbPlaca.Text;
            string ano = tbAno.Text;
            string assentos = tbQtdAssentos.Text;
            string eixos = tbQtdEixos.Text;

            
            if (!string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(ano) && !string.IsNullOrEmpty(assentos))
            {
                double diaria = Calculo_Aluguel_onibus(Convert.ToInt32(ano), Convert.ToInt32(assentos));
                string[] row = new string[] { placa, ano, assentos, eixos, diaria.ToString("C2") };

         
                ListViewItem item = new ListViewItem(row);

                
                listView1.Items.Add(item);

                
                Limpar();
            }
            else if (!string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(ano) && !string.IsNullOrEmpty(eixos))
            {

                double diaria = Calculo_Aluguel_caminhao(Convert.ToInt32(ano), Convert.ToInt32(eixos));
                
                string[] row = new string[] { placa, ano, assentos, eixos, diaria.ToString("C2") };

                ListViewItem item = new ListViewItem(row);

             
                listView1.Items.Add(item);

    
                Limpar();
            }


            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para calcular a diária
        private double Calculo_Aluguel_onibus(int ano, int nroAssentos)
        {
            double valor_diaria;
            valor_diaria = (30 * nroAssentos) - (2024 - ano) * 70;
            return valor_diaria;
        }

        private double Calculo_Aluguel_caminhao(int ano, int nroEixos)
        {
            double valor_diaria;
            valor_diaria = (300 * nroEixos) - (2024 - ano) * 50;
            return valor_diaria;
        }

        private void mtbPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtbPlaca.Mask = "AAA-0000";
        }

        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
