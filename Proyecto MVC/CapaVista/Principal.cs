using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Principal : Form
    {
        String tabla = "reservacion";
        Controlador cont = new Controlador();
        Insertar inser = new Insertar();
        Habitaciones habi = new Habitaciones();

        public Principal()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA


        public void actualizardatagriew()
        {
            DataTable dt = cont.llenarTbl(tabla);
            verdata.DataSource = dt;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inser.Show();
        }

        private void eliminarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que desea eliminar registro?");
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habi.Show();
        }
    }
}
