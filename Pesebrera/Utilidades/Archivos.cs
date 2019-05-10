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
 
            return animales;
            
        }

        public void EscribirArchivo(List<Animal> ListaAnimales, string archivo)
        {
            //Crea archivo de animales
               
            StreamWriter sw = new StreamWriter(archivo, true, Encoding.ASCII);

            foreach (var Animal in ListaAnimales)
            {
                sw.WriteLine(Animal.Nombre);
            }

            //Cerrar archivo
            sw.Close();

        }

    }
}
