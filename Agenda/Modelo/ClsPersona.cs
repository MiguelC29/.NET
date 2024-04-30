using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsPersona
    {
        //Atributos
        static List<ClsPersona> listaPersonas = new List<ClsPersona>();

        private int idPersona;
        private string nombrePersona, apellidoPersona, correoPersona;
        private long telefonoPersona;
        private ClsCiudad ciudad;

        //Constructor
        public ClsPersona() { }

        public ClsPersona(int idPersona, string nombrePersona, string apellidoPersona, string correoPersona, long telefonoPersona, ClsCiudad ciudad)
        {
            this.idPersona = idPersona;
            this.nombrePersona = nombrePersona;
            this.apellidoPersona = apellidoPersona;
            this.correoPersona = correoPersona;
            this.telefonoPersona = telefonoPersona;
            this.Ciudad = ciudad;
        }

        //Encapsulamiento get y set
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string NombrePersona { get => nombrePersona; set => nombrePersona = value; }
        public string ApellidoPersona { get => apellidoPersona; set => apellidoPersona = value; }
        public string CorreoPersona { get => correoPersona; set => correoPersona = value; }
        public long TelefonoPersona { get => telefonoPersona; set => telefonoPersona = value; }
        public ClsCiudad Ciudad { get => ciudad; set => ciudad = value; }

        //Metodos
        public void registrarPersona(ClsPersona persona)
        {
            listaPersonas.Add(persona);
        }

        public List<ClsPersona> consultarPersona()
        {
            return listaPersonas;
        }

        public void editarPersona(ClsPersona persona)
        {
            ClsPersona personaEditar = consultarId(persona.idPersona);

            if(personaEditar != null)
            {
                personaEditar.NombrePersona = persona.NombrePersona;
                personaEditar.ApellidoPersona = persona.ApellidoPersona;
                personaEditar.CorreoPersona = persona.CorreoPersona;
                personaEditar.TelefonoPersona = persona.TelefonoPersona;
                personaEditar.Ciudad = persona.Ciudad;
            }
        }

        public void eliminarPersona(int idPersona)
        {
            ClsPersona personaEliminar = consultarId(idPersona);
            listaPersonas.Remove(personaEliminar);
        }

        public ClsPersona consultarId(int idPersona)
        {
            return (from P in listaPersonas
                   where P.idPersona == idPersona
                   select P).FirstOrDefault();
        }
    }
}
