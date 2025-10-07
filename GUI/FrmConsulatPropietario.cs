using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsulatPropietario: Form
    {
        ServicioPropietario servicio = new ServicioPropietario();
        public FrmConsulatPropietario()
        {
            InitializeComponent();
        }

        private void FrmConsulatPropietario_Load(object sender, EventArgs e)
        {
            CargarPropietarios();
            CargarPropietarios2();
        }

        private void CargarPropietarios()
        {
            dgvPropieatrios.DataSource = servicio.ObtenerTodas();
        }
        private void CargarPropietarios2()
        {
            grilla2.Rows.Clear();
            foreach (var item in servicio.ObtenerTodas())
            {
                grilla2.Rows.Add(item.Id, item.Nombre, item.TelefonoContacto);
            }
        }
    }
}
