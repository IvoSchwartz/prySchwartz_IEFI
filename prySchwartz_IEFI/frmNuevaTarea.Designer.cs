namespace prySchwartz_IEFI
{
    partial class frmNuevaTarea
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialTextBox txtNuevaTarea;
        private MaterialSkin.Controls.MaterialButton btnAgregarTarea;
        private MaterialSkin.Controls.MaterialComboBox cmbTareas;

        private MaterialSkin.Controls.MaterialTextBox txtNuevoLugar;
        private MaterialSkin.Controls.MaterialButton btnAgregarLugar;
        private MaterialSkin.Controls.MaterialComboBox cmbLugares;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNuevaTarea = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregarTarea = new MaterialSkin.Controls.MaterialButton();
            this.cmbTareas = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNuevoLugar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregarLugar = new MaterialSkin.Controls.MaterialButton();
            this.cmbLugares = new MaterialSkin.Controls.MaterialComboBox();
            this.btnModificarTarea = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarLugar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarTarea = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarLugar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtNuevaTarea
            // 
            this.txtNuevaTarea.AnimateReadOnly = false;
            this.txtNuevaTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaTarea.Depth = 0;
            this.txtNuevaTarea.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNuevaTarea.Hint = "Nueva tarea";
            this.txtNuevaTarea.LeadingIcon = null;
            this.txtNuevaTarea.Location = new System.Drawing.Point(30, 80);
            this.txtNuevaTarea.MaxLength = 50;
            this.txtNuevaTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNuevaTarea.Multiline = false;
            this.txtNuevaTarea.Name = "txtNuevaTarea";
            this.txtNuevaTarea.Size = new System.Drawing.Size(300, 50);
            this.txtNuevaTarea.TabIndex = 0;
            this.txtNuevaTarea.Text = "";
            this.txtNuevaTarea.TrailingIcon = null;
            this.txtNuevaTarea.TextChanged += new System.EventHandler(this.txtNuevaTarea_TextChanged);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTarea.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarTarea.Depth = 0;
            this.btnAgregarTarea.HighEmphasis = true;
            this.btnAgregarTarea.Icon = null;
            this.btnAgregarTarea.Location = new System.Drawing.Point(339, 80);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarTarea.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarTarea.UseAccentColor = false;
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click_1);
            // 
            // cmbTareas
            // 
            this.cmbTareas.AutoResize = false;
            this.cmbTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTareas.Depth = 0;
            this.cmbTareas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTareas.DropDownHeight = 174;
            this.cmbTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareas.DropDownWidth = 121;
            this.cmbTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTareas.ForeColor = System.Drawing.Color.Black;
            this.cmbTareas.FormattingEnabled = true;
            this.cmbTareas.IntegralHeight = false;
            this.cmbTareas.ItemHeight = 43;
            this.cmbTareas.Location = new System.Drawing.Point(30, 163);
            this.cmbTareas.MaxDropDownItems = 4;
            this.cmbTareas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTareas.Name = "cmbTareas";
            this.cmbTareas.Size = new System.Drawing.Size(300, 49);
            this.cmbTareas.StartIndex = -1;
            this.cmbTareas.TabIndex = 2;
            // 
            // txtNuevoLugar
            // 
            this.txtNuevoLugar.AnimateReadOnly = false;
            this.txtNuevoLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoLugar.Depth = 0;
            this.txtNuevoLugar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNuevoLugar.Hint = "Nuevo lugar";
            this.txtNuevoLugar.LeadingIcon = null;
            this.txtNuevoLugar.Location = new System.Drawing.Point(30, 253);
            this.txtNuevoLugar.MaxLength = 50;
            this.txtNuevoLugar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNuevoLugar.Multiline = false;
            this.txtNuevoLugar.Name = "txtNuevoLugar";
            this.txtNuevoLugar.Size = new System.Drawing.Size(300, 50);
            this.txtNuevoLugar.TabIndex = 3;
            this.txtNuevoLugar.Text = "";
            this.txtNuevoLugar.TrailingIcon = null;
            this.txtNuevoLugar.TextChanged += new System.EventHandler(this.txtNuevoLugar_TextChanged);
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarLugar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarLugar.Depth = 0;
            this.btnAgregarLugar.HighEmphasis = true;
            this.btnAgregarLugar.Icon = null;
            this.btnAgregarLugar.Location = new System.Drawing.Point(339, 253);
            this.btnAgregarLugar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarLugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarLugar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarLugar.TabIndex = 4;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarLugar.UseAccentColor = false;
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click_1);
            // 
            // cmbLugares
            // 
            this.cmbLugares.AutoResize = false;
            this.cmbLugares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLugares.Depth = 0;
            this.cmbLugares.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLugares.DropDownHeight = 174;
            this.cmbLugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugares.DropDownWidth = 121;
            this.cmbLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbLugares.ForeColor = System.Drawing.Color.Black;
            this.cmbLugares.FormattingEnabled = true;
            this.cmbLugares.IntegralHeight = false;
            this.cmbLugares.ItemHeight = 43;
            this.cmbLugares.Location = new System.Drawing.Point(30, 336);
            this.cmbLugares.MaxDropDownItems = 4;
            this.cmbLugares.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLugares.Name = "cmbLugares";
            this.cmbLugares.Size = new System.Drawing.Size(300, 49);
            this.cmbLugares.StartIndex = -1;
            this.cmbLugares.TabIndex = 5;
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarTarea.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarTarea.Depth = 0;
            this.btnModificarTarea.HighEmphasis = true;
            this.btnModificarTarea.Icon = null;
            this.btnModificarTarea.Location = new System.Drawing.Point(339, 128);
            this.btnModificarTarea.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarTarea.Size = new System.Drawing.Size(99, 36);
            this.btnModificarTarea.TabIndex = 6;
            this.btnModificarTarea.Text = "Modificar";
            this.btnModificarTarea.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarTarea.UseAccentColor = false;
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click_1);
            // 
            // btnModificarLugar
            // 
            this.btnModificarLugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarLugar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarLugar.Depth = 0;
            this.btnModificarLugar.HighEmphasis = true;
            this.btnModificarLugar.Icon = null;
            this.btnModificarLugar.Location = new System.Drawing.Point(339, 301);
            this.btnModificarLugar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarLugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarLugar.Name = "btnModificarLugar";
            this.btnModificarLugar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarLugar.Size = new System.Drawing.Size(99, 36);
            this.btnModificarLugar.TabIndex = 7;
            this.btnModificarLugar.Text = "Modificar";
            this.btnModificarLugar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarLugar.UseAccentColor = false;
            this.btnModificarLugar.UseVisualStyleBackColor = true;
            this.btnModificarLugar.Click += new System.EventHandler(this.btnModificarLugar_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarTarea.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarTarea.Depth = 0;
            this.btnEliminarTarea.HighEmphasis = true;
            this.btnEliminarTarea.Icon = null;
            this.btnEliminarTarea.Location = new System.Drawing.Point(339, 176);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarTarea.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarTarea.TabIndex = 8;
            this.btnEliminarTarea.Text = "Eliminar";
            this.btnEliminarTarea.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarTarea.UseAccentColor = false;
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click_1);
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarLugar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarLugar.Depth = 0;
            this.btnEliminarLugar.HighEmphasis = true;
            this.btnEliminarLugar.Icon = null;
            this.btnEliminarLugar.Location = new System.Drawing.Point(339, 349);
            this.btnEliminarLugar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarLugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarLugar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarLugar.TabIndex = 9;
            this.btnEliminarLugar.Text = "Eliminar";
            this.btnEliminarLugar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarLugar.UseAccentColor = false;
            this.btnEliminarLugar.UseVisualStyleBackColor = true;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // frmNuevaTarea
            // 
            this.ClientSize = new System.Drawing.Size(480, 401);
            this.Controls.Add(this.btnEliminarLugar);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnModificarLugar);
            this.Controls.Add(this.btnModificarTarea);
            this.Controls.Add(this.txtNuevaTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.cmbTareas);
            this.Controls.Add(this.txtNuevoLugar);
            this.Controls.Add(this.btnAgregarLugar);
            this.Controls.Add(this.cmbLugares);
            this.Name = "frmNuevaTarea";
            this.Text = "Creacion de Tareas y Lugares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialSkin.Controls.MaterialButton btnModificarTarea;
        private MaterialSkin.Controls.MaterialButton btnModificarLugar;
        private MaterialSkin.Controls.MaterialButton btnEliminarTarea;
        private MaterialSkin.Controls.MaterialButton btnEliminarLugar;
    }
}
