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
    public partial class FrmRaza: Form
    {
        ServicioRaza servicio = new ServicioRaza();
        public FrmRaza()
        {
            InitializeComponent();
        }

        private void FrmRaza_Load(object sender, EventArgs e)
        {
            
            CargarRazas();
        }

        void CargarRazas()
        {
            //var lista = servicio.ObtenerTodas();
            //lstRazas.Items.Clear();
            //foreach (var item in lista)
            //{
            //    lstRazas.Items.Add(item.NombreRaza);
            //}

            lstRazas.DataSource = servicio.ObtenerTodas();
            lstRazas.DisplayMember = "NombreRaza";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                Raza raza = new Raza(int.Parse(txtCodigo.Text), txtNombre.Text);
                var mensaje=servicio.Agregar(raza);
                MessageBox.Show(mensaje);
                CargarRazas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtCodigo.Text);
        }

        private void Buscar(string id)
        {
            try
            {
                var raza=servicio.ObtenerPorId(int.Parse(id));
                verRaza(raza);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void verRaza(Raza raza)
        {
            txtCodigo.Text=string.Empty;
            txtNombre.Text = string.Empty;
            if (raza == null)
            {
                return;
            }
            txtCodigo.Text = raza.Id.ToString();
            txtNombre.Text = raza.Nombre;
        }

        private void lstRazas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indice= lstRazas.SelectedIndex;
            verRaza(servicio.ObtenerTodas()[indice]);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            if (MessageBox.Show("Salir", "desea salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
            
            
        }

        private void FrmRaza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Salir", "desea salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla=e.KeyChar;
            if (char.IsDigit(tecla))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
