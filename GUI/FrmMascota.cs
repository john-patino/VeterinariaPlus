using BLL;
using ENTITY;
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
    public partial class FrmMascota: Form
    {
        ServicioMascota servicioMascota = new ServicioMascota();
        ServicioRaza servicioRaza = new ServicioRaza();
        public FrmMascota()
        {
            InitializeComponent();
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            CargarRazas();
        }

        private void CargarRazas()
        {
            cbRazas.DataSource = servicioRaza.ObtenerTodas();
            cbRazas.DisplayMember = "NombreRaza";
            cbRazas.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Mascota mascota = new Mascota();

            mascota.Id = int.Parse(txtCodigo.Text);
            mascota.NombreMascota = txtNombre.Text;
            var raza = servicioRaza.ObtenerPorId(Convert.ToInt16(cbRazas.SelectedValue));
            mascota.AsignarRaza(raza);

            var mensaje = servicioMascota.Agregar(mascota);
            MessageBox.Show(mensaje);
        }
    }
}
