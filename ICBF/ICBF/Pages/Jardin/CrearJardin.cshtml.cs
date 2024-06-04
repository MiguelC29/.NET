using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static ICBF.Pages.Jardin.IndexModel;

namespace ICBF.Pages.Jardin
{
    public class CrearJardinModel : PageModel
    {

        public JardinInfo jardinInfo = new JardinInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            jardinInfo.nombre = Request.Form["nombreJardin"];
            jardinInfo.direccion = Request.Form["direccionJardin"];
            jardinInfo.estado = Request.Form["estado"];

            if (jardinInfo.nombre.Length == 0 || jardinInfo.direccion.Length == 0 || jardinInfo.estado.Length == 0)
            {
                errorMessage = "Debe completar todos los campos";
                return;
            }

            try
            {
                String connectionString = "Data Source=BOGAPRCSFFSD108\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Espacio para validar que el jadin no exista
                    String sqlInsert = "INSERT INTO jardines (nombre, direccion, estado)" +
                        "VALUES (@nombreJardin, @direccionJardin, @estado);";

                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        command.Parameters.AddWithValue("@nombreJardin", jardinInfo.nombre);
                        command.Parameters.AddWithValue("@direccionJardin", jardinInfo.direccion);
                        command.Parameters.AddWithValue("@estado", jardinInfo.estado);

                        command.ExecuteNonQuery();
                    }

                }
            } catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            jardinInfo.nombre = "";
            jardinInfo.direccion = "";
            jardinInfo.estado = "";

            successMessage = "Jardín agregado con éxito";
            Response.Redirect("/Jardin/Index");
        }
    }
}
