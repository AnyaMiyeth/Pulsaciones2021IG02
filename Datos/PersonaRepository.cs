using Entidades;
using System;
using System.IO;

namespace Datos
{
    public class PersonaRepository
    {
        private string ruta = "Persona.txt";

        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta,FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsacion}");
            escritor.Close();
            file.Close();
        }
        public void Consultar()
        {

        }
    }
}
