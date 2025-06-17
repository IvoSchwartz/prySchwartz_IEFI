using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MaterialSkin.Controls;

namespace prySchwartz_IEFI
{
    public partial class frmGestionDeTareas : MaterialForm
    {

        clsConexion conexion = new clsConexion();
        private string nombreUsuario;
        public frmGestionDeTareas(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }

        private void frmGestionDeTareas_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarCmb();
        }
        private void cmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarCmb();
        }

        private void cargarCombos()
        {
            cmbTarea.Items.Clear();
            cmbLugar.Items.Clear();

            foreach (string tarea in frmPrincipal.listas.ListaTareas)
                cmbTarea.Items.Add(tarea);

            foreach (string lugar in frmPrincipal.listas.ListaLugares)
                cmbLugar.Items.Add(lugar);
        }
        private void verificarCmb()
        {
            btnAgregar.Enabled = cmbLugar.SelectedIndex != -1 & cmbTarea.SelectedIndex != -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles
            string tarea = cmbTarea.SelectedItem.ToString();
            string lugar = cmbLugar.SelectedItem.ToString();
            DateTime fecha = dtpFecha.Value;
            string comentario = txtComentario.Text.Trim().Replace("'", "''"); // evitar error por comillas
            string usuario = nombreUsuario;

            // Obtener los valores de los checkboxes como 0 o 1
            int insumos = chkInsumos.Checked ? 1 : 0;
            int vacaciones = chkVacaciones.Checked ? 1 : 0;
            int estudios = chkEstudios.Checked ? 1 : 0;
            int salario = chkSalario.Checked ? 1 : 0;
            int recibo = chkRecibo.Checked ? 1 : 0;

            // Armar la consulta 
            string consulta = $@"
            INSERT INTO Tareas 
            (Tarea, Lugar, Fecha, Comentario, Usuario, Insumos, Vacaciones, Estudios, Salario, Recibo)
            VALUES (
            '{tarea}', 
            '{lugar}', 
            '{fecha:yyyy-MM-dd HH:mm:ss}', 
            '{comentario}', 
            '{usuario}', 
            {insumos}, 
            {vacaciones}, 
            {estudios}, 
            {salario}, 
            {recibo})";

            // Ejecutar consulta con tu método actual
            DataTable resultado = conexion.ejecutarConsulta(consulta);

            if (resultado != null)
            {
                MessageBox.Show("Tarea agregada con éxito.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarUltimaTarea(); 
                limpiarControles();   
            }
            else
            {
                MessageBox.Show("Error al agregar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            txtComentario.Clear();
            dtpFecha.Value = DateTime.Now;

            chkInsumos.Checked = false;
            chkVacaciones.Checked = false;
            chkEstudios.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;

            btnAgregar.Enabled = false;
        }

        private void MostrarUltimaTarea()
        {
            // Consulta para obtener la última tarea insertada (por ID o por fecha si tienes id autoincremental)
            string consulta = "SELECT TOP 1 * FROM Tareas ORDER BY idTarea DESC";


            dgvTareas.DataSource = conexion.ejecutarConsulta(consulta);
        }
    }
}
