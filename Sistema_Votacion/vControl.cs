using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using LinqToExcel;
using Sistema_Votacion.Utilidades;
using System.Threading;
using System.Media;
using System.IO;

namespace Sistema_Votacion
{
    public partial class vControl : Form
    {
        // Variable del numero del ganador seleccionado
        int actual_ganador_seleccionado;

        // Variable Global de Ganador y su Departamento
        string cargoNameAleatorio;
        string GanadorNameAleatorio;
        string PremioName;

        // Funcion de sonido
        SoundPlayer Player = new SoundPlayer();

        public vControl()
        {
            InitializeComponent();
            timer1.Start();
        }
      
        // Buscar Empleado
        private async void btn_get_empleados_Click(object sender, EventArgs e)
        {
            string ruta_completa_mp3 = Path.Combine(Application.StartupPath, @"sound-effect.wav");
            Player.SoundLocation = ruta_completa_mp3;
            Player.Play();

            // Cancelamos otras acciones
            btn_presente.Visible = false;
            btn_get_empleados.Enabled = false;
            btn_ausente.Visible = false;
            Properties.Settings.Default.btn_get_premio = false;
            Properties.Settings.Default.emp_ganador = "";
            Properties.Settings.Default.premio_ganador = "";
            lblGanadorEmp.Text = "";
            lbldepacontrol.Text = "";

            // Cuenta cuantas filas tiene el documento
            int rowCount = gridGanadores.Rows.Count - 1;

            Random rnd = new Random();
            
            // Verdadero ganador
            int true_index = rnd.Next(0, rowCount); // #
            string true_cargo = gridGanadores.Rows[true_index].Cells[2].Value.ToString(); // Departamento
            string true_Name = gridGanadores.Rows[true_index].Cells[1].Value.ToString(); // Nombre Ganador

            // Animacion de Conteo
            for (int p = 0; p < 50; p++)
            {
                int index = rnd.Next(0, rowCount);
                cargoNameAleatorio = gridGanadores.Rows[index].Cells[2].Value.ToString();
                lbldepacontrol.Text = cargoNameAleatorio;
                Properties.Settings.Default.departamento_emp_ganador = cargoNameAleatorio;
                await Task.Delay(50);

                gridGanadores.ClearSelection();
                gridGanadores.Rows[index].Selected = true;
                
            }

            cargoNameAleatorio = true_cargo;
            lbldepacontrol.Text = cargoNameAleatorio;
            Properties.Settings.Default.departamento_emp_ganador = cargoNameAleatorio;

            for (int p = 0; p < 40; p++)
            {
                int index = rnd.Next(0, rowCount);
                GanadorNameAleatorio = gridGanadores.Rows[index].Cells[1].Value.ToString();
                lblGanadorEmp.Text = GanadorNameAleatorio;
                Properties.Settings.Default.emp_ganador = GanadorNameAleatorio;
                
                await Task.Delay(50);

                gridGanadores.ClearSelection();
                gridGanadores.Rows[index].Selected = true;

            }

            GanadorNameAleatorio = true_Name;
            lblGanadorEmp.Text = GanadorNameAleatorio;
            Properties.Settings.Default.emp_ganador = GanadorNameAleatorio;

            actual_ganador_seleccionado = true_index;

            gridGanadores.Rows.Remove(gridGanadores.Rows[actual_ganador_seleccionado]);


            btn_presente.Visible = true;
            btn_ausente.Visible = true;


        }

        // Boton Presente
        private async void btn_presente_Click(object sender, EventArgs e)
        {

            // Botones
            btn_get_empleados.Enabled = true;
            btn_presente.Visible = false;
            btn_ausente.Visible = false;

            // Cuenta cuantas filas tiene el documento
            int rowCount = gridPremios.Rows.Count - 1;

            Random rnd = new Random();

            // Premio Ganado
            int true_index = rnd.Next(0, rowCount); // #
            string true_premio = gridPremios.Rows[true_index].Cells[1].Value.ToString(); // Premio

            // Animacion de Conteo
            for (int i = 0; i < 50; i++)
            {

                int index = rnd.Next(0, rowCount);
                PremioName = gridPremios.Rows[index].Cells[1].Value.ToString();
                Properties.Settings.Default.premio_ganador = PremioName;
                await Task.Delay(50);

                gridPremios.ClearSelection();
                gridPremios.Rows[index].Selected = true;
            }

            PremioName = true_premio;
            Properties.Settings.Default.premio_ganador = PremioName;

            actual_ganador_seleccionado = true_index;

            gridPremios.Rows.Remove(gridPremios.Rows[actual_ganador_seleccionado]);

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gridGanadores);
            fila.Cells[0].Value = Properties.Settings.Default.departamento_emp_ganador;
            fila.Cells[1].Value = Properties.Settings.Default.emp_ganador;
            fila.Cells[2].Value = Properties.Settings.Default.premio_ganador;

            Historial_Ganadores.Rows.Add(fila);

            // Reproducir Sonido!

            string ruta_completa_wav = Path.Combine(Application.StartupPath, @"grat.wav");
            
            Player.SoundLocation = ruta_completa_wav;
            Player.Play();

        }

        // Boton Ausente
        private void btn_ausente_Click(object sender, EventArgs e)
        {
            // Botones
            btn_get_empleados.Enabled = true;
            btn_presente.Visible = false;
            btn_ausente.Visible = false;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gridGanadores);
            fila.Cells[0].Value = Properties.Settings.Default.departamento_emp_ganador;
            fila.Cells[1].Value = Properties.Settings.Default.emp_ganador;
            fila.Cells[2].Value = "Ausente";

            Historial_Ganadores.Rows.Add(fila);

            btn_get_empleados.PerformClick();
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.premio_ganador))
            {
                btnExportarExcel.Visible = false;

            } else
            {
                btnExportarExcel.Visible = true;
            }
        }

        private void vControl_Load(object sender, EventArgs e)
        {
            
        }


        // Botones que buscan y rellenan los grid
        private void btn_agregar_xls_empleados_Click(object sender, EventArgs e)
        {
            Funciones fn = new Funciones();

            fn.importarExcel(gridGanadores, "Hoja1");

        }

        private void btn_agregar_xls_premios_Click(object sender, EventArgs e)
        {
            Funciones fn = new Funciones();

            fn.importarExcel(gridPremios, "Hoja1");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Funciones fn = new Funciones();
            fn.exportarExcel(Historial_Ganadores);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
