using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PRUEBA
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("click en el boton");

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            var ruta = ofd.FileName;
            pbFoto.ImageLocation = ruta;

        }
    }
}
