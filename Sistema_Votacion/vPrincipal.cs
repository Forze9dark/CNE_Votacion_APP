using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_Votacion
{
    public partial class vPrincipal : Form
    {
        public vPrincipal()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new splashscreen());
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            vConfiguracion vconfig = new vConfiguracion();
            this.Hide();
            vconfig.Show();
        }

        private void btn_start_sorteo_Click(object sender, EventArgs e)
        {
            vGeneral vg = new vGeneral();
            vControl vc = new vControl();
            this.Hide();

            vg.Show();
            vc.Show();
        }
    }
}
