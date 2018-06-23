using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoC
{
    public partial class FormCliente : Form
    {
        BindingSource bs = new BindingSource();
        private Cliente cliente;
        public FormCliente()
        {
            InitializeComponent();
            datagridclientes.ColumnCount = 3;
            datagridclientes.Columns[0].Name = "Nome";
            datagridclientes.Columns[1].Name = "NIF";
            datagridclientes.Columns[2].Name = "Contacto";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = "nome like '%" + textBox1.Text + "%'";
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listboxarrendamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ir buscar form arrendamentos com data de inicio,numero de meses e se é renovável ou não
        }

        private void listboxcasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ir buscar form casas com a base e o nome da cidade
        }

        private void listboxaquisicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ir buscar o nome da cidade e numero de casa e a data
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            tbnome.Enabled = true;
            tbnif.Enabled = true;
            tbmorada.Enabled = true;
            tbcontacto.Enabled = true;

        }
        private void verificarDetalhesPreenchidos()
        {
            if (tbnome.Text.Trim().Length > 0 && tbnif.Text.Trim().Length > 0 && tbmorada.Text.Trim().Length > 0 && tbcontacto.Text.Trim().Length > 0)
            {
                btnguardar.Enabled = true;
            }
            else
            {
                btnguardar.Enabled = false;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            verificarDetalhesPreenchidos();
   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.datagridclientes.Rows.Add(tbnome.Text, tbnif.Text, tbcontacto.Text);
            addData(tbnome.Text, tbnif.Text, tbcontacto.Text); ;
        }
        private void addData(string Nome, string NIF, string Contacto)
        {
            String[] row = { Nome, NIF, Contacto };
            datagridclientes.Rows.Add(row);
        }

        private void datagridclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            datagridclientes.Sort(datagridclientes.Columns[0], ListSortDirection.Ascending);
            datagridclientes.Sort(datagridclientes.Columns[1], ListSortDirection.Ascending);
            datagridclientes.Sort(datagridclientes.Columns[2], ListSortDirection.Ascending);
            
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
           
        this.datagridclientes.Rows.Remove(this.datagridclientes.CurrentRow);
           
        }
    }
}

