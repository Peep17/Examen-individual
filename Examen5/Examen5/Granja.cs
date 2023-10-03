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

        public Granja()
        {
            listaPlantas = new List<Planta>();
            listaAnimales = new List<Animal>();
        }

        public void AgregarPlanta(Planta planta)
        {
            listaPlantas.Add(planta);
        }

        public void AgregarAnimal(Animal animal)
        {
            listaAnimales.Add(animal);
        }

        public List<Planta> ListaPlantas()
        {
            return listaPlantas;
        }

        public List<Animal> ListaAnimales()
        {
            return listaAnimales;
        }
    }
}
