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
    public partial class FrmPropietario: Form
    {
        ServicioPropietario servicio = new ServicioPropietario();

        public FrmPropietario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            if (MessageBox.Show("desea salir ...?","Salir de Propiestario",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Dispose();
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                if (txtCodigo.Text==string.Empty)
                {
                    return;
                }
                Propietario persona = new Propietario(int.Parse(txtCodigo.Text.Trim()),txtNombre.Text,txtTelefono.Text);
                var mensaje = servicio.Agregar(persona);
                MessageBox.Show(mensaje);
                CargarListaPropietarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            CargarListaPropietarios();
        }

        private void CargarListaPropietarios()
        {
            //lstPropietarios.DataSource = servicio.ObtenerTodas();
            //lstPropietarios.DisplayMember = "Nombre";

            lstPropietarios.Items.Clear();

            var lista = servicio.ObtenerTodas();
            foreach (var item in lista)
            {
                lstPropietarios.Items.Add(item.Nombre);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                var id = int.Parse(txtCodigo.Text);
                var propietario = servicio.ObtenerPorId(id);
                VerPropietario(propietario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void VerPropietario(Propietario propietario)
        {
            if (propietario==null)
            {
                return;
            }
            txtCodigo.Text = propietario.Id.ToString();
            txtNombre.Text = propietario.Nombre;
            txtTelefono.Text = propietario.TelefonoContacto;
            txtCodigo.Focus();
        }

        private void lstPropietarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index= lstPropietarios.SelectedIndex;
            VerPropietario(servicio.ObtenerTodas()[index]);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            new FrmConsulatPropietario().ShowDialog();
        }
    }
}
