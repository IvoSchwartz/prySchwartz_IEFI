using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySchwartz_IEFI
{
    public partial class frmNuevaTarea : MaterialForm
    {
        
        public frmNuevaTarea()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);

            actualizarCombo(cmbTareas, frmPrincipal.listas.ListaTareas);
            actualizarCombo(cmbLugares, frmPrincipal.listas.ListaLugares);
        }

        private void txtNuevaTarea_TextChanged(object sender, EventArgs e)
        {
            btnAgregarTarea.Enabled = !string.IsNullOrWhiteSpace(txtNuevaTarea.Text);
        }

        private void txtNuevoLugar_TextChanged(object sender, EventArgs e)
        {
            btnAgregarLugar.Enabled = !string.IsNullOrWhiteSpace(txtNuevoLugar.Text);
        }

        private void btnAgregarTarea_Click_1(object sender, EventArgs e)
        {
            agregarElemento(frmPrincipal.listas.ListaTareas, "tarea", txtNuevaTarea, cmbTareas);
        }

        private void btnModificarTarea_Click_1(object sender, EventArgs e)
        {
            modificarElemento(frmPrincipal.listas.ListaTareas, "tarea", cmbTareas, txtNuevaTarea);
        }

        private void btnEliminarTarea_Click_1(object sender, EventArgs e)
        {
            eliminarElemento(frmPrincipal.listas.ListaTareas, "tarea", cmbTareas);
        }

        private void btnAgregarLugar_Click_1(object sender, EventArgs e)
        {
            agregarElemento(frmPrincipal.listas.ListaLugares, "lugar", txtNuevoLugar, cmbLugares);
        }

        private void btnModificarLugar_Click(object sender, EventArgs e)
        {
            modificarElemento(frmPrincipal.listas.ListaLugares, "lugar", cmbLugares, txtNuevoLugar);
        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            eliminarElemento(frmPrincipal.listas.ListaLugares, "lugar", cmbLugares);
        }


        private void agregarElemento(List<string> lista, string nombreElemento, MaterialSkin.Controls.MaterialTextBox txt, ComboBox cmb)
        {
            string nuevo = txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevo))
            {
                MessageBox.Show($"Ingrese el nombre del nuevo {nombreElemento}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lista.Contains(nuevo, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show($"El {nombreElemento} ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Desea agregar el {nombreElemento} '{nuevo}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                lista.Add(nuevo);
                MessageBox.Show($"{aTitulo(nombreElemento)} agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarCombo(cmb, lista);
                txt.Clear();
            }
        }

        private void modificarElemento(List<string> lista, string nombreElemento, ComboBox cmb, MaterialSkin.Controls.MaterialTextBox txt)
        {
            string original = cmb.Text.Trim();
            string nuevo = txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(original) || string.IsNullOrWhiteSpace(nuevo))
            {
                MessageBox.Show($"Seleccione un {nombreElemento} y escriba el nuevo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Desea modificar el {nombreElemento} '{original}' por '{nuevo}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = lista.FindIndex(x => x.Equals(original, StringComparison.OrdinalIgnoreCase));
                if (indice != -1)
                {
                    lista[indice] = nuevo;
                    MessageBox.Show($"{aTitulo(nombreElemento)} modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarCombo(cmb, lista);
                    txt.Clear();
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void eliminarElemento(List<string> lista, string nombreElemento, ComboBox cmb)
        {
            string seleccionado = cmb.Text.Trim();

            if (string.IsNullOrWhiteSpace(seleccionado))
            {
                MessageBox.Show($"Seleccione un {nombreElemento} para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Desea eliminar el {nombreElemento} '{seleccionado}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                lista.RemoveAll(x => x.Equals(seleccionado, StringComparison.OrdinalIgnoreCase));
                MessageBox.Show($"{aTitulo(nombreElemento)} eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarCombo(cmb, lista);
                cmb.SelectedIndex = -1;
            }
        }
        private void actualizarCombo(ComboBox cmb, List<string> lista)
        {
            cmb.DataSource = null;
            cmb.DataSource = lista.OrderBy(x => x).ToList();
        }

        private string aTitulo(string texto)
        {
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

    }
}