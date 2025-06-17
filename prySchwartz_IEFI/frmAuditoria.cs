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
    public partial class frmAuditoria : MaterialForm
    {
        public frmAuditoria()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            dgvAuditoria.DataSource = conexion.ejecutarConsulta("SELECT * FROM HistorialAccesos ORDER BY FechaHoraDeInicio DESC");
        }
    }
}
