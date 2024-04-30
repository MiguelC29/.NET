using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsCiudad
    {
        static List<ClsCiudad> listaCiudades = new List<ClsCiudad>
        {
            new ClsCiudad(1, "Bogotá"),
            new ClsCiudad(2, "Cali"),
            new ClsCiudad(3, "Medellin"),
            new ClsCiudad(4, "Barranquilla")
        };

        //Atributos
        private int idCiudad;
        private string nombreCiudad;

        //Constructor
        public ClsCiudad() {}
        public ClsCiudad(int idCiudad, string nombreCiudad)
        {
            this.idCiudad = idCiudad;
            this.nombreCiudad = nombreCiudad;
        }

        //Encapsulamiento get y set
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }

        
        //Metodos
        public List<ClsCiudad> consultarCiudades()
        {
            return listaCiudades;
        }

    }
}
