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

namespace prySchwartz_IEFI
{
    public partial class frmPrincipal : MaterialForm
    {
        private string nombreUsuario;
        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;

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
            lblUsuariosStatus.Text = $"Usuario: {nombreUsuario}";
            lblFechaStatus.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria();
            auditoria.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime horaCierre = DateTime.Now;
            TimeSpan duracion = horaCierre - ((frmInicioSesion)Application.OpenForms["frmInicioSesion"]).horaInicio;

            clsConexion conexion = new clsConexion();
            conexion.auditarAcceso(nombreUsuario, ((frmInicioSesion)Application.OpenForms["frmInicioSesion"]).horaInicio, horaCierre, duracion);
            Environment.Exit(0);
        }
    }
}
