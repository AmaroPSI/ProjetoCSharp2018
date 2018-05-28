using Index;
using ProjetoC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void pbcasa_Click(object sender, EventArgs e)
        {
            FormCasa interligar = new FormCasa();
            interligar.ShowDialog();
        }

        private void pbclientes_Click(object sender, EventArgs e)
        {
            FormCliente interligar = new FormCliente();
            interligar.ShowDialog();
        }
    }
}
