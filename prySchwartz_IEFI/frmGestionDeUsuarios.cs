using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace prySchwartz_IEFI
{
    public partial class frmGestionDeUsuarios : MaterialForm
    {
        public frmGestionDeUsuarios()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        //INSTANCIACION DE CLASE CONEXION
        clsConexion conexion = new clsConexion();


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            string[] roles = {"Administrador","Operador"};
            foreach (string rol in roles) cmbRol.Items.Add(rol);

            
            dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");

            try
            {
                clsConexion conexion = new clsConexion();
                dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }

            txtContraseña.Enabled = false;
            cmbRol.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Está seguro que quiere agregar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    if (conexion.ExisteUsuario(txtUsuario.Text.Trim()))
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = $"INSERT INTO Usuarios (Usuario, Contraseña, Rol) " +
                                   $"VALUES ('{txtUsuario.Text}', '{txtContraseña.Text}', '{cmbRol.Text}')";

                    conexion.ejecutarConsulta(query);
                    MessageBox.Show("Usuario agregado.");

                    dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Esta seguro que quiere modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

            try
            {
                if (dgvUsuarios.CurrentRow == null) return;

                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);
                string query = $"UPDATE Usuarios SET Usuario='{txtUsuario.Text}', Contraseña='{txtContraseña.Text}', Rol='{cmbRol.Text}' WHERE ID={id}";

                conexion.ejecutarConsulta(query);
                MessageBox.Show("Usuario modificado.");

                dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (dgvUsuarios.CurrentRow == null) return;

                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    clsConexion conexion = new clsConexion();

                    int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);
                    string query = $"DELETE FROM Usuarios WHERE ID={id}";

                    conexion.ejecutarConsulta(query);
                    MessageBox.Show("Usuario eliminado.");

                    dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.Enabled = !string.IsNullOrWhiteSpace(txtUsuario.Text);
            ValidarCampos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            cmbRol.Enabled = !string.IsNullOrWhiteSpace(txtContraseña.Text);
            ValidarCampos();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
            txtContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
            cmbRol.SelectedItem = fila.Cells["Rol"].Value.ToString();

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void ValidarCampos()
        {
            btnAgregar.Enabled =
                !string.IsNullOrWhiteSpace(txtUsuario.Text) &&
                !string.IsNullOrWhiteSpace(txtContraseña.Text) &&
                cmbRol.SelectedIndex != -1;
        }
        private void LimpiarControles()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;

            txtContraseña.Enabled = false;
            cmbRol.Enabled = false;

            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
