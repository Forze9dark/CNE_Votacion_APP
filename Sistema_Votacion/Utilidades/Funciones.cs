using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Votacion.Utilidades;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Sistema_Votacion.Utilidades
{
    class Funciones
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        System.Data.DataTable dt;

        public void importarExcel(DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new System.Data.DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumnas = 0;

            foreach (DataGridViewColumn col in  tabla.Columns)
            {
                IndiceColumnas++;
                excel.Cells[1, IndiceColumnas] = col.Name;
            }

            int IndiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndiceFila++;

                IndiceColumnas = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumnas++;
                    excel.Cells[IndiceFila + 1, IndiceColumnas] = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
        }
    }
}
