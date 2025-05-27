using ClosedXML.Excel;
using ProyectoVenta.Herrarmientas;
using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta.Formularios.Salidas
{
    public partial class frmListarSalidas : Form
    {
        public frmListarSalidas()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarSalidas_Load(object sender, EventArgs e)
        {
            //foreach (DataGridViewColumn cl in dgvdata.Columns)
            //{
            //    if (cl.Visible == true && cl.Name != "btnseleccionar")
            //    {
            //        cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
            //    }
            //}
            //cbobuscar.DisplayMember = "Texto";
            //cbobuscar.ValueMember = "Valor";
            //cbobuscar.SelectedIndex = 0;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // dgvdata.Rows.Clear();

            DateTime F1 = new DateTime(txtfechafin.Value.Year, txtfechafin.Value.Month, txtfechafin.Value.Day);
            string A = F1.ToString("yyyy-MM-dd");

            DateTime F2 = new DateTime(txtfechainicio.Value.Year, txtfechainicio.Value.Month, txtfechainicio.Value.Day);
            string DE = F2.ToString("yyyy-MM-dd");

            using (SQLiteConnection conexion = new SQLiteConnection(Logica.Conexion.cadena))
            {
                string CadenaSQL = "select e.NumeroDocumento[Numero Documento],de.CodigoProducto[Codigo],de.DescripcionProducto[Tipo de Lente]," +
                                   " de.CategoriaProducto [Marca],de.AlmacenProducto [Color]," +
                                   " e.DocumentoCliente [Ticket Cliente],e.NombreCliente [Nombre Cliente]," +
                                   " e.UsuarioRegistro [Usuario que registra],strftime('%d/%m/%Y', date(e.FechaRegistro))[FechaRegistro],de.PrecioVenta [Precio de venta],de.Cantidad [Cantidad],de.SubTotal [Subtotal], e.MontoTotal [Total]" +
                                   " from SALIDA e" +
                                   " inner join DETALLE_SALIDA de on e.IdSalida = de.IdSalida" +
                                   " where DATE(e.FechaRegistro) BETWEEN '" + DE + "' AND '" + A + "'" +
                                   " UNION ALL" +
                                   " select e.NumeroDocumento [Numero Documento],de.CodigoProducto [Codigo],de.DescripcionProducto [Tipo de Lente]," +
                                   " de.CategoriaProducto [Marca],de.AlmacenProducto [Color]," +
                                   " e.DocumentoCliente [Ticket Cliente],e.NombreCliente [Nombre Cliente]," +
                                   " e.UsuarioRegistro [Usuario que registra],strftime('%d/%m/%Y', date(e.FechaRegistro))[FechaRegistro],de.PrecioVenta [Precio de venta],de.Cantidad [Cantidad],de.SubTotal [Subtotal], e.MontoTotal [Total]" +
                                   " from SALIDA e" +
                                   " inner join APARTADO de on e.IdSalida = de.IdSalida" +
                                   " where DATE(e.FechaRegistro) BETWEEN '" + DE + "' AND '" + A + "'";

                if (!String.IsNullOrEmpty(cbobuscar.Text) && cbobuscar.Text == "Apartados")
                {
                    CadenaSQL = "select e.NumeroDocumento [Numero Documento],de.CodigoProducto [Codigo],de.DescripcionProducto [Tipo de Lente]," +
                                " de.CategoriaProducto [Marca],de.AlmacenProducto [Color]," +
                                " e.DocumentoCliente [Ticket Cliente],e.NombreCliente [Nombre Cliente]," +
                                " e.UsuarioRegistro [Usuario que registra],strftime('%d/%m/%Y', date(e.FechaRegistro))[FechaRegistro],de.PrecioVenta [Precio de venta],de.Cantidad [Cantidad],de.SubTotal [Subtotal], e.MontoTotal [Total]" +
                                " from SALIDA e" +
                                " inner join APARTADO de on e.IdSalida = de.IdSalida" +
                                " where DATE(e.FechaRegistro) BETWEEN '" + DE + "' AND '" + A + "'";
                }
                else if (!String.IsNullOrEmpty(cbobuscar.Text) && cbobuscar.Text == "Pagados")
                {
                    CadenaSQL = "select e.NumeroDocumento [Numero Documento],de.CodigoProducto [Codigo],de.DescripcionProducto [Tipo de Lente]," +
                                " de.CategoriaProducto [Marca],de.AlmacenProducto [Color]," +
                                " e.DocumentoCliente [Ticket Cliente],e.NombreCliente [Nombre Cliente]," +
                                " e.UsuarioRegistro [Usuario que registra],strftime('%d/%m/%Y', date(e.FechaRegistro))[FechaRegistro],de.PrecioVenta [Precio de venta],de.Cantidad [Cantidad],de.SubTotal [Subtotal], e.MontoTotal [Total]" +
                                " from SALIDA e" +
                                " inner join DETALLE_SALIDA de on e.IdSalida = de.IdSalida" +
                                " where DATE(e.FechaRegistro) BETWEEN '" + DE + "' AND '" + A + "'";
                }
                conexion.Open();
                SQLiteDataAdapter Adaptador = new SQLiteDataAdapter(CadenaSQL, conexion);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS);
                dgvdata.DataSource = DS.Tables[0];
                conexion.Close();
                dgvdata.Visible = true;
                //Archivos.GridToExcel(dgvReporte);
            }
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Logic.Archivos.GridToExcel(dgvdata);
        }
    }
}
