using System;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string identificacion, nombre;
            int edad;
            string sexo;
            decimal pulsacion;

            Console.WriteLine("Calculo de Pulsaciones!!!");
            Console.WriteLine("Digite la Identificación");
            identificacion = Console.ReadLine();
            Console.WriteLine("Digite la Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la Edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Sexo");
           sexo = Console.ReadLine();
            if (sexo.ToUpper().Equals("F"))
            {
                pulsacion = (220 - edad) / 10;
            }
            else if (sexo.ToUpper().Equals("M"))
            {
                pulsacion = (210 - edad) / 10;
            }
            else
            {
                pulsacion = 0;
            }

            Console.WriteLine($"Señor(a) {nombre} de acuerdo a su edad {edad} y su sexo {sexo} su pulsacióne es {pulsacion}");
        }
    }
}
