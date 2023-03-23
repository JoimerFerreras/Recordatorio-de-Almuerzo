namespace Recordatorio_de_Almuerzo
{
    partial class frmCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recordatorioDeAlmuerzosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirPanelDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarNotificacionesNativasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarNotificacionesPorCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenuContextual = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordatorioDeAlmuerzosToolStripMenuItem,
            this.toolStripSeparator1,
            this.abrirPanelDeControlToolStripMenuItem,
            this.habilitarNotificacionesNativasToolStripMenuItem,
            this.habilitarNotificacionesPorCorreoToolStripMenuItem,
            this.cerrarAplicaciónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(255, 120);
            // 
            // recordatorioDeAlmuerzosToolStripMenuItem
            // 
            this.recordatorioDeAlmuerzosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.recordatorioDeAlmuerzosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.recordatorioDeAlmuerzosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.recordatorioDeAlmuerzosToolStripMenuItem.Name = "recordatorioDeAlmuerzosToolStripMenuItem";
            this.recordatorioDeAlmuerzosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.recordatorioDeAlmuerzosToolStripMenuItem.Text = "Recordatorio de Almuerzos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // abrirPanelDeControlToolStripMenuItem
            // 
            this.abrirPanelDeControlToolStripMenuItem.Name = "abrirPanelDeControlToolStripMenuItem";
            this.abrirPanelDeControlToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.abrirPanelDeControlToolStripMenuItem.Text = "Abrir panel de control";
            this.abrirPanelDeControlToolStripMenuItem.Click += new System.EventHandler(this.abrirPanelDeControlToolStripMenuItem_Click);
            // 
            // habilitarNotificacionesNativasToolStripMenuItem
            // 
            this.habilitarNotificacionesNativasToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.habilitarNotificacionesNativasToolStripMenuItem.Name = "habilitarNotificacionesNativasToolStripMenuItem";
            this.habilitarNotificacionesNativasToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.habilitarNotificacionesNativasToolStripMenuItem.Text = "Habilitar notificaciones nativas";
            // 
            // habilitarNotificacionesPorCorreoToolStripMenuItem
            // 
            this.habilitarNotificacionesPorCorreoToolStripMenuItem.Name = "habilitarNotificacionesPorCorreoToolStripMenuItem";
            this.habilitarNotificacionesPorCorreoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.habilitarNotificacionesPorCorreoToolStripMenuItem.Text = "Habilitar notificaciones por correo";
            // 
            // cerrarAplicaciónToolStripMenuItem
            // 
            this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
            this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar aplicación";
            // 
            // notifyIconMenuContextual
            // 
            this.notifyIconMenuContextual.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconMenuContextual.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMenuContextual.Icon")));
            this.notifyIconMenuContextual.Text = "Recordatorio de Almuerzos";
            this.notifyIconMenuContextual.Visible = true;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 104);
            this.MaximizeBox = false;
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordatorio de Almuerzos";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordatorioDeAlmuerzosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem abrirPanelDeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarNotificacionesNativasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarNotificacionesPorCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconMenuContextual;
    }
}