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

namespace Recordatorio_de_Almuerzo
{
    public partial class frmPrincipal : Form
    {
        bool ConfirmacionRecordatorioDiario = false;
        static public DataTable dtDatos = new DataTable();

        bool Edicion = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }
       

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (Edicion == false)
            {
                Edicion = true;
                btnHabilitarEdicion.Text = "◀";
                this.Size = new Size(1228, 674);
            }
            else
            {
                Edicion = false;
                btnHabilitarEdicion.Text = "▶";
                this.Size = new Size(939, 674);
            }


            dgvDatos.AutoGenerateColumns = false;

            Font sampleFont = new Font("Microsoft Tai Le", 10, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = sampleFont;

            dgvDatos.Columns["Id_Recordatorio"].Width = 80;

            dgvDatos.Columns["Fecha"].Width = 100;

            dgvDatos.Columns["Hora"].Width = 100;

            dgvDatos.Columns["Dia"].Width = 117;

            dgvDatos.Columns["Recordatorio"].Width = 150;

            //CargarConfiguracion();;
        }


        private void Guardar()
        {
        }
        private void LlenarComboboxs()
        {
           
        }


        private void CargarConfiguracion()
        {
            //dtDatos = Settings.Default.Datos;
            //dgvDatos.DataSource = dtDatos;

            //chkRecordatorioGeneral.Checked = Settings.Default.RecordatorioGeneral;
        }
        private void RestaurarTodo()
        {
            // Restaura todo a los valors de fábrica
            Settings.Default.Reset();
        }

        private void GuardarConfiguracion()
        {
            //Settings.Default.Datos = dtDatos;
            //Settings.Default.RecordatorioGeneral = chkRecordatorioGeneral.Checked;
            //Settings.Default.Datos = dtDatos;
            //Settings.Default.Save();
        }
        private void AgregarDia()
        {
           
        }

        private void QuitarDia()
        {

        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

        private void btnRestaurarTodo_Click(object sender, EventArgs e)
        {
            RestaurarTodo();
        }

        private void btnAgregarDia_Click(object sender, EventArgs e)
        {
            AgregarDia();
        }

        private void btnQuitarDia_Click(object sender, EventArgs e)
        {
            QuitarDia();
        }

        private void btnHabilitarEdicion_Click(object sender, EventArgs e)
        {
            if (Edicion == false)
            {
                Edicion = true;
                btnHabilitarEdicion.Text = "◀";
                this.Size = new Size(1228, 674);
            }
            else
            {
                Edicion = false;
                btnHabilitarEdicion.Text = "▶";
                this.Size = new Size(939, 674);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
