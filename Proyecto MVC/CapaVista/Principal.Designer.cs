
namespace CapaVista
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.verdata = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteConsumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoHacerUnPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoHacerUnaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.verdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // verdata
            // 
            this.verdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verdata.Location = new System.Drawing.Point(12, 101);
            this.verdata.Name = "verdata";
            this.verdata.Size = new System.Drawing.Size(467, 170);
            this.verdata.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "VISUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.eliminarReservaToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.reservasToolStripMenuItem.Text = "Ingresar Reserva";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // eliminarReservaToolStripMenuItem
            // 
            this.eliminarReservaToolStripMenuItem.Name = "eliminarReservaToolStripMenuItem";
            this.eliminarReservaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarReservaToolStripMenuItem.Text = "Eliminar reserva";
            this.eliminarReservaToolStripMenuItem.Click += new System.EventHandler(this.eliminarReservaToolStripMenuItem_Click);
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarReservasToolStripMenuItem.Text = "Consultar reservas";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteConsumosToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem,
            this.historialReservasToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // reporteConsumosToolStripMenuItem
            // 
            this.reporteConsumosToolStripMenuItem.Name = "reporteConsumosToolStripMenuItem";
            this.reporteConsumosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.reporteConsumosToolStripMenuItem.Text = "Reporte consumos";
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por cobrar";
            // 
            // historialReservasToolStripMenuItem
            // 
            this.historialReservasToolStripMenuItem.Name = "historialReservasToolStripMenuItem";
            this.historialReservasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.historialReservasToolStripMenuItem.Text = "Historial reservas";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.comprarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.comprarToolStripMenuItem.Text = "Comprar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoHacerUnPedidoToolStripMenuItem,
            this.comoHacerUnaReservaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comoHacerUnPedidoToolStripMenuItem
            // 
            this.comoHacerUnPedidoToolStripMenuItem.Name = "comoHacerUnPedidoToolStripMenuItem";
            this.comoHacerUnPedidoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.comoHacerUnPedidoToolStripMenuItem.Text = "Como hacer un pedido";
            // 
            // comoHacerUnaReservaToolStripMenuItem
            // 
            this.comoHacerUnaReservaToolStripMenuItem.Name = "comoHacerUnaReservaToolStripMenuItem";
            this.comoHacerUnaReservaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.comoHacerUnaReservaToolStripMenuItem.Text = "Como hacer una reserva";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.hoteles_w_920x515;
            this.ClientSize = new System.Drawing.Size(760, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verdata);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.verdata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView verdata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteConsumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoHacerUnPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoHacerUnaReservaToolStripMenuItem;
    }
}