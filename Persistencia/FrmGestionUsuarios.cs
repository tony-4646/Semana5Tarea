using System;
using System.Linq;
using System.Windows.Forms;

namespace Semana5Tarea.Persistencia
{
    public partial class FrmGestionUsuarios : Form
    {
        private readonly Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        private readonly Aplicacion.RolesService _rolesService = new Aplicacion.RolesService();
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            var ingreso = new Persistencia.FrmIngreso();
            ingreso.Show();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            this.cargaLista();
        }
        public void cargaLista()
        {
            lstUsuarios.DataSource = _usuarioService.todos().ToList();
            lstUsuarios.DisplayMember = "Nombre";
            lstUsuarios.ValueMember = "UsuarioId";

            _todosRoles();

            txtNombreUsuario.Text = "";
            txtCorreoUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
            cmbRolUsuario.SelectedIndex = -1;
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem is Datos.UsuariosDTO seleccion)
            {
                txtNombreUsuario.Text = seleccion.Nombre;
                txtCorreoUsuario.Text = seleccion.correo;
                txtContrasenaUsuario.Text = seleccion.password;
                cmbRolUsuario.SelectedValue = seleccion.IdRol;
            }
        }

        private void _todosRoles()
        {
            cmbRolUsuario.DataSource = _rolesService.todos();
            cmbRolUsuario.DisplayMember = "Detalle";
            cmbRolUsuario.ValueMember = "RolesId";
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtCorreoUsuario.Text) || string.IsNullOrWhiteSpace(txtCorreoUsuario.Text) ||
                string.IsNullOrEmpty(txtContrasenaUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenaUsuario.Text))
            {
                MessageBox.Show("¡Complete todos los campos!");
            }
            else if (cmbRolUsuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol, o cree uno nuevo si no existe");
                return;
            }
            else
            {
                var user = new Datos.UsuariosDTO
                {
                    Nombre = txtNombreUsuario.Text.Trim(),
                    correo = txtCorreoUsuario.Text.Trim(),
                    password = txtContrasenaUsuario.Text.Trim(),
                    IdRol = (int)cmbRolUsuario.SelectedValue
                };
                if (_usuarioService.insertar(user) == "ok")
                {
                    MessageBox.Show("Se guardó con éxito.");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("¡Error! Datos duplicados.");
                    limpiarCampos();
                }
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                limpiarCampos();
                return;
            }
            btnEditarUsuario.Enabled = false;
            btnInsertarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            btnGuardarUsuario.Enabled = true;
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea editar el usuario seleccionado?", "Confirmar edición",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                if (lstUsuarios.SelectedItem is Datos.UsuariosDTO seleccion)
                {
                    var usuarioActualizado = new Datos.UsuariosDTO
                    {
                        UsuarioId = seleccion.UsuarioId,
                        Nombre = txtNombreUsuario.Text.Trim(),
                        correo = txtCorreoUsuario.Text.Trim(),
                        password = txtContrasenaUsuario.Text.Trim(),
                        IdRol = (int)cmbRolUsuario.SelectedValue
                    };

                    if (_usuarioService.actualizar(usuarioActualizado) == "ok")
                    {
                        MessageBox.Show("Se actualizó con éxito.");
                        this.cargaLista();
                        btnEditarUsuario.Enabled = true;
                        btnInsertarUsuario.Enabled = true;
                        btnEliminarUsuario.Enabled = true;
                        btnGuardarUsuario.Enabled = false;
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al actualizar.");
                        btnEditarUsuario.Enabled = true;
                        btnInsertarUsuario.Enabled = true;
                        btnEliminarUsuario.Enabled = true;
                        btnGuardarUsuario.Enabled = false;
                        limpiarCampos();
                    }
                }
            }
            else
            {
                btnEditarUsuario.Enabled = true;
                btnInsertarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                btnGuardarUsuario.Enabled = false;
                limpiarCampos();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario de la lista.");
                return;
            }

            int id = (int)lstUsuarios.SelectedValue;

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (_usuarioService.eliminar(id) == "ok")
                {
                    MessageBox.Show("Se eliminó con éxito");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar.");
                }
            }
        }
        private void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtCorreoUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
            cmbRolUsuario.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cmbRolUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInsertarUsuario.PerformClick();
            }
        }
    }
}
