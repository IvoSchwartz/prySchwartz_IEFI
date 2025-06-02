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
    public partial class frmUsuarios : MaterialForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            string[] roles = {"Administrador","Operador"};
            foreach (string rol in roles) cmbRol.Items.Add(rol);

            clsConexion conexion = new clsConexion();
            dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }
            

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsConexion conexion = new clsConexion();
            string query = $"INSERT INTO Usuarios (Usuario, Contraseña, Rol) " +
                           $"VALUES ('{txtUsuario.Text}', '{txtContraseña.Text}', '{cmbRol.Text}')";

            conexion.ejecutarConsulta(query);
            MessageBox.Show("Usuario agregado.");
            dgvUsuarios.DataSource = conexion.ejecutarConsulta("SELECT * FROM Usuarios");
        }
    }
}
