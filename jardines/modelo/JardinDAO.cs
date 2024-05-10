using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jardines.modelo
{
    public class JardinDAO
    {

        static string connectionString = "Data Source=PC-MIGUEL-C\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        ORMDataContext BD = new ORMDataContext(connectionString);

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