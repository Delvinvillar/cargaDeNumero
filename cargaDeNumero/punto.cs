using cargaDeNumero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cargaDeNumero
{
    public class punto
    {
        private int x;
        private int y;

        public void cargarPunto(int x, int y)
        {
         this .x = x;
         this .y = y;
        }
        public void imprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("el punto se encuentra en el primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("el punto se encuentra en el segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("el punto se encuentra en el tercer cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("el punto se encuentra en elcuarto cuadrante");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("el punto se encuentra en el eje y");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("el punto se encuentra en el eje x");
            }
            else
            {
                Console.WriteLine("el punto se encuenta en el origen");
            }




        }
    }
}
