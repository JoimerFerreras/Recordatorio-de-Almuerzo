namespace Recordatorio_de_Almuerzo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPasswordCorreo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnContactos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.chkNotificacionCorreo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestaurarTodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkNotificacionesNativas = new System.Windows.Forms.CheckBox();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFiltrarMes = new System.Windows.Forms.Button();
            this.btnFiltrarSemana = new System.Windows.Forms.Button();
            this.btnFiltrarBusqueda = new System.Windows.Forms.Button();
            this.btnFiltrarHoy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.chkTodosRecordatorios = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Id_Recordatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recordatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSumarUnDia = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombreDia = new System.Windows.Forms.TextBox();
            this.cmbMinuto = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbFormatoHora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkRecordatorio = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHabilitarEdicion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPasswordCorreo);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnContactos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.chkNotificacionCorreo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRestaurarTodo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkNotificacionesNativas);
            this.panel1.Controls.Add(this.btnGuardarConfiguracion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 704);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 349);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Contraseña";
            // 
            // txtPasswordCorreo
            // 
            this.txtPasswordCorreo.Location = new System.Drawing.Point(22, 367);
            this.txtPasswordCorreo.MaxLength = 200;
            this.txtPasswordCorreo.Name = "txtPasswordCorreo";
            this.txtPasswordCorreo.PasswordChar = '•';
            this.txtPasswordCorreo.ReadOnly = true;
            this.txtPasswordCorreo.Size = new System.Drawing.Size(192, 21);
            this.txtPasswordCorreo.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Location = new System.Drawing.Point(25, 482);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 1);
            this.panel7.TabIndex = 20;
            // 
            // btnContactos
            // 
            this.btnContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.Location = new System.Drawing.Point(22, 636);
            this.btnContactos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(192, 50);
            this.btnContactos.TabIndex = 9;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(22, 299);
            this.txtCorreo.MaxLength = 200;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(192, 21);
            this.txtCorreo.TabIndex = 7;
            // 
            // chkNotificacionCorreo
            // 
            this.chkNotificacionCorreo.AutoSize = true;
            this.chkNotificacionCorreo.Location = new System.Drawing.Point(22, 209);
            this.chkNotificacionCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNotificacionCorreo.Name = "chkNotificacionCorreo";
            this.chkNotificacionCorreo.Size = new System.Drawing.Size(61, 19);
            this.chkNotificacionCorreo.TabIndex = 6;
            this.chkNotificacionCorreo.Text = "Activar";
            this.chkNotificacionCorreo.UseVisualStyleBackColor = true;
            this.chkNotificacionCorreo.CheckedChanged += new System.EventHandler(this.chkNotificacionCorreo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Notificaciones por correo";
            // 
            // btnRestaurarTodo
            // 
            this.btnRestaurarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarTodo.Location = new System.Drawing.Point(22, 577);
            this.btnRestaurarTodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestaurarTodo.Name = "btnRestaurarTodo";
            this.btnRestaurarTodo.Size = new System.Drawing.Size(192, 50);
            this.btnRestaurarTodo.TabIndex = 4;
            this.btnRestaurarTodo.Text = "Restaurar todo";
            this.btnRestaurarTodo.UseVisualStyleBackColor = true;
            this.btnRestaurarTodo.Click += new System.EventHandler(this.btnRestaurarTodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Configuración";
            // 
            // chkNotificacionesNativas
            // 
            this.chkNotificacionesNativas.AutoSize = true;
            this.chkNotificacionesNativas.Location = new System.Drawing.Point(22, 119);
            this.chkNotificacionesNativas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNotificacionesNativas.Name = "chkNotificacionesNativas";
            this.chkNotificacionesNativas.Size = new System.Drawing.Size(61, 19);
            this.chkNotificacionesNativas.TabIndex = 1;
            this.chkNotificacionesNativas.Text = "Activar";
            this.chkNotificacionesNativas.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(22, 518);
            this.btnGuardarConfiguracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(192, 50);
            this.btnGuardarConfiguracion.TabIndex = 0;
            this.btnGuardarConfiguracion.Text = "Guardar configuración";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificaciones nativas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnFiltrarMes);
            this.panel2.Controls.Add(this.btnFiltrarSemana);
            this.panel2.Controls.Add(this.btnFiltrarBusqueda);
            this.panel2.Controls.Add(this.btnFiltrarHoy);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtpFechaFinal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chkTodosRecordatorios);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpFechaInicial);
            this.panel2.Controls.Add(this.dgvDatos);
            this.panel2.Location = new System.Drawing.Point(265, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 704);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Location = new System.Drawing.Point(22, 447);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(533, 1);
            this.panel6.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(22, 516);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 1);
            this.panel5.TabIndex = 20;
            // 
            // btnFiltrarMes
            // 
            this.btnFiltrarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarMes.Location = new System.Drawing.Point(408, 464);
            this.btnFiltrarMes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltrarMes.Name = "btnFiltrarMes";
            this.btnFiltrarMes.Size = new System.Drawing.Size(147, 31);
            this.btnFiltrarMes.TabIndex = 18;
            this.btnFiltrarMes.Text = "Este mes";
            this.btnFiltrarMes.UseVisualStyleBackColor = true;
            this.btnFiltrarMes.Click += new System.EventHandler(this.btnFiltrarMes_Click);
            // 
            // btnFiltrarSemana
            // 
            this.btnFiltrarSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarSemana.Location = new System.Drawing.Point(215, 464);
            this.btnFiltrarSemana.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltrarSemana.Name = "btnFiltrarSemana";
            this.btnFiltrarSemana.Size = new System.Drawing.Size(147, 31);
            this.btnFiltrarSemana.TabIndex = 17;
            this.btnFiltrarSemana.Text = "Esta semana";
            this.btnFiltrarSemana.UseVisualStyleBackColor = true;
            this.btnFiltrarSemana.Click += new System.EventHandler(this.btnFiltrarSemana_Click);
            // 
            // btnFiltrarBusqueda
            // 
            this.btnFiltrarBusqueda.BackColor = System.Drawing.Color.White;
            this.btnFiltrarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarBusqueda.Location = new System.Drawing.Point(189, 636);
            this.btnFiltrarBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltrarBusqueda.Name = "btnFiltrarBusqueda";
            this.btnFiltrarBusqueda.Size = new System.Drawing.Size(192, 50);
            this.btnFiltrarBusqueda.TabIndex = 16;
            this.btnFiltrarBusqueda.Text = "Filtrar";
            this.btnFiltrarBusqueda.UseVisualStyleBackColor = false;
            this.btnFiltrarBusqueda.Click += new System.EventHandler(this.btnFiltrarBusqueda_Click);
            // 
            // btnFiltrarHoy
            // 
            this.btnFiltrarHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarHoy.Location = new System.Drawing.Point(22, 464);
            this.btnFiltrarHoy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltrarHoy.Name = "btnFiltrarHoy";
            this.btnFiltrarHoy.Size = new System.Drawing.Size(147, 31);
            this.btnFiltrarHoy.TabIndex = 15;
            this.btnFiltrarHoy.Text = "Hoy";
            this.btnFiltrarHoy.UseVisualStyleBackColor = true;
            this.btnFiltrarHoy.Click += new System.EventHandler(this.btnFiltrarHoy_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 563);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha final";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(408, 581);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaFinal.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 538);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Filtrar busqueda";
            // 
            // chkTodosRecordatorios
            // 
            this.chkTodosRecordatorios.AutoSize = true;
            this.chkTodosRecordatorios.Location = new System.Drawing.Point(22, 581);
            this.chkTodosRecordatorios.Name = "chkTodosRecordatorios";
            this.chkTodosRecordatorios.Size = new System.Drawing.Size(60, 19);
            this.chkTodosRecordatorios.TabIndex = 11;
            this.chkTodosRecordatorios.Text = "Todos";
            this.chkTodosRecordatorios.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 563);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha inicial";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(206, 581);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaInicial.TabIndex = 9;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 50;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Recordatorio,
            this.Dia,
            this.Fecha,
            this.Hora,
            this.Recordatorio});
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDatos.Location = new System.Drawing.Point(18, 23);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.RowTemplate.Height = 30;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(537, 402);
            this.dgvDatos.StandardTab = true;
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            this.dgvDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatos_CellFormatting);
            // 
            // Id_Recordatorio
            // 
            this.Id_Recordatorio.DataPropertyName = "Id_Recordatorio";
            this.Id_Recordatorio.FillWeight = 319.7968F;
            this.Id_Recordatorio.HeaderText = "ID";
            this.Id_Recordatorio.MinimumWidth = 80;
            this.Id_Recordatorio.Name = "Id_Recordatorio";
            this.Id_Recordatorio.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Día";
            this.Dia.MinimumWidth = 117;
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.FillWeight = 2.12028F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 100;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.FillWeight = 4.260664F;
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 100;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Recordatorio
            // 
            this.Recordatorio.DataPropertyName = "Recordatorio";
            this.Recordatorio.HeaderText = "Recordatorio";
            this.Recordatorio.MinimumWidth = 150;
            this.Recordatorio.Name = "Recordatorio";
            this.Recordatorio.ReadOnly = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSumarUnDia);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.txtNombreDia);
            this.panel3.Controls.Add(this.cmbMinuto);
            this.panel3.Controls.Add(this.cmbHora);
            this.panel3.Controls.Add(this.cmbFormatoHora);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.chkRecordatorio);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Location = new System.Drawing.Point(926, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 704);
            this.panel3.TabIndex = 2;
            // 
            // btnSumarUnDia
            // 
            this.btnSumarUnDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumarUnDia.Location = new System.Drawing.Point(155, 130);
            this.btnSumarUnDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSumarUnDia.Name = "btnSumarUnDia";
            this.btnSumarUnDia.Size = new System.Drawing.Size(39, 21);
            this.btnSumarUnDia.TabIndex = 20;
            this.btnSumarUnDia.Text = "+1";
            this.toolTip1.SetToolTip(this.btnSumarUnDia, "Sumar un día a la fecha");
            this.btnSumarUnDia.UseVisualStyleBackColor = true;
            this.btnSumarUnDia.Click += new System.EventHandler(this.btnSumarUnDia_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(41, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 1);
            this.panel4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(41, 40);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(75, 21);
            this.txtId.TabIndex = 17;
            // 
            // txtNombreDia
            // 
            this.txtNombreDia.Location = new System.Drawing.Point(41, 157);
            this.txtNombreDia.Name = "txtNombreDia";
            this.txtNombreDia.ReadOnly = true;
            this.txtNombreDia.Size = new System.Drawing.Size(106, 21);
            this.txtNombreDia.TabIndex = 16;
            // 
            // cmbMinuto
            // 
            this.cmbMinuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMinuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinuto.FormattingEnabled = true;
            this.cmbMinuto.Location = new System.Drawing.Point(101, 253);
            this.cmbMinuto.Name = "cmbMinuto";
            this.cmbMinuto.Size = new System.Drawing.Size(54, 23);
            this.cmbMinuto.TabIndex = 15;
            // 
            // cmbHora
            // 
            this.cmbHora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbHora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(41, 253);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(54, 23);
            this.cmbHora.TabIndex = 14;
            // 
            // cmbFormatoHora
            // 
            this.cmbFormatoHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatoHora.FormattingEnabled = true;
            this.cmbFormatoHora.Location = new System.Drawing.Point(161, 253);
            this.cmbFormatoHora.Name = "cmbFormatoHora";
            this.cmbFormatoHora.Size = new System.Drawing.Size(54, 23);
            this.cmbFormatoHora.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(41, 576);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(192, 50);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha";
            // 
            // chkRecordatorio
            // 
            this.chkRecordatorio.AutoSize = true;
            this.chkRecordatorio.Location = new System.Drawing.Point(41, 330);
            this.chkRecordatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRecordatorio.Name = "chkRecordatorio";
            this.chkRecordatorio.Size = new System.Drawing.Size(97, 19);
            this.chkRecordatorio.TabIndex = 4;
            this.chkRecordatorio.Text = "Recordatorio";
            this.chkRecordatorio.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(41, 130);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 21);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(41, 635);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 50);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(41, 517);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(192, 50);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnHabilitarEdicion
            // 
            this.btnHabilitarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarEdicion.Location = new System.Drawing.Point(846, 316);
            this.btnHabilitarEdicion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHabilitarEdicion.Name = "btnHabilitarEdicion";
            this.btnHabilitarEdicion.Size = new System.Drawing.Size(70, 99);
            this.btnHabilitarEdicion.TabIndex = 6;
            this.btnHabilitarEdicion.Text = "▶";
            this.btnHabilitarEdicion.UseVisualStyleBackColor = true;
            this.btnHabilitarEdicion.Click += new System.EventHandler(this.btnHabilitarEdicion_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 730);
            this.Controls.Add(this.btnHabilitarEdicion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordatorio de Almuerzos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.CheckBox chkNotificacionesNativas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnRestaurarTodo;
        private System.Windows.Forms.CheckBox chkNotificacionCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkRecordatorio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnHabilitarEdicion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreDia;
        private System.Windows.Forms.ComboBox cmbMinuto;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbFormatoHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Recordatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recordatorio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTodosRecordatorios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Button btnFiltrarHoy;
        private System.Windows.Forms.Button btnFiltrarMes;
        private System.Windows.Forms.Button btnFiltrarSemana;
        private System.Windows.Forms.Button btnFiltrarBusqueda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSumarUnDia;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPasswordCorreo;
    }
}

