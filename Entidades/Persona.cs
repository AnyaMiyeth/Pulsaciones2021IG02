using System;

namespace Entidades
{
    public class Persona
    {
        public Persona(string identificacion, string nombre, int edad, string sexo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        public Persona()
        {

        }
        public void CalcularPulsacion()
        {
            if (Sexo.ToUpper().Equals("F"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper().Equals("M"))
            {
               Pulsacion = (210 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }
        }
    }
}
