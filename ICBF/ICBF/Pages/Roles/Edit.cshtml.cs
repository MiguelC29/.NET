using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static ICBF.Pages.Roles.IndexModel;

namespace ICBF.Pages.Roles
{
    public class EditModel : PageModel
    {

        public RolInfo rolInfo = new RolInfo();
        public string errorMessage = "";
        public string successMessage = "";

        //String connectionString = "Data Source=BOGAPRCSFFSD108\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True";
        String connectionString = "Data Source=PC-MIGUEL-C\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True;";

        public void OnGet()
        {
            String idRol = Request.Query["idRol"];

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Roles WHERE idRol = @idRol";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idRol", idRol);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rolInfo.idRol = "" + reader.GetInt32(0);
                                rolInfo.nombre = reader.GetString(1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
        }

        public void OnPost()
        {
            rolInfo.idRol = Request.Form["idRol"];
            rolInfo.nombre = Request.Form["nombre"];

            if (rolInfo.idRol.Length == 0 || rolInfo.nombre.Length == 0)
            {
                errorMessage = "Debe completar todos los campos";
                return;
            }

            try
            {
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
                            errorMessage = "El Rol '" + rolInfo.nombre + "' ya existe. Verifique la informaci�n e intente de nuevo.";
                            return;
                        }
                    }

                    // Espacio para validar que el rol no exista
                    String sqlUpdate = "UPDATE Roles SET nombre = @nombre WHERE idRol = @idRol";
                    using (SqlCommand command = new SqlCommand(sqlUpdate, connection))
                    {
                        command.Parameters.AddWithValue("@idRol", rolInfo.idRol);
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

            Response.Redirect("/Roles/Index");
        }
    }
}