using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ts13git_PABM_1109623
{
    internal class Persona
    {
        private string Nombre;
        private string Apellido;
        private int Edad;
        private double Altura;
        public Persona()
        {


            Console.WriteLine("Ingrese un Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un Apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Edad");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Altura");
            Altura = Convert.ToDouble(Console.ReadLine());

        }
        public void NombreCompleto()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Edad: " + Edad + "años");
            Console.WriteLine("Altura: " + Altura + "cm");
        }


        static void Main(string[] args)
        {

            string menu = "";
            while (!menu.Equals("3"))
            {
                Console.WriteLine("Trabajo supervisado semana 13_PABM_1109623");
                Console.WriteLine("Ingrese una opción del menú");
                Console.WriteLine("1. Altura de una persona" + "\n2. Tabla de multiplicación" + "\n3. Salir");
                int mum = Convert.ToInt32(Console.ReadLine());
                switch (mum)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Trabajo supervisado semana 13_PABM_1109623");
                        Console.WriteLine("Altura de una persona\n");
                        Persona met = new Persona();
                        met.NombreCompleto();


                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
