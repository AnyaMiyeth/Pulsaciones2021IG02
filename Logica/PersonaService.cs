using System;
using Datos;
using Entidades;

namespace Logica
{
    public class PersonaService
    {
        public PersonaRepository PersonaRepository { get; set; }
        public PersonaService()
        {
            PersonaRepository = new PersonaRepository();
        }

        public string Guardar(Persona persona)
        {
            try
            {
                PersonaRepository.Guardar(persona);
                return "Persona Guardada Satisfactoriamente";
            }
            catch (Exception  e)
            {
                return "Error al Guardar:"+e.Message;
            }
        }
        
    }
}
