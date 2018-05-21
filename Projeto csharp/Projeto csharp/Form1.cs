using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_csharp
{
    public partial class Form1 : Form
    {
        private Arrendamento arrendamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arrendamento = new Arrendamento(comboBox1.Text, dateTimePicker1.Text,checkBox1.Text, numericUpDown1.Text);
            listBox1.Items.Add(arrendamento.ToString());
        }
    }
}
