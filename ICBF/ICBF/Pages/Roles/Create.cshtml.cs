using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static ICBF.Pages.Roles.IndexModel;

namespace ICBF.Pages.Roles
{
    public class CreateModel : PageModel
    {

        public RolInfo rolInfo = new RolInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            rolInfo.nombre = Request.Form["nombre"];

            if (rolInfo.nombre.Length == 0)
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

                    String sqlExists = "SELECT COUNT(*) FROM roles WHERE nombre = @nombre";
                    using (SqlCommand commandCheck = new SqlCommand(sqlExists, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@nombre", rolInfo.nombre);

                        int count = (int)commandCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            errorMessage = "El Rol '" + rolInfo.nombre + "' ya existe. Verifique la información e intente de nuevo.";
                            return;
                        }
                    }

                    // Espacio para validar que el rol no exista
                    String sqlInsert = "INSERT INTO Roles (nombre)" +
                        "VALUES (@nombre);";

                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", rolInfo.nombre);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            rolInfo.nombre = "";

            successMessage = "Rol agregado con exito";
            Response.Redirect("/Roles/Index");
        }
    }
}