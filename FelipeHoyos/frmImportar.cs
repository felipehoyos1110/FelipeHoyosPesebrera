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
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "DAT files (*.DAT)|*.DAT|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtRutaArchivo.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (true)
                        {
                            fileContent = reader.ReadLine();
                            if (fileContent == null)
                            {
                                break;
                            }

                            if (fileContent.Contains("B"))
                            {
                                Escribir("Bovinos", fileContent);
                            }
                            else
                            {
                                Escribir("Equinos", fileContent);
                            }

                        }
                    }
                }
            }
        }

        void Escribir(string archivo, string texto)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\pesebrera\\" + archivo + ".txt");

                //Write a line of text
                sw.WriteLine(texto);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
