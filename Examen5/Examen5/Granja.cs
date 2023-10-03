using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5
{

    class Planta
    {
        public string nombre;
        public int TiempoVida;
        public int FrutasVerduras;
        public float ValorSemilla;
        public float ValorProducto;

    }

    class Animal
    {
        public string nombre;
        public int TiempoVida;
        public int CantidadCarne;
        public int CantidadLeche;
        public int CantidadHuevos;
        public int CantidadLana;
        public float PrecioAnimal;
        public float PrecioFinales;
    }
    class Granja
    {
        private List<Planta> listaPlantas;
        private List<Animal> listaAnimales;
        private float precioPorCompra;

        public Granja()
        {
            listaPlantas = new List<Planta>();
            listaAnimales = new List<Animal>();
            precioPorCompra = 10;

        }

        public void ComprarPlanta(Planta planta)
        {
            listaPlantas.Add(planta);
            Console.WriteLine($"Has comprado una planta '{planta.nombre}' por ${precioPorCompra}");
            precioPorCompra += 10; 
        }

        public void ComprarAnimal(Animal animal)
        {
            listaAnimales.Add(animal);
            Console.WriteLine($"Has comprado un animal '{animal.nombre}' por ${precioPorCompra}");
            precioPorCompra += 10; 
        }

        public List<Planta> ObtenerPlantas()
        {
            return listaPlantas;
        }

        public List<Animal> ObtenerAnimales()
        {
            return listaAnimales;
        }


    }
}
