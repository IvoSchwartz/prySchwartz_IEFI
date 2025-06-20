﻿using System;
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
    public partial class frmInicioSesion : MaterialForm
    {
        private int intentosFallidos = 0;
        public DateTime horaInicio = DateTime.Now;

        private string usuario = string.Empty;
        public string rol;

        clsConexion conexion = new clsConexion();

        public frmInicioSesion()
        {
            InitializeComponent();

            // Configurar MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text.Trim();
            string rol = conexion.ObtenerRol(usuario).Trim();
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Complete todos los campos. ");
                return;
            }

            

            if (conexion.VerificarLogin(usuario, contraseña))
            {
                horaInicio = DateTime.Now; // <- Asignás hora de inicio
                this.usuario = usuario.Trim(); // <- Asignás el nombre de usuario
                MessageBox.Show("Bienvenido");
                string nombreUsuario = usuario.Trim();
                this.Hide();
                frmPrincipal principal = new frmPrincipal(nombreUsuario,rol);
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Usuario o contraseña incorrectos.");

                if (intentosFallidos >= 3)
                {
                    MessageBox.Show("Demasiados intentos. La app se cerrará.");
                    Application.Exit();
                }
            }
        }
    }
}
