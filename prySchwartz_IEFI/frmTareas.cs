﻿using System;
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
    public partial class frmTareas : Form
    {
        clsConexion conexion = new clsConexion();
        public frmTareas()
        {
            InitializeComponent();
        }

        private void frmTareas_Load(object sender, EventArgs e)
        {
            dgvTareas.DataSource = conexion.ejecutarConsulta("SELECT * FROM Tareas");
        }
    }
}
