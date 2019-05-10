using Pesebrera.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesebrera.Utilidades
{
    public class Archivos
    {

        string fileContent;

        public List<Animal> LeerArchivo(string archivo)
        {
            List<Animal> animales = new List<Animal>();
            try
            {
                //Lee el archivo y los agrega a la lista de animales                         
                using (StreamReader reader = new StreamReader(archivo))
                {
                    while (true)
                    {
                        Animal animal = new Animal();
                        fileContent = reader.ReadLine();
                        if (fileContent == null)
                        {
                            break;
                        }
                        animal.Nombre = fileContent;
                        animales.Add(animal);
                    }
                }
            }
            catch
            {

            }

            return animales;
            
        }

        public void EscribirArchivo(List<Animal> ListaAnimales, string archivo)
        {
            //Crea archivo de animales
            try
            {
                StreamWriter sw = new StreamWriter("C:\\pesebrera\\" + archivo + ".txt", true, Encoding.ASCII);

                foreach (var Animal in ListaAnimales)
                {
                    sw.WriteLine(Animal.Nombre);
                }

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
