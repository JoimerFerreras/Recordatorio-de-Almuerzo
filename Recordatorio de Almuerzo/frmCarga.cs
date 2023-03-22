using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recordatorio_de_Almuerzo
{
    public partial class frmCarga : Form
    {
        int Contador = 0;
        Recordatorio_D recordatorioObj = new Recordatorio_D();

        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
//            CheckForIllegalCrossThreadCalls = false;

         //   this.Visible = false;
      //      Util.dtRecordatoriosPendientes = recordatorioObj.ListadoRecordatoriosPendientes();

          //  timer1.Enabled = true;
        }

        private void AbrirFormPrincipal()
        {
            frmPrincipal Form = new frmPrincipal();
            Form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string filtro = $@"Fecha LIKE '%{string.Format("{0:hh:mm:tt}", DateTime.Now)}%'";
           DataRow[] resultados = Util.dtRecordatoriosPendientes.Select(filtro);

           
            if (resultados.Count() > 0)
            {
                for (int i = 0; i < resultados.Count() - 1; i++)
                {
                    DataRow row = resultados[0];
                    row["id"] = "";
                }
            }
        }

        private void GenerarNotificacionNativa()
        {

        }
        private void GenerarNotificacionCorreo()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "fasfasf";
            notifyIcon1.BalloonTipText = "OK";
            notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
