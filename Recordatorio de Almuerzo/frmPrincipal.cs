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
        DataTable dt = new DataTable();
        private Recordatorio_D recordatorioObj = new Recordatorio_D();

        bool Edicion = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }
       

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Edicion = false;
            btnHabilitarEdicion.Text = "▶";
            this.Size = new Size(939, 769);


            dgvDatos.AutoGenerateColumns = false;

            Font sampleFont = new Font("Microsoft Tai Le", 10, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = sampleFont;

            dgvDatos.Columns["Id_Recordatorio"].Width = 80;

            dgvDatos.Columns["Fecha"].Width = 100;

            dgvDatos.Columns["Hora"].Width = 100;

            dgvDatos.Columns["Dia"].Width = 117;

            dgvDatos.Columns["Recordatorio"].Width = 150;

            //CargarConfiguracion();
            ConsutarRecordatorios(DateTime.Now, DateTime.Now);
        }

        private void ConsutarRecordatorios(DateTime FechaInicial, DateTime FechaFinal)
        {
            dt = recordatorioObj.ListadoRecordatorios(chkTodosRecordatorios.Checked, FechaInicial, FechaFinal);
            dgvDatos.DataSource = dt;
        }


        private void Guardar()
        {

        }

        private void Eliminar()
        {

        }

        private void LlenarComboboxs()
        {
           
        }


       
        private void RestaurarTodo()
        {
            // Restaura todo a los valors de fábrica
            Settings.Default.Reset();
            Settings.Default.Save();
        }

        private void CargarConfiguracion()
        {
            //dtDatos = Settings.Default.Datos;
            //dgvDatos.DataSource = dtDatos;

            //chkRecordatorioGeneral.Checked = Settings.Default.RecordatorioGeneral;
        }
        private void GuardarConfiguracion()
        {
            //Settings.Default.Datos = dtDatos;
            //Settings.Default.RecordatorioGeneral = chkRecordatorioGeneral.Checked;
            //Settings.Default.Datos = dtDatos;
            //Settings.Default.Save();
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

        private void btnRestaurarTodo_Click(object sender, EventArgs e)
        {
            RestaurarTodo();
        }

        private void btnHabilitarEdicion_Click(object sender, EventArgs e)
        {
            if (Edicion == false)
            {
                Edicion = true;
                btnHabilitarEdicion.Text = "◀";
                this.Size = new Size(1229, 769);
            }
            else
            {
                Edicion = false;
                btnHabilitarEdicion.Text = "▶";
                this.Size = new Size(939, 769);
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            frmContactos Form = new frmContactos();
            Form.ShowDialog();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "Recordatorio")  //Si es la columna a evaluar
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            if (dgv.Columns[e.ColumnIndex].Name == "Recordatorio")  //Si es la columna a evaluar
            {
                if (e.Value.ToString().Contains("NO"))
                {
                    e.CellStyle.BackColor = Color.Salmon;
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
                else if (e.Value.ToString().Contains("SI"))
                {
                    e.CellStyle.BackColor = Color.MediumAquamarine;
                    e.CellStyle.SelectionBackColor = Color.MediumSpringGreen;
                }
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
