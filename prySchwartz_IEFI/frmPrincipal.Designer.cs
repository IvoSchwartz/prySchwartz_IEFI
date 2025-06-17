namespace prySchwartz_IEFI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.verTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionToolStripMenuItem,
            this.gestionDeTareasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.verTareasToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // creacionToolStripMenuItem
            // 
            this.creacionToolStripMenuItem.Name = "creacionToolStripMenuItem";
            this.creacionToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.creacionToolStripMenuItem.Text = "Registrar nueva tarea o lugar...";
            this.creacionToolStripMenuItem.Click += new System.EventHandler(this.creacionToolStripMenuItem_Click);
            // 
            // gestionDeTareasToolStripMenuItem
            // 
            this.gestionDeTareasToolStripMenuItem.Name = "gestionDeTareasToolStripMenuItem";
            this.gestionDeTareasToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.gestionDeTareasToolStripMenuItem.Text = "Gestion de tareas...";
            this.gestionDeTareasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeTareasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(289, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(289, 6);
            // 
            // verTareasToolStripMenuItem
            // 
            this.verTareasToolStripMenuItem.Name = "verTareasToolStripMenuItem";
            this.verTareasToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.verTareasToolStripMenuItem.Text = "Ver tareas...";
            this.verTareasToolStripMenuItem.Click += new System.EventHandler(this.verTareasToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditoríaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gestionDeUsuariosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // auditoríaToolStripMenuItem
            // 
            this.auditoríaToolStripMenuItem.Name = "auditoríaToolStripMenuItem";
            this.auditoríaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.auditoríaToolStripMenuItem.Text = "Auditoría...";
            this.auditoríaToolStripMenuItem.Click += new System.EventHandler(this.auditoríaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion De Usuarios...";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioStatus,
            this.lblFechaStatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuarioStatus
            // 
            this.lblUsuarioStatus.Name = "lblUsuarioStatus";
            this.lblUsuarioStatus.Size = new System.Drawing.Size(66, 20);
            this.lblUsuarioStatus.Text = "Usuario: ";
            // 
            // lblFechaStatus
            // 
            this.lblFechaStatus.Name = "lblFechaStatus";
            this.lblFechaStatus.Size = new System.Drawing.Size(54, 20);
            this.lblFechaStatus.Text = "Fecha: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoríaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuarioStatus;
        public System.Windows.Forms.ToolStripStatusLabel lblFechaStatus;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}
