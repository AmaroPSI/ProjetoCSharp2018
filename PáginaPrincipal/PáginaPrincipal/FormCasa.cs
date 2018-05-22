using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class FormCasa : Form
    {
        private Casa casaadd;
        public FormCasa()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LabelProprietario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void CheckBoxArrendável_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            label3.Enabled = false;
            label2.Enabled = false;
            label6.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            textBox8.Enabled = false;
            button2.Enabled = false;
            CheckBoxVendável.Enabled = false;
            CheckBoxArrendável.Enabled = false;
        }

        private void CheckBoxVendável_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            label1.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            textBox7.Enabled = false;
            button3.Enabled = false;
            CheckBoxVendável.Enabled = false;
            CheckBoxArrendável.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(tbid.Text, tblocalidade.Text, tbrua.Text);
        }

        private void TBNumero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            tbid.Enabled = true;
            tblocalidade.Enabled = true;
            tbrua.Enabled = true;
            tbnumero.Enabled = true;
        }
    }
}