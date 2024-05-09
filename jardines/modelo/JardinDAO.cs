using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jardines.modelo
{
    public class JardinDAO
    {

        ORMDataContext BD = new ORMDataContext();
        
        public void registrar(Jardines jardin)
        {
            BD.Jardines.InsertOnSubmit(jardin);
            BD.SubmitChanges(); // GUARDAR LOS CAMBIOS
        }

        public Object consultarTodos()
        {
            return from J in BD.Jardines select J;
        }
    }
}