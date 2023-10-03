using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5
{
    class Animales
    {
        private string nombre;
        private int TiempoVida;
        private int CantidadCarne;
        private int CantidadLeche;
        private int CantidadHuevos;
        private int CantidadLana;
        private float PrecioAnimal;
        private float PrecioFinales;


        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public Animales(string nombre,int TiempoVida,int CantidadCarne,int CantidadLeche,int CantidadHuevos, int CantidadLana, float PrecioAnimal, float PrecioFinales)
        {
            this.nombre = nombre;
            this.TiempoVida = TiempoVida;
            this.CantidadCarne = CantidadCarne;
            this.CantidadCarne = CantidadLeche;
            this.CantidadCarne = CantidadHuevos;
            this.CantidadLana = CantidadLana;
            this.PrecioAnimal = PrecioAnimal;
            this.PrecioFinales = PrecioFinales;
        }

        public float Precioanimal()
        {
            return PrecioAnimal;
        }

        public float Preciofinales()
        {
            return PrecioFinales;
        }

        public int Untiempodevida()
        {
            return TiempoVida;
        }

        public int Cantidaddecarne()
        {
            return CantidadCarne;
        }

        public int Cantidaddeleche()
        {
            return CantidadLeche;
        }

        public int Cantidaddehuevos()
        {
            return CantidadHuevos;
        }

        public int Cantidaddelana()
        {
            return CantidadLana;
        }
    }
}
