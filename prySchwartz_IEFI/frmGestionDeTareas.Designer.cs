using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace prySchwartz_IEFI
{
    partial class frmGestionDeTareas
    {
        private MaterialComboBox cmbTarea;
        private MaterialComboBox cmbLugar;
        private MaterialMultiLineTextBox txtComentario;
        private DateTimePicker dtpFecha;
        private GroupBox groupBoxDetalles;
        private CheckBox chkInsumos;
        private CheckBox chkVacaciones;
        private CheckBox chkEstudios;
        private CheckBox chkSalario;
        private CheckBox chkRecibo;
        private MaterialButton btnAgregar;
        private DataGridView dgvTareas;

        private void InitializeComponent()
        {
            this.cmbTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbLugar = new MaterialSkin.Controls.MaterialComboBox();
            this.txtComentario = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.chkInsumos = new System.Windows.Forms.CheckBox();
            this.chkVacaciones = new System.Windows.Forms.CheckBox();
            this.chkEstudios = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTarea
            // 
            this.cmbTarea.AutoResize = false;
            this.cmbTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTarea.Depth = 0;
            this.cmbTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTarea.DropDownHeight = 174;
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.DropDownWidth = 121;
            this.cmbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTarea.Hint = "Seleccione una tarea";
            this.cmbTarea.IntegralHeight = false;
            this.cmbTarea.ItemHeight = 43;
            this.cmbTarea.Location = new System.Drawing.Point(20, 80);
            this.cmbTarea.MaxDropDownItems = 4;
            this.cmbTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(250, 49);
            this.cmbTarea.StartIndex = 0;
            this.cmbTarea.TabIndex = 0;
            this.cmbTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTarea_SelectedIndexChanged);
            // 
            // cmbLugar
            // 
            this.cmbLugar.AutoResize = false;
            this.cmbLugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLugar.Depth = 0;
            this.cmbLugar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLugar.DropDownHeight = 174;
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.DropDownWidth = 121;
            this.cmbLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLugar.Hint = "Seleccione un lugar";
            this.cmbLugar.IntegralHeight = false;
            this.cmbLugar.ItemHeight = 43;
            this.cmbLugar.Location = new System.Drawing.Point(290, 80);
            this.cmbLugar.MaxDropDownItems = 4;
            this.cmbLugar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(250, 49);
            this.cmbLugar.StartIndex = 0;
            this.cmbLugar.TabIndex = 1;
            this.cmbLugar.SelectedIndexChanged += new System.EventHandler(this.cmbLugar_SelectedIndexChanged);
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComentario.Depth = 0;
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtComentario.Hint = "Comentario";
            this.txtComentario.Location = new System.Drawing.Point(20, 140);
            this.txtComentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(520, 80);
            this.txtComentario.TabIndex = 2;
            this.txtComentario.Text = "";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(20, 240);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.chkInsumos);
            this.groupBoxDetalles.Controls.Add(this.chkVacaciones);
            this.groupBoxDetalles.Controls.Add(this.chkEstudios);
            this.groupBoxDetalles.Controls.Add(this.chkSalario);
            this.groupBoxDetalles.Controls.Add(this.chkRecibo);
            this.groupBoxDetalles.Location = new System.Drawing.Point(20, 280);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Size = new System.Drawing.Size(520, 120);
            this.groupBoxDetalles.TabIndex = 4;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles";
            // 
            // chkInsumos
            // 
            this.chkInsumos.Location = new System.Drawing.Point(20, 25);
            this.chkInsumos.Name = "chkInsumos";
            this.chkInsumos.Size = new System.Drawing.Size(104, 24);
            this.chkInsumos.TabIndex = 0;
            this.chkInsumos.Text = "Insumos";
            // 
            // chkVacaciones
            // 
            this.chkVacaciones.Location = new System.Drawing.Point(150, 25);
            this.chkVacaciones.Name = "chkVacaciones";
            this.chkVacaciones.Size = new System.Drawing.Size(104, 24);
            this.chkVacaciones.TabIndex = 1;
            this.chkVacaciones.Text = "Vacaciones";
            // 
            // chkEstudios
            // 
            this.chkEstudios.Location = new System.Drawing.Point(280, 25);
            this.chkEstudios.Name = "chkEstudios";
            this.chkEstudios.Size = new System.Drawing.Size(104, 24);
            this.chkEstudios.TabIndex = 2;
            this.chkEstudios.Text = "Estudios";
            // 
            // chkSalario
            // 
            this.chkSalario.Location = new System.Drawing.Point(20, 60);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(104, 24);
            this.chkSalario.TabIndex = 3;
            this.chkSalario.Text = "Salario";
            // 
            // chkRecibo
            // 
            this.chkRecibo.Location = new System.Drawing.Point(150, 60);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(104, 24);
            this.chkRecibo.TabIndex = 4;
            this.chkRecibo.Text = "Recibo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(107, 420);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeight = 29;
            this.dgvTareas.Location = new System.Drawing.Point(20, 470);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(520, 180);
            this.dgvTareas.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(20, 420);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(79, 36);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmGestionDeTareas
            // 
            this.ClientSize = new System.Drawing.Size(580, 700);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbTarea);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTareas);
            this.Name = "frmGestionDeTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Tareas";
            this.Load += new System.EventHandler(this.frmGestionDeTareas_Load);
            this.groupBoxDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialButton btnLimpiar;
    }
}
