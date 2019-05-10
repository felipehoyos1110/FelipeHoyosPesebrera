using Pesebrera.Modelos;
using Pesebrera.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesebrera.VistaModelo
{
    public class AnimalVistaModelo
    {

        public AnimalVistaModelo()
        {
            this.Bovinos = new List<Animal>();
            this.Equinos = new List<Animal>();
        }

        Archivos _Controlarchivo = new Archivos();

        public string Nombrearchivo { get; set; }
        public string NombrearchivoBovinos { get; set; }
        public string NombrearchivoEquinos { get; set; }

        public List<Animal> Bovinos { get; set; }
        public List<Animal> Equinos { get; set; }

        public string LeerAnimales()
        {
            try
            {
                //Obtiene listado de animales
                var ListaAnimales = _Controlarchivo.LeerArchivo(Nombrearchivo);

                if (ListaAnimales.Count == 0)
                {
                    return "No se encontraron registros para procesar";                   
                }

                //Recorre animales y los clasifica
                foreach (var animal in ListaAnimales)
                {
                    EscribirDatosAnimales(animal);
                }

                //Crea archivos
                _Controlarchivo.EscribirArchivo(Bovinos, NombrearchivoBovinos);
                _Controlarchivo.EscribirArchivo(Equinos, NombrearchivoEquinos);

                return "ok";
            }
            catch (Exception ex)
            {
                return "Error procesando archivos. " + ex.Message.ToString();
            }
        }

        void EscribirDatosAnimales(Animal animal)
        {
            string nombreAnimal = animal.Nombre.ToUpper();

            //Identificar el tipo de animal
            if (nombreAnimal.Contains("B"))
            {
                AgregarBovino(animal);
            }
            else
            {
                AgregarEquino(animal);
            }

        }

        void AgregarBovino(Animal animal)
        {
            Bovinos.Add(animal);
        }

        void AgregarEquino(Animal animal)
        {
            Equinos.Add(animal);
        }
    }
}
