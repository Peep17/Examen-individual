using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5
{
    class Plantas
    {
        private string nombre;
        private int TiempoVida;
        private int FrutasVerduras;
        private float ValorSemilla;
        private float ValorProducto;

        public string Nombre
        {
            get
            {
                return nombre;
            }

        }
        public Plantas(string nombre, int TiempoVida, int FrutasVerduras, float ValorSemilla, float ValorProducto) 
        {
            this.nombre = nombre;
            this.TiempoVida = TiempoVida;
            this.FrutasVerduras = FrutasVerduras;
            this.ValorSemilla = ValorSemilla;
            this.ValorProducto = ValorProducto;
        }

        public float ValordeSemilla() 
        {
            return ValorSemilla;
        }

        public float ValordeProducto()
        {
            return ValorSemilla;
        }

        public int ObtenerelTiempo()
        {
            return TiempoVida;
        }

        public void Cosechar()
        {
            Console.WriteLine($"Has cosechado la planta '{nombre}' y has obtenido {FrutasVerduras} productos.");
        }


    }
}
