using System;
using System.Windows.Forms;

namespace Semana5Tarea.Persistencia
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            var usuarios = new Persistencia.FrmGestionUsuarios();
            usuarios.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            var roles = new Persistencia.FrmGestionRoles();
            roles.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
