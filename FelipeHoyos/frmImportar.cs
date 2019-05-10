using Pesebrera.VistaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelipeHoyos
{
    public partial class frmImportar : Form
    {
        public frmImportar()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "DAT files (*.DAT)|*.DAT|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Obtener la direccion del archivo
                    txtRutaArchivo.Text = openFileDialog.FileName;                 
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            AnimalVistaModelo animal = new AnimalVistaModelo();

            //Generar archivos
            animal.Nombrearchivo = txtRutaArchivo.Text;
            string resultado = animal.LeerAnimales();

            if (resultado == "ok")
            {
                MessageBox.Show("Proceso terminado.", "Pesebrera",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Pesebrera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
