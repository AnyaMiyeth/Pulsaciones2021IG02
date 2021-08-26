using System;
using Logica;
using Entidades;
namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string identificacion, nombre;
            int edad;
            string sexo;
            Console.WriteLine("Calculo de Pulsaciones!!!");
            Console.WriteLine("Digite la Identificación");
            identificacion = Console.ReadLine();
            Console.WriteLine("Digite la Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la Edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Sexo");
            sexo = Console.ReadLine();

            Persona persona = new Persona(identificacion, nombre, edad, sexo);
            persona.CalcularPulsacion();
            PersonaService personaService = new PersonaService();
            string mensaje=personaService.Guardar(persona);
            Console.WriteLine(mensaje);
            Console.WriteLine($"Señor(a) {persona.Nombre} de acuerdo a su edad {persona.Edad} y su sexo {persona.Sexo} su pulsacióne es {persona.Pulsacion}");
        }
    }
}
