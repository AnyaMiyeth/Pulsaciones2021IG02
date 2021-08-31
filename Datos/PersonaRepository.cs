using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class PersonaRepository
    {
        private string ruta = @"Persona.txt";

        public void Guardar(Persona persona)
        {
            StreamWriter escritor = new StreamWriter(ruta,true);
            escritor.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsacion}");
            escritor.Close();
        }
        public List<Persona> Consultar()
        {
           List<Persona> personas = new List<Persona>();
           StreamReader lector = new StreamReader(ruta);
           var linea = "";
           while ((linea=lector.ReadLine())!=null)
            {
                string [] dato=linea.Split(';');
                Persona persona = new Persona() {
                    Identificacion = dato[0],
                    Nombre = dato[1],
                    Edad =int.Parse( dato[2]),
                    Sexo = dato[3]
                };
                personas.Add(persona);
            }
            lector.Close();
            return personas;
        }

        public void Eliminar(string id)
        {
            List<Persona> personas = new List<Persona>();
            personas = Consultar();

            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            
            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(id))
                {
                    Guardar(item);
                }
            }
        }

        public void Modificar(string id, Persona PersonaNew)
        {
            List<Persona> personas = new List<Persona>();
            personas = Consultar();

            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(id))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(PersonaNew);
                }
            }
        }
    }
}
