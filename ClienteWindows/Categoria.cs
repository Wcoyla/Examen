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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        private static ServiceReference1.WebService1SoapClient servicio;
        private DataSet rpta;
        private void Categoria_Load(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.WebService1SoapClient();
            gvCategoria.DataSource = servicio.ListarCategoria().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string CategoryName = txtCategoryName.Text.Trim();
            string Description = txtDescription.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.AgregarCategories(CategoryName, Description);
            gvCategoria.DataSource = servicio.ListarCategoria().Tables[0];
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string CategoryID = txtCategoryID.Text.Trim();
            string CategoryName = txtCategoryName.Text.Trim();
            string Description = txtDescription.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.ActualizarCategories(CategoryID, CategoryName, Description);
            gvCategoria.DataSource = servicio.ListarCategoria().Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string CategoryID = txtCategoryID.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.EliminarCategoria(CategoryID);
            gvCategoria.DataSource = servicio.ListarCategoria().Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtCategoryName.Text.Trim();
            gvCategoria.DataSource = servicio.BuscarCategoria(Buscar).Tables[0];
        }
    }
}
