using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> colores =
                new List<string>();

            colores.Add("Azul");
            colores.Add("Amarillo");
            colores.Add("Rojo");
            colores.Add("Verde");

            colores.RemoveAt(1);
            colores.Remove("Amarillo");

            Console.WriteLine("Numerode elementos: " + colores.Count);

            int IndiceColor = 1;
            foreach (string color in colores)
            {
                Console.WriteLine(
                    "Elemento " + IndiceColor.ToString() +
                    ":" + color);

                IndiceColor++;
            }
            Console.Read();
        }
    }
}
