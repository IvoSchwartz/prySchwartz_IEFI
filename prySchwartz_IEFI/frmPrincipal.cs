using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace prySchwartz_IEFI
{
    public partial class frmPrincipal : MaterialForm
    {
        public string nombreUsuario;
        private string rolUsuario;

        public frmPrincipal(string usuario, string rol)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            rolUsuario = rol;
            CargarListas();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuarioStatus.Text = $"Usuario: {nombreUsuario}";
            lblFechaStatus.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria();
            auditoria.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarListas();
            DateTime horaCierre = DateTime.Now;
            TimeSpan duracion = horaCierre - ((frmInicioSesion)Application.OpenForms["frmInicioSesion"]).horaInicio;

            clsConexion conexion = new clsConexion();
            conexion.auditarAcceso(nombreUsuario, ((frmInicioSesion)Application.OpenForms["frmInicioSesion"]).horaInicio, horaCierre, duracion);
            Environment.Exit(0);
        }


        private void auditoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir el formulario frmAuditoria cuando se haga click en Auditoría
            frmAuditoria frm = new frmAuditoria();
            frm.ShowDialog();
        }
        private void gestionDeUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (rolUsuario.ToLower() == "administrador")
            {
                frmGestionDeUsuarios formUsuarios = new frmGestionDeUsuarios();
                formUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso restringido solo a administradores.");
            }
        }

        private void creacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rolUsuario.ToLower() == "administrador")
            {
                frmNuevaTarea crearLugarTarea = new frmNuevaTarea();
                crearLugarTarea.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso restringido. Solo los administradores pueden gestionar tareas y lugares.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gestionDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDeTareas gestionDeTareas = new frmGestionDeTareas(nombreUsuario);
            gestionDeTareas.ShowDialog();
        }

        private void verTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTareas verTareas = new frmTareas();
            verTareas.ShowDialog();
        }


        public static class listas
        {
            
            
            public static List<string> ListaTareas = new List<string>();
            public static List<string> ListaLugares = new List<string>();
        }

        public static void GuardarListas()
        {
            File.WriteAllLines("tareas.txt", listas.ListaTareas);
            File.WriteAllLines("lugares.txt", listas.ListaLugares);
        }

        public static void CargarListas()
        {
            if (File.Exists("tareas.txt"))
                listas.ListaTareas = File.ReadAllLines("tareas.txt").ToList();

            if (File.Exists("lugares.txt"))
                listas.ListaLugares = File.ReadAllLines("lugares.txt").ToList();
        }

    }
}
