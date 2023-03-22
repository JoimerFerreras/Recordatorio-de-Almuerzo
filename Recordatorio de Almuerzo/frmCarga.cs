using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recordatorio_de_Almuerzo
{
    public partial class frmCarga : Form
    {
        int Contador = 0;
        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador++;
            label1.Text = Contador.ToString();
            if (Contador == 3)
            {
                frmPrincipal Form = new frmPrincipal();
                Form.Show();
            }
        }
    }
}
