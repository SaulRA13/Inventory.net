using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using ClosedXML.Excel;
using System.IO;
//using ZipFile;

namespace ProyectoVenta.Logic
{
    public static class Archivos
    {
        #region Metodos Publicos

        #region Excel
        public static void GridToExcel(DataGridView dataGrid)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivo = saveFileDialog1.FileName;

                var dtGrid = GridToDataTable(dataGrid);

                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Sheet 1");

                #region Export
                //worksheet.Cell(1, 1).Value = "Hello, world!";

                //for (int i = 0; i < dtGrid.Columns.Count; i++)
                //{
                //    worksheet.Cell(i + 1, 1).Value = "Hello, world!";

                //    for (int j = 0; j < dtGrid.Rows.Count; j++)
                //    {
                //        worksheet.Cell(i + 1, j + 1).Value = "Hello, world!";
                //    }
                //}
                #endregion


                for (int i = 0; i < dtGrid.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dtGrid.Columns[i].ColumnName;
                }

                int numRow = 0;
                foreach (DataRow dr in dtGrid.Rows)
                {
                    for (int i = 0; i < dtGrid.Columns.Count; i++)
                    {
                        worksheet.Cell(numRow + 2, i + 1).Value = dr[i].ToString();
                    }
                    numRow++;
                }

                //workbook.SaveAs("c:\\temp\\excel.xlsx");
                try
                {
                    workbook.SaveAs(@archivo);
                    MessageBox.Show("Archivo generado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error al exportar el archivo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void WriteToExcel(string rutaOrigen, string rutaDestino)
        {
            //DataTable dtOrigen = ReadXML(rutaOrigen, true);
            string fileName = @rutaDestino;
            var workbook = new XLWorkbook(fileName);
            var ws1 = workbook.Worksheet(1);

            ws1.Row(1).Cell(1).Value = "VALOR 1";
            ws1.Row(1).Cell(2).Value = "VALOR 2";
            ws1.Row(1).Cell(3).Value = "VALOR 3";

            ws1.Row(2).Cell(1).Value = "Hola";
            ws1.Row(2).Cell(2).Value = "Texto";
            ws1.Row(2).Cell(3).Value = "Word";

            //var lastCol = ws1.LastColumn();
            //var lastRow = ws1.LastRow();

            //var firstCell = ws1.FirstCell();
            //var lastCell = ws1.LastCell();

            //IXLRange rangoPaginaFull = ws1.Range(firstCell, lastCell);
            //rangoPaginaFull.Cells().Style.Fill.BackgroundColor = XLColor.White;


            IXLRange range = ws1.Range("A1:C1");
            range.Cells().Style.Font.Bold = true;
            range.Cells().Style.Fill.BackgroundColor = XLColor.Yellow;
            range.Cells().Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
            range.Cells().Style.Border.OutsideBorderColor = XLColor.Black;

            //ws1.Columns(2, 20).AdjustToContents();
            ws1.Columns().AdjustToContents();
            workbook.Save();
        }

        public static DataTable ReadXML(string rutaXML, bool tieneHeader)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string fileName = @rutaXML;
                var workbook = new XLWorkbook(fileName);
                var ws1 = workbook.Worksheet(1);

                var totalRows = ws1.RangeUsed().RowCount();
                var totalColumnas = ws1.RangeUsed().ColumnCount();
                if (tieneHeader)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        var row = ws1.Row(i + 1);
                        DataRow rowXML = dataTable.NewRow();
                        for (int j = 1; j <= totalColumnas; j++)
                        {
                            dataTable.Columns.Add(row.Cell(j).Value.ToString());
                        }
                    }

                    for (int i = 1; i < totalRows; i++)
                    {
                        var row = ws1.Row(i + 1);
                        DataRow rowXML = dataTable.NewRow();
                        for (int j = 1; j <= totalColumnas; j++)
                        {
                            rowXML[j - 1] = row.Cell(j).Value;
                        }
                        dataTable.Rows.Add(rowXML);
                    }
                }
                else
                {
                    for (int i = 1; i <= totalColumnas; i++)
                    {
                        dataTable.Columns.Add("Col_" + i);
                    }

                    for (int i = 0; i < totalRows; i++)
                    {
                        var row = ws1.Row(i + 1);
                        DataRow rowXML = dataTable.NewRow();
                        for (int j = 1; j <= totalColumnas; j++)
                        {
                            rowXML[j - 1] = row.Cell(j).Value;
                        }
                        dataTable.Rows.Add(rowXML);
                    }
                }
                workbook.Save();
            }
            catch
            {
            }

            return dataTable;
        }

        public static DataTable GridToDataTable(DataGridView dataGridView)
        {
            try
            {
                DataTable dt = new DataTable(dataGridView.Name);

                //Adding the Columns.
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows.
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        if (cell.Value.ToString() == null)
                        {
                            cell.Value = "0";
                        }
                    }
                }
                return dt;
            }
            catch
            {
                MessageBox.Show("No hay registros en la tabla");
                DataTable dt = new DataTable(dataGridView.Name);
                return dt;

            }
        }

        #endregion

        #region Generales
        public static void AbrirArchivo(string rutaArchivo = "")
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("No se encontro archivo en la ruta especificada.", "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rutaArchivo = string.Empty;
            }

            if (string.IsNullOrEmpty(rutaArchivo))
            {
                rutaArchivo = SeleccionaArchivo();
            }

            try
            {
                Process p = new Process();
                p.StartInfo.FileName = rutaArchivo;
                p.Start();
            }
            catch
            {
                MessageBox.Show("No fue posible abrir archivo.", "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }
        public static void EliminarArchivo(string rutaArchivo = "")
        {
            if (!File.Exists(rutaArchivo) || string.IsNullOrEmpty(rutaArchivo))
            {
                rutaArchivo = SeleccionaArchivo();
            }
            File.Delete(rutaArchivo);
        }
        public static bool MoverArchivo(string rutaOrigen, string rutaDestino)
        {
            bool seMovio;
            try
            {
                if (File.Exists(rutaDestino))
                {
                    File.Delete(rutaDestino);
                }

                File.Move(rutaOrigen, rutaDestino);
                seMovio = true;

                if (File.Exists(rutaOrigen))
                {
                    Console.WriteLine("The original file still exists, which is unexpected.");
                }
                else
                {
                    Console.WriteLine("The original file no longer exists, which is expected.");
                }
            }
            catch
            {
                seMovio = false;
            }
            return seMovio;
        }
        public static bool CopiarArchivo(string rutaOrigen, string rutaDestino)
        {
            bool seCopio;
            try
            {
                if (File.Exists(rutaDestino))
                {
                    File.Delete(rutaDestino);
                }

                File.Copy(rutaOrigen, rutaDestino);
                seCopio = true;

                if (File.Exists(rutaDestino))
                {
                    Console.WriteLine("The new copy file exists.");
                }
                else
                {
                    Console.WriteLine("It didn't copy");
                }
            }
            catch
            {
                seCopio = false;
            }
            return seCopio;
        }
        //public static void ComprimirArchivo(string rutaOrigen, string rutaDestino)
        //{
        //    ZipFile.CreateFromDirectory(rutaOrigen, rutaDestino);
        //}
        //public static void DescomprimirArchivo(string rutaOrigen, string rutaDestino)
        //{
        //    ZipFile.ExtractToDirectory(rutaOrigen, rutaDestino);
        //}
        public static void CrearFolder(string rutaFolder)
        {
            try
            {
                //if (Directory.Exists(rutaFolder))
                //{
                //    Console.WriteLine("That path exists already.");
                //    return;
                //}

                DirectoryInfo di = Directory.CreateDirectory(rutaFolder);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(rutaFolder));

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
        public static void EliminarFolder(string rutaFolder)
        {
            try
            {
                //if (Directory.Exists(rutaFolder))
                //{
                //    Console.WriteLine("That path exists already.");
                //    return;
                //}

                if (DialogResult.OK == MessageBox.Show("¿Eliminar carpeta?", "Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Directory.Delete(rutaFolder, true);
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
        #endregion

        #region LeerArchivos
        public static List<string> LeerArchivoTextoLista(string rutaArchivo = "")
        {
            List<string> archivoTexto = new List<string>();

            if (string.IsNullOrEmpty(rutaArchivo))
            {
                rutaArchivo = SeleccionaArchivo();
            }

            if (File.Exists(rutaArchivo))
            {
                string[] lines = File.ReadAllLines(rutaArchivo);
                foreach (string line in lines)
                {
                    archivoTexto.Add(line);
                }
            }
            return archivoTexto;
        }
        public static string LeerArchivoTextoCadena(string rutaArchivo = "")
        {
            string archivoTexto = string.Empty;

            if (string.IsNullOrEmpty(rutaArchivo))
            {
                rutaArchivo = SeleccionaArchivo();
            }

            if (File.Exists(rutaArchivo))
            {
                archivoTexto = File.ReadAllText(rutaArchivo);
            }
            return archivoTexto;
        }
        public static List<string> LeerArchivoXML(string rutaArchivo = "")
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                rutaArchivo = SeleccionaArchivo();
            }
            List<string> listaXML = new List<string>();

            XmlTextReader xmlReader = new XmlTextReader(rutaArchivo);
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        listaXML.Add("<" + xmlReader.Name + ">");
                        break;
                    case XmlNodeType.Text:
                        listaXML.Add(xmlReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        listaXML.Add("");
                        break;
                }
            }
            return listaXML;
        }
        public static string LeerArchivoPDF(string rutaArchivo = "")
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                rutaArchivo = SeleccionaArchivo();
            }

            string pdfToText = string.Empty;
            PdfReader reader = new PdfReader(rutaArchivo);

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                pdfToText += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();

            //Funcion para dividir cadena por salto de linea.
            //var pdfSplit = pdfToText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            return pdfToText;
        }
        #endregion
        #endregion

        #region Metodos Privados
        private static string SeleccionaArchivo()
        {
            string rutaSel = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaSel = openFileDialog1.FileName;
            }

            return rutaSel;
        }
        #endregion
    }
}