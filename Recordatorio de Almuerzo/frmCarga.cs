using Recordatorio_de_Almuerzo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Recordatorio_de_Almuerzo
{
    public partial class frmCarga : Form
    {
        #region DECLARACIONES
        Recordatorio_D recordatorioObj = new Recordatorio_D();
        List<NotifyIcon> notificaciones = new List<NotifyIcon>();
        const string NombreFormulario = "Recordatorio de Almuerzos";

        #endregion


        public frmCarga()
        {
            InitializeComponent();
        }


        #region METODOS, PROCEDIMIENTOS Y FUNCIONES

        async Task CicloRecordatorio()
        {
            try
            {
                Recordatorio_D recordatorioObj = new Recordatorio_D();
                while (true)
                {
                    // Aquí va el código que quieres ejecutar cada cierto tiempo
                    DataRow[] resultados = Util.dtRecordatoriosPendientes.Select($@"Fecha = '{string.Format("{0:hh:mm tt}", DateTime.Now)}'");

                    if (resultados.Count() > 0)
                    {
                        for (int i = 0; i < resultados.Count(); i++)
                        {
                            DataRow row = resultados[i];
                            string id = row["Id_Recordatorio"].ToString();
                            string recordatorio = row["Recordatorio"].ToString();
                            string confirmacion = row["Confirmacion"].ToString();
                            string hora = string.Format("{0:hh:mm tt}", DateTime.Parse(row["Fecha"].ToString()));

                            recordatorioObj.ConfirmarRecordatorio(int.Parse(id));

                            if (confirmacion == "False" && recordatorio == "True")
                            {
                                if (Settings.Default.NotificacionNativa == true)
                                {
                                    GenerarNotificacionNativa(hora);
                                }
                                if (Settings.Default.NotificacionCorreo == true)
                                {
                                    Thread hilo = new Thread(() => GenerarNotificacionCorreo(hora));
                                    hilo.Start();
                                }
                            }
                        }
                        Util.dtRecordatoriosPendientes = recordatorioObj.ListadoRecordatoriosPendientes();
                    }

                    // Esperamos un cierto tiempo antes de ejecutar el siguiente ciclo
                    await Task.Delay(TimeSpan.FromSeconds(5));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarNotificacionNativa(string HoraRecordatorio)
        {
            NotifyIcon notify = new NotifyIcon();
            notificaciones.Add(notify);
            int UltimaNotificacion = notificaciones.Count - 1;

            notificaciones[UltimaNotificacion].Icon = notifyIconMenuContextual.Icon;

            // Establece la propiedad "Visible" del control NotifyIcon en "true"
            notificaciones[UltimaNotificacion].Visible = true;

            // Muestra un globo flotante de notificación con el título y el mensaje dados
            notificaciones[UltimaNotificacion].ShowBalloonTip(5000, "Hola, tienes un almuerzo pautado para las " + HoraRecordatorio, "Según tus recordatorios registrados es hora de almorzar", ToolTipIcon.None);

            // Establece la propiedad "Visible" del control NotifyIcon en "false"
            notificaciones[UltimaNotificacion].Visible = false;
        }
        private void GenerarNotificacionCorreo(string HoraRecordatorio)
        {

        }

        #endregion


        #region EVENTOS
        private void frmCarga_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.Visible = false;

            Util.dtRecordatoriosPendientes = recordatorioObj.ListadoRecordatoriosPendientes();

            CicloRecordatorio();
        }

        private void abrirPanelDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal Form = new frmPrincipal();
            Form.ShowDialog();
        }

        #endregion

        private void habilitarNotificacionesNativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.NotificacionNativa == true)
            {
                Settings.Default.NotificacionNativa = false;
                Settings.Default.Save();
                habilitarNotificacionesNativasToolStripMenuItem.Text = "Habilitar notificaciones nativas";
            }
            else
            {
                Settings.Default.NotificacionNativa = true;
                Settings.Default.Save();
                habilitarNotificacionesNativasToolStripMenuItem.Text = "Deshabilitar notificaciones nativas";
            }

        }

        private void habilitarNotificacionesPorCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.NotificacionCorreo == true)
            {
                Settings.Default.NotificacionCorreo = false;
                Settings.Default.Save();
                habilitarNotificacionesPorCorreoToolStripMenuItem.Text = "Habilitar notificaciones por correo";
            }
            else
            {
                if (Settings.Default.CorreoRecordatoio.Contains("@") && Settings.Default.CorreoRecordatoio.Contains(".") && Settings.Default.PasswordCorreo.Length > 0)
                {
                    Settings.Default.NotificacionCorreo = true;
                    Settings.Default.Save();
                    habilitarNotificacionesPorCorreoToolStripMenuItem.Text = "Deshabilitar notificaciones por correo";
                }
                else
                {
                    MessageBox.Show("Ha marcado la opción para notificar por correo electrónico, pero, las credenciales del correo electrónico no son válidas.\n\nCambie las credenciales en el apartado de 'Configuración' en el panel de control", NombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
