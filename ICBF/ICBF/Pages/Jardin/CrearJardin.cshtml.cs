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
                String connectionString = "Data Source=BOGAPRCSFFSD108\\SQLEXPRESS;Initial Catalog=ICBF;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    String sqlExists = "SELECT COUNT(*) FROM jardines WHERE nombre = @nombreJardin";
                    using (SqlCommand commandCheck = new SqlCommand(sqlExists, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@nombreJardin", jardinInfo.nombre);

                        int count = (int) commandCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            errorMessage = "El Jardín '" + jardinInfo.nombre + "' ya existe. Verifique la información e intente de nuevo.";
                            return;
                        }
                    }

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
