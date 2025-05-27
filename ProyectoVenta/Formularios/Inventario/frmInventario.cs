using ClosedXML.Excel;
using ProyectoVenta.Herrarmientas;
using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProyectoVenta.Formularios.Inventario
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

            using (SQLiteConnection conexion = new SQLiteConnection(Logica.Conexion.cadena))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT DISTINCT NombreCompleto FROM PROVEEDOR", conexion);
                conexion.Open();
                SQLiteDataReader registro = cmd.ExecuteReader();
                while (registro.Read())
                {
                    cbobuscar.Items.Add(registro["NombreCompleto"].ToString());
                }
                conexion.Close();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string CadenaSQL =  "select DISTINCT * from (" +
                                    " select p.IdProducto,p.Codigo,p.Descripcion,p.Categoria,p.Almacen,p.Stock from DETALLE_ENTRADA de" +
                                    " inner join ENTRADA e on e.IdEntrada = de.IdEntrada" +
                                    " inner join PRODUCTO p on p.IdProducto = de.IdProducto where e.FechaRegistro BETWEEN '" + DE +"' and '"+A+ "'" +
                                    " UNION ALL" +
                                    " select p.IdProducto,p.Codigo,p.Descripcion,p.Categoria,p.Almacen,p.Stock from DETALLE_SALIDA ds" +
                                    " inner join SALIDA s on s.IdSalida = ds.IdSalida" +
                                    " inner join PRODUCTO p on p.IdProducto = ds.IdProducto where s.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                    ") prod" +
                                    " left join(" +
                                    " select p.IdProducto, sum(de.Cantidad)[Entradas], sum(CAST(de.SubTotal as NUMERIC))[TotalEgresos], e.NombreProveedor[Tienda] from PRODUCTO p" +
                                    " inner join DETALLE_ENTRADA de on de.IdProducto = p.IdProducto" +
                                    " inner  join ENTRADA e on e.IdEntrada = de.IdEntrada where e.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                    " group by p.IdProducto, p.Codigo, p.Descripcion, p.Categoria, p.Almacen" +
                                    ") ent on ent.IdProducto = prod.IdProducto" +
                                    " left join(" +
                                    " select p.IdProducto, sum(s.CantidadProductos)[Salidas], sum(CAST(ds.SubTotal as NUMERIC))[TotalIngresos], s.NombreCliente[Clientew] from PRODUCTO p" +
                                    " inner join DETALLE_SALIDA ds on ds.IdProducto = p.IdProducto" +
                                    " inner join SALIDA s on s.IdSalida = ds.IdSalida where s.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                    " group by p.IdProducto" +
                                    ") sal on sal.IdProducto = prod.IdProducto"+
                                    " left join(" +
                                    " select p.IdProducto, sum(ds.Cantidad)[Apartados] from PRODUCTO p" +
                                    " inner join APARTADO ds on ds.IdProducto = p.IdProducto" +
                                    " inner join SALIDA s on s.IdSalida = ds.IdSalida where s.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                    " group by p.IdProducto" +
                                    " ) apa on apa.IdProducto = prod.IdProducto";
                if (!String.IsNullOrEmpty(cbobuscar.Text))
                {
                    CadenaSQL = "select DISTINCT * from (" +
                                " select p.IdProducto,p.Codigo,p.Descripcion,p.Categoria,p.Almacen,p.Stock from DETALLE_ENTRADA de" +
                                " inner join ENTRADA e on e.IdEntrada = de.IdEntrada" +
                                " inner join PRODUCTO p on p.IdProducto = de.IdProducto where e.FechaRegistro BETWEEN '" + DE +"' and '"+A+ "'" +
                                " UNION ALL" +
                                " select p.IdProducto,p.Codigo,p.Descripcion,p.Categoria,p.Almacen,p.Stock from DETALLE_SALIDA ds" +
                                " inner join SALIDA s on s.IdSalida = ds.IdSalida" +
                                " inner join PRODUCTO p on p.IdProducto = ds.IdProducto where s.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                ") prod" +
                                " left join(" +
                                " select p.IdProducto, sum(de.Cantidad)[Entradas], sum(CAST(de.SubTotal as NUMERIC))[TotalEgresos], e.NombreProveedor[Tienda] from PRODUCTO p" +
                                " inner join DETALLE_ENTRADA de on de.IdProducto = p.IdProducto" +
                                " inner  join ENTRADA e on e.IdEntrada = de.IdEntrada where e.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                " group by p.IdProducto, p.Codigo, p.Descripcion, p.Categoria, p.Almacen" +
                                ") ent on ent.IdProducto = prod.IdProducto" +
                                " left join(" +
                                " select p.IdProducto, sum(s.CantidadProductos)[Salidas], sum(CAST(ds.SubTotal as NUMERIC))[TotalIngresos], s.NombreCliente[Clientew] from PRODUCTO p" +
                                " inner join DETALLE_SALIDA ds on ds.IdProducto = p.IdProducto" +
                                " inner join SALIDA s on s.IdSalida = ds.IdSalida where s.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                " group by p.IdProducto" +
                                ") sal on sal.IdProducto = prod.IdProducto where Tienda = '"+cbobuscar.Text+"'"+
                                " left join(" +
                                " select p.IdProducto, sum(ds.Cantidad)[Apartados] from PRODUCTO p" +
                                " inner join APARTADO ds on ds.IdProducto = p.IdProducto" +
                                " inner join SALIDA s on s.IdSalida = ds.IdSalida where s.FechaRegistro BETWEEN '" + DE + "' and '" + A + "'" +
                                " group by p.IdProducto" +
                                " ) apa on apa.IdProducto = prod.IdProducto";
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

        private void btnlimpiar_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
