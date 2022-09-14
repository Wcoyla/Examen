using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tablaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void tablaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
        }

        private void tablaShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shippers shippers = new Shippers();
            shippers.Show();
        }
    }
}
