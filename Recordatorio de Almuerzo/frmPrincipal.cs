using Recordatorio_de_Almuerzo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.Win32;

namespace Recordatorio_de_Almuerzo
{
    public partial class frmPrincipal : Form
    {
        #region DECLARACIONES

        DataTable dt = new DataTable();
        private Recordatorio_D recordatorioObj = new Recordatorio_D();
        const string NombreFormulario = "Recordatorio de Almuerzos";

        bool Edicion = false;
        bool EditarRegistro = false;
        string Id_Registro = "0";
        ToolTip ToolTipEdicion = new ToolTip();
        #endregion


        public frmPrincipal()
        {
            InitializeComponent();
        }


        #region METODOS, PROCEDIMIENTOS Y FUNCIONES

        private void ConsutarRecordatorios(int TipoFiltro, bool TodosRecordatorios, DateTime FechaInicial, DateTime FechaFinal)
        {
            DateTime today = DateTime.Today;
            switch (TipoFiltro)
            {
                case 1: // Recordatorios de hoy
                    FechaInicial = DateTime.Now;
                    FechaFinal = DateTime.Now;
                    TodosRecordatorios = false;
                    break;

                case 2: // Recordatorios de esta semana
                    int delta = DayOfWeek.Sunday - today.DayOfWeek;
                    FechaInicial = today.AddDays(delta);
                    FechaFinal = FechaInicial.AddDays(6);
                    TodosRecordatorios = false;
                    break;

                case 3: // Recordatorios del mes
                    FechaInicial = new DateTime(today.Year, today.Month, 1);
                    FechaFinal = FechaInicial.AddMonths(1).AddDays(-1);
                    TodosRecordatorios = false;
                    break;
            }
            if (TodosRecordatorios == true)
            {
                TodosRecordatorios = false;
            }
            else
            {
                TodosRecordatorios = true;
            }

            dt = recordatorioObj.ListadoRecordatorios(TodosRecordatorios, FechaInicial, FechaFinal);
            dgvDatos.DataSource = dt;
            Util.dtRecordatoriosPendientes = recordatorioObj.ListadoRecordatoriosPendientes();
        }

        private void Guardar(DateTime Fecha, string Hora, string Minutos, string FormatoHora, bool Recordatorio)
        {
            try
            {
                int RecordatorioFormat = 0;
                if (Recordatorio == true)
                {
                    RecordatorioFormat = 1;
                }

                if (EditarRegistro == false)
                {
                    DateTime FechaFormateada = DateTime.Parse(string.Format("{0:dd/MM/yyyy}", Fecha) + " " + Hora + ":" + Minutos + " " + FormatoHora);
                    recordatorioObj.Agregar(FechaFormateada, RecordatorioFormat);
                }
                else
                {
                    DateTime FechaFormateada = DateTime.Parse(string.Format("{0:dd/MM/yyyy}", Fecha) + " " + Hora + ":" + Minutos + " " + FormatoHora);
                    recordatorioObj.Editar(int.Parse(Id_Registro), FechaFormateada, RecordatorioFormat);
                }
                LimpiarCampos();
                ConsutarRecordatorios(2, chkTodosRecordatorios.Checked, DateTime.Now, DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, NombreFormulario + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (Id_Registro == "0")
                {
                    MessageBox.Show("No hay recordatorio seleccionado para eliminar.", NombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    recordatorioObj.Eliminar(int.Parse(Id_Registro));
                    LimpiarCampos();
                    MessageBox.Show("El recordatorio ha sido eliminado.", NombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConsutarRecordatorios(2, chkTodosRecordatorios.Checked, DateTime.Now, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, NombreFormulario + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboboxs()
        {
            try
            {
                DataTable dt;

                // Llenado de combobox de Hora
                dt = new DataTable();
                dt.Columns.Add("Value");
                dt.Columns.Add("Hora");
                
                for (int i = 1; i < 13; i++)
                {
                    if (i >= 0 && i < 10)
                    {
                        dt.Rows.Add("0" + i.ToString(), "0" + i.ToString());
                    }
                    else
                    {
                        dt.Rows.Add(i, i);
                    }
                }

                cmbHora.DataSource = dt;
                cmbHora.ValueMember = "Value";
                cmbHora.DisplayMember = "Hora";


                // Llenado de combobox de Tipo de Minuto
                dt = new DataTable();
                dt.Columns.Add("Value");
                dt.Columns.Add("Minuto");

                int Multiplicador = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (i >= 0 && i <= 1)
                    {
                        Multiplicador = i * 5;
                        dt.Rows.Add("0" + Multiplicador.ToString(), "0" + Multiplicador.ToString());
                    }
                    else
                    {
                        Multiplicador = i * 5;
                        dt.Rows.Add(Multiplicador, Multiplicador);
                    }
                }

                cmbMinuto.DataSource = dt;
                cmbMinuto.ValueMember = "Value";
                cmbMinuto.DisplayMember = "Minuto";

                // Llenado de combobox de Formato de Hora
                dt = new DataTable();
                dt.Columns.Add("Value");
                dt.Columns.Add("Formato");

                dt.Rows.Add("AM", "AM");
                dt.Rows.Add("PM", "PM");

                cmbFormatoHora.DataSource = dt;
                cmbFormatoHora.ValueMember = "Value";
                cmbFormatoHora.DisplayMember = "Formato";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, NombreFormulario + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            EditarRegistro = false;
            Id_Registro = "0";
            txtId.Text = "(Nuevo)";
            chkRecordatorio.Checked = true;
        }

        private void RestaurarTodo()
        {
            // Restaura toda la configuración a los valors de fábrica
            Settings.Default.Reset();
            CargarConfiguracion();
        }

        private void CargarConfiguracion()
        {
            chkNotificacionesNativas.Checked = Settings.Default.NotificacionNativa;
            chkNotificacionCorreo.Checked = Settings.Default.NotificacionCorreo;
            txtCorreo.Text = Settings.Default.CorreoRecordatoio;
            txtPasswordCorreo.Text = Settings.Default.PasswordCorreo;
        }
        private void GuardarConfiguracion()
        {
            if (ValidarConfiguracion() == true)
            {
                Settings.Default.NotificacionNativa = chkNotificacionesNativas.Checked;
                Settings.Default.NotificacionCorreo = chkNotificacionCorreo.Checked;
                Settings.Default.CorreoRecordatoio = txtCorreo.Text;
                Settings.Default.PasswordCorreo = txtPasswordCorreo.Text;

                Settings.Default.Save();

                // Renombramiento del text de los botones correspondientes del menu contextual del nitifyicon
                frmCarga formularioPadre = (frmCarga)this.Owner;

                if (Settings.Default.NotificacionNativa == false)
                {
                    formularioPadre.habilitarNotificacionesNativasToolStripMenuItem.Text = "Habilitar notificaciones nativas";
                }
                else
                {
                    formularioPadre.habilitarNotificacionesNativasToolStripMenuItem.Text = "Deshabilitar notificaciones nativas";
                }

                if (Settings.Default.NotificacionCorreo == false)
                {
                   formularioPadre.habilitarNotificacionesPorCorreoToolStripMenuItem.Text = "Habilitar notificaciones por correo";
                }
                else
                {
                    formularioPadre.habilitarNotificacionesPorCorreoToolStripMenuItem.Text = "Deshabilitar notificaciones por correo";
                }
                MessageBox.Show("Se ha guardado la configuración", NombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarConfiguracion()
        {
            bool Validacion = false;

            if (chkNotificacionCorreo.Checked == true)
            {
                if (txtCorreo.Text.Contains("@") || txtCorreo.Text.Contains("."))
                {
                    if (!(txtPasswordCorreo.Text.Length > 0))
                    {
                        MessageBox.Show("Ha marcado la opción para notificar por correo electrónico, el campo 'Contraseña no puede estar vacío' ", NombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Validacion = false;
                    }
                    else
                    {
                        Validacion = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ha marcado la opción para notificar por correo electrónico, por favor, proporsione un correo electrónico válido", NombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validacion = false;
                }

            }
            else
            {
                Validacion = true;
            }

            return Validacion;
        }

        private void SeleccionarFila()
        {
            try
            {
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    EditarRegistro = true;
                    Id_Registro = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    txtId.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                 //   txtNombreDia.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                    dtpFecha.Value = DateTime.Parse(string.Format("{0:dd/MM/yyyy}", dgvDatos.CurrentRow.Cells[2].Value.ToString()));
                    cmbHora.SelectedValue = string.Format("{0:hh}", DateTime.Parse(string.Format("{0:hh}", dgvDatos.CurrentRow.Cells[3].Value.ToString())));
                    cmbMinuto.SelectedValue = string.Format("{0:mm}", DateTime.Parse(string.Format("{0:mm}", dgvDatos.CurrentRow.Cells[3].Value.ToString())));

                    if (string.Format("{0:tt}", DateTime.Parse(string.Format("{0:tt}", dgvDatos.CurrentRow.Cells[3].Value.ToString()))) == "p.m.")
                    {
                        cmbFormatoHora.SelectedValue = "PM";
                    }
                    else if (string.Format("{0:tt}", DateTime.Parse(string.Format("{0:tt}", dgvDatos.CurrentRow.Cells[3].Value.ToString()))) == "a.m.")
                    {
                        cmbFormatoHora.SelectedValue = "AM";
                    }

                    if (dgvDatos.CurrentRow.Cells[4].Value.ToString() == "SI")
                    {
                        chkRecordatorio.Checked = true;
                    }
                    else if (dgvDatos.CurrentRow.Cells[4].Value.ToString() == "NO")
                    {
                        chkRecordatorio.Checked = false;
                    }

                    HabilitarEdicion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, NombreFormulario + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarNombreDia()
        {
            DayOfWeek diaSemana = dtpFecha.Value.DayOfWeek;

            switch (diaSemana)
            {
                case DayOfWeek.Monday:
                    txtNombreDia.Text = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    txtNombreDia.Text = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    txtNombreDia.Text = "Miercoles";
                    break;
                case DayOfWeek.Thursday:
                    txtNombreDia.Text = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    txtNombreDia.Text = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    txtNombreDia.Text = "Sábado";
                    break;
                case DayOfWeek.Sunday:
                    txtNombreDia.Text = "Domingo";
                    break;
                default:
                    break;
            }
        }

        private void HabilitarEdicion()
        {
            Edicion = true;
            btnHabilitarEdicion.Text = "◀";
            this.Size = new Size(1229, 769);
            
            ToolTipEdicion.SetToolTip(btnHabilitarEdicion, "Ocultar");
        }
        private void DeshabilitarEdicion()
        {
            Edicion = false;
            btnHabilitarEdicion.Text = "▶";
            this.Size = new Size(939, 769);
            ToolTipEdicion.SetToolTip(btnHabilitarEdicion, "Editar recordatorio");
        }
        #endregion


        #region EVENTOS

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            CargarConfiguracion();

            LlenarComboboxs();

            DeshabilitarEdicion();

            dgvDatos.AutoGenerateColumns = false;

            Font sampleFont = new Font("Microsoft Tai Le", 10, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = sampleFont;

            dgvDatos.Columns["Id_Recordatorio"].Width = 80;

            dgvDatos.Columns["Fecha"].Width = 100;

            dgvDatos.Columns["Hora"].Width = 100;

            dgvDatos.Columns["Dia"].Width = 117;

            dgvDatos.Columns["Recordatorio"].Width = 150;

            //CargarConfiguracion();
            LimpiarCampos();
            cmbFormatoHora.SelectedValue = "PM";

            // Establecer el rango de fecha de los datetime pickers de los filtros a una semana
            DateTime today = DateTime.Now;
            int delta = DayOfWeek.Sunday - today.DayOfWeek;
            DateTime FechaInicial = today.AddDays(delta);
            DateTime FechaFinal = FechaInicial.AddDays(6);

            dtpFechaInicial.Value = FechaInicial;
            dtpFechaFinal.Value = FechaFinal;
            //--

            ConsutarRecordatorios(2, chkTodosRecordatorios.Checked, DateTime.Now, DateTime.Now);
            AsignarNombreDia();

            DeshabilitarEdicion();
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
                HabilitarEdicion();
            }
            else
            {
                DeshabilitarEdicion();
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            frmContactos Form = new frmContactos();
            Form.ShowDialog();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila();
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

            // Verificar si la fila actual es de tipo DataGridViewRow para evitar errores
            if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].DataBoundItem != null && dgv.Rows[e.RowIndex].DataBoundItem is DataRowView)
            {
                DataRowView row = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;

                // Obtener las columnas de fecha y hora
                DateTime fecha = DateTime.Parse(row["Fecha"].ToString() + " " +  row["Hora"].ToString());

                // Verificar si la fecha y hora de la fila es menor que la fecha y hora actual
                if (fecha < DateTime.Now)
                {
                    // Establecer el color de fondo de la fila en rojo
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Silver;

                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

                    Font sampleFont = new Font("Microsoft Tai Le", 9, FontStyle.Regular);
                    dgv.Rows[e.RowIndex].DefaultCellStyle.Font = sampleFont;

                    if (dgv.Columns[e.ColumnIndex].Name == "Recordatorio")  //Si es la columna a evaluar
                    {
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.SelectionBackColor = Color.Silver;

                        dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                        dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;

                        dgv.Rows[e.RowIndex].DefaultCellStyle.Font = sampleFont;
                    }
                }

                else if ((string.Format("{0:dd/MM/yyyy}", fecha) == string.Format("{0:dd/MM/yyyy}", DateTime.Now)) && (DateTime.Parse(string.Format("{0:hh:mm tt}", fecha)) >= DateTime.Parse(string.Format("{0:hh:mm tt}", DateTime.Now))))
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;

                    Font sampleFont = new Font("Microsoft Tai Le", 9, FontStyle.Bold);
                    dgv.Rows[e.RowIndex].DefaultCellStyle.Font = sampleFont;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
                }
            }
        }

        private void btnFiltrarHoy_Click(object sender, EventArgs e)
        {
            ConsutarRecordatorios(1, chkTodosRecordatorios.Checked, DateTime.Now, DateTime.Now);
        }

        private void btnFiltrarSemana_Click(object sender, EventArgs e)
        {
            ConsutarRecordatorios(2, chkTodosRecordatorios.Checked, DateTime.Now, DateTime.Now);
        }

        private void btnFiltrarMes_Click(object sender, EventArgs e)
        {
            ConsutarRecordatorios(3, chkTodosRecordatorios.Checked, DateTime.Now, DateTime.Now);
        }

        private void btnFiltrarBusqueda_Click(object sender, EventArgs e)
        {
            ConsutarRecordatorios(0, chkTodosRecordatorios.Checked, dtpFechaInicial.Value, dtpFechaFinal.Value);
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           Guardar(dtpFecha.Value, cmbHora.SelectedValue.ToString(), cmbMinuto.SelectedValue.ToString(), cmbFormatoHora.SelectedValue.ToString(), chkRecordatorio.Checked);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            AsignarNombreDia();
        }

        private void btnSumarUnDia_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = dtpFecha.Value.AddDays(1);
        }

        private void chkNotificacionCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotificacionCorreo.Checked == true)
            {
                txtCorreo.ReadOnly = false;
                txtPasswordCorreo.ReadOnly = false;
            }
            else
            {
                txtCorreo.ReadOnly = true;
                txtPasswordCorreo.ReadOnly = true;
            }
        }
    }
}
