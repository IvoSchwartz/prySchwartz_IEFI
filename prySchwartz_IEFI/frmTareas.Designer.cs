using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace prySchwartz_IEFI
{
    partial class frmTareas
    {
        private Label lblTitulo;
        private DataGridView dgvTareas;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Todas las tareas";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.ColumnHeadersHeight = 29;
            this.dgvTareas.Location = new System.Drawing.Point(20, 120);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(600, 400);
            this.dgvTareas.TabIndex = 1;
            // 
            // frmTareas
            // 
            this.ClientSize = new System.Drawing.Size(642, 533);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvTareas);
            this.Name = "frmTareas";
            this.Text = "Listado de Tareas";
            this.Load += new System.EventHandler(this.frmTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
