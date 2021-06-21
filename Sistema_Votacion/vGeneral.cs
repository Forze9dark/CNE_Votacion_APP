using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Sistema_Votacion.Utilidades;
using LinqToExcel;
using System.Threading;


namespace Sistema_Votacion
{
    public partial class vGeneral : Form
    {
        public vGeneral()
        {
            InitializeComponent();
            aTimer.Start();
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            lblEmpleadoName.Text = Properties.Settings.Default.emp_ganador;
            lblPremioName.Text = Properties.Settings.Default.premio_ganador;
            lblDepaGanador.Text = Properties.Settings.Default.departamento_emp_ganador;
            bool btn_premio = Properties.Settings.Default.btn_get_premio;
        }

    }
}
