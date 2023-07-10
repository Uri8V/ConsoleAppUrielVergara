using ConsoleAppUrielVergara.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUrielVergara
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio N°1");

            Console.WriteLine("Informacion Cono");

            Console.Write("Ingrese el valor del Radio:  ");
            var radio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la Altura: ");
            var altura = double.Parse(Console.ReadLine());

            Cono cono = new Cono(altura, radio);
            Console.WriteLine($"{cono.GetValores()}");

            Console.WriteLine("Presione ENTER para pasar al sieguiente ejercicio");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Ejercicio N°2");
            Console.WriteLine("Ingrese una Patente");
            var r=Console.ReadLine();
            Console.WriteLine($"{ ValidadorPatente.Validar(r)}");
            Console.WriteLine("Presione ENTER para pasar al sieguiente ejercicio");
            Console.ReadLine();

            Console.Clear();

            Milla milla = new Milla();
            Kilometro klm = new Kilometro(1);
            klm = (Kilometro)milla;
            Console.WriteLine($"{klm.GetDistancia()}");
            Milla millas = new Milla();
            Kilometro kilometro = new Kilometro();
            Yarda yarda = new Yarda();

            kilometro = (Kilometro)millas;
            kilometro=(Kilometro)yarda;
            millas = (Milla)yarda;
            millas = (Milla)kilometro;
            yarda = (Yarda)kilometro;
            yarda = (Yarda)millas;

            float f=0;
            kilometro = f;
            millas = f;
            yarda = f;
        }
    }
}
