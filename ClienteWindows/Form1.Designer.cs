
namespace ClienteWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaShippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.shippersToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // shippersToolStripMenuItem
            // 
            this.shippersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaShippersToolStripMenuItem});
            this.shippersToolStripMenuItem.Name = "shippersToolStripMenuItem";
            this.shippersToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.shippersToolStripMenuItem.Text = "Shippers";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tablaClienteToolStripMenuItem
            // 
            this.tablaClienteToolStripMenuItem.Name = "tablaClienteToolStripMenuItem";
            this.tablaClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablaClienteToolStripMenuItem.Text = "Tabla Cliente";
            this.tablaClienteToolStripMenuItem.Click += new System.EventHandler(this.tablaClienteToolStripMenuItem_Click);
            // 
            // tablaCategoriaToolStripMenuItem
            // 
            this.tablaCategoriaToolStripMenuItem.Name = "tablaCategoriaToolStripMenuItem";
            this.tablaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablaCategoriaToolStripMenuItem.Text = "Tabla Categoria";
            this.tablaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.tablaCategoriaToolStripMenuItem_Click);
            // 
            // tablaShippersToolStripMenuItem
            // 
            this.tablaShippersToolStripMenuItem.Name = "tablaShippersToolStripMenuItem";
            this.tablaShippersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablaShippersToolStripMenuItem.Text = "Tabla Shippers";
            this.tablaShippersToolStripMenuItem.Click += new System.EventHandler(this.tablaShippersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaShippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

