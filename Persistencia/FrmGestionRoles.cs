using System;
using System.Linq;
using System.Windows.Forms;

namespace Semana5Tarea.Persistencia
{
    public partial class FrmGestionRoles : Form
    {
        private readonly Aplicacion.RolesService _rolesService = new Aplicacion.RolesService();
        public FrmGestionRoles()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            var ingreso = new Persistencia.FrmIngreso();
            ingreso.Show();
        }

        private void FrmGestionRoles_Load(object sender, EventArgs e)
        {
            this.cargaLista();
        }

        public void cargaLista()
        {
            lstRoles.DataSource = _rolesService.todos().ToList();
            lstRoles.DisplayMember = "Detalle";
            lstRoles.ValueMember = "RolesId";
            txtNombreRol.Text = "";
        }

        private void btnInsertarRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreRol.Text) || string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                MessageBox.Show("¡Proporciona un titulo!");
            }
            else
            {
                var rol = new Datos.RolesDTO
                {
                    Detalle = txtNombreRol.Text.Trim(),

                };
                if (_rolesService.insertar(rol) == "ok")
                {
                    MessageBox.Show("Se guardó con éxito.");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("¡Error! Datos duplicados.");
                    txtNombreRol.Text = "";
                }
            }
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol de la lista.");
                txtNombreRol.Text = "";
                return;
            }
            else
            {
                btnEditarRol.Enabled = false;   
                btnInsertarRol.Enabled = false;
                btnEliminarRol.Enabled = false;
                btnGuardarEditado.Enabled = true;
            }
        }
        private void btnGuardarEditado_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea editar el rol seleccionado?", "Confirmar edición",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {

                var rolactualizar = new Datos.RolesDTO
                {
                    RolesId = (int)lstRoles.SelectedValue,
                    Detalle = txtNombreRol.Text.Trim()
                };
                if (_rolesService.actualizar(rolactualizar) == "ok")
                {
                    MessageBox.Show("Se guardó con éxito.");
                    this.cargaLista();
                    btnEditarRol.Enabled = true;
                    btnInsertarRol.Enabled = true;
                    btnEliminarRol.Enabled = true;
                    btnGuardarEditado.Enabled = false;
                    txtNombreRol.Text = "";
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar.");
                    btnEditarRol.Enabled = true;
                    btnInsertarRol.Enabled = true;
                    btnEliminarRol.Enabled = true;
                    btnGuardarEditado.Enabled = false;
                    txtNombreRol.Text = "";
                }
            }
            else
            {
                btnEditarRol.Enabled = true;
                btnInsertarRol.Enabled = true;
                btnEliminarRol.Enabled = true;
                btnGuardarEditado.Enabled = false;
                txtNombreRol.Text = "";
            }
        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos.RolesDTO seleccion = (Datos.RolesDTO)lstRoles.SelectedItem;
            txtNombreRol.Text = seleccion.Detalle;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreRol.Text = "";
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol de la lista");
                return;
            }
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de eliminarlo? ¡El rol se eliminará junto a los usuarios que lo tengan!", "Confirmar eliminación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmacion == DialogResult.Yes)
            {
                if (_rolesService.eliminar(Convert.ToInt32(lstRoles.SelectedValue)) == "ok")
                {
                    MessageBox.Show("Se eliminÓ con éxito.");
                    this.cargaLista();
                }
            }
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInsertarRol.PerformClick(); 
            }
        }
    }
}
