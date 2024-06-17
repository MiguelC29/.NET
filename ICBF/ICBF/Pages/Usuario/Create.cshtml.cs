using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static ICBF.Pages.Roles.IndexModel;
using static ICBF.Pages.TipoDocumento.IndexModel;
using static ICBF.Pages.Usuario.IndexModel;

namespace ICBF.Pages.Usuario
{
    public class CreateModel : PageModel
    {
        public List<RolInfo> rolInfo { get; set; } = new List<RolInfo>();
        public UsuarioInfo usuarioInfo = new UsuarioInfo();
        public DatosBasicosInfo datosBasicos = new DatosBasicosInfo();
        public List<TipoDocInfo> tipoDocInfo { get; set; } = new List<TipoDocInfo>();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            try
            {
                //String connectionString = "Data Source=BOGAPRCSFFSD108\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True";
                String connectionString = "Data Source=PC-MIGUEL-C\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sqlRoles = "SELECT * from roles";
                    using (SqlCommand command = new SqlCommand(sqlRoles, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Verificar si hay filas en el resultado antes de intentar leer
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var id = reader.GetInt32(0).ToString();
                                    var nombreRol = reader.GetString(1);

                                    rolInfo.Add(new RolInfo
                                    {
                                        idRol = reader.GetInt32(0).ToString(),
                                        nombre = reader.GetString(1)
                                    });

                                    foreach (var rol in rolInfo)
                                    {
                                        Console.WriteLine("List item - id: {0}, nombreRol: {1}", rol.idRol, rol.nombre);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay filas en el resultado.");
                                Console.WriteLine("No se encontraron datos en la tabla roles.");
                            }
                        }
                    }

                    String sqlTiposDoc = "SELECT * from tipoDocumento";
                    using (SqlCommand command = new SqlCommand(sqlTiposDoc, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Verificar si hay filas en el resultado antes de intentar leer
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var idDoc = reader.GetInt32(0).ToString();
                                    var tipoDoc = reader.GetString(1);

                                    tipoDocInfo.Add(new TipoDocInfo
                                    {
                                        idTipoDoc = reader.GetInt32(0).ToString(),
                                        tipo = reader.GetString(1)
                                    });

                                    foreach (var tipoDocu in tipoDocInfo)
                                    {
                                        Console.WriteLine("List item - id: {0}, tipo: {1}", tipoDocu.idTipoDoc, tipoDocu.tipo);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay filas en el resultado.");
                                Console.WriteLine("No se encontraron datos en la tabla tipoDocumento.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }

        public void OnPost()
        {
            string identificacion = Request.Form["identificacion"];
            string nombres = Request.Form["nombres"];
            string fechaNacimiento = Request.Form["fechaNacimiento"];
            string celular = Request.Form["celular"];
            string direccion = Request.Form["direccion"];
            string tipoDocIdString = Request.Form["tipoDocumento"];
            string rolIdString = Request.Form["rol"];
            int rolId;
            int tipoDocId;

            if (string.IsNullOrEmpty(identificacion) || string.IsNullOrEmpty(nombres)
                || string.IsNullOrEmpty(fechaNacimiento) || string.IsNullOrEmpty(celular)
                || string.IsNullOrEmpty(direccion))
            {
                errorMessage = "Todos los campos son obligatorios";
                return;
            }

            if (!int.TryParse(rolIdString, out rolId))
            {
                errorMessage = "Rol inválido seleccionado";
                return;
            }

            if (!int.TryParse(tipoDocIdString, out tipoDocId))
            {
                errorMessage = "Tipo Documento inválido seleccionado";
                return;
            }

            try
            {
                //String connectionString = "Data Source=BOGAPRCSFFSD108\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True";
                String connectionString = "Data Source=PC-MIGUEL-C\\SQLEXPRESS;Initial Catalog=db_ICBF;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    String sqlExists = "SELECT COUNT(*) FROM usuarios as u " +
                        "INNER JOIN DatosBasicos as d ON u.idDatosBasicos = d.idDatosBasicos " +
                        "WHERE d.identificacion = @identificacion;";
                    using (SqlCommand commandCheck = new SqlCommand(sqlExists, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@identificacion", identificacion);

                        int count = (int) commandCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            errorMessage = "El usuario " + usuarioInfo.nombreUsuario + " con identificación " + usuarioInfo.datosBasicos.identificacion + " ya existe. " +
                                           "Verifique la información e intente de nuevo";
                            return;
                        }
                    }

                    String sqlInsert = "INSERT INTO DatosBasicos" +
                        "(identificacion, nombres, fechaNacimiento, celular, direccion, idTipoDocumento)" +
                        "VALUES" +
                        "(@identificacion, @nombres, @fechaNacimiento, @celular, @direccion, @tipoDocumento)";

                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        command.Parameters.AddWithValue("@identificacion", identificacion);
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@celular", celular);
                        command.Parameters.AddWithValue("@direccion", direccion);
                        command.Parameters.AddWithValue("@tipoDocumento", tipoDocId);
                        //command.Parameters.AddWithValue("@rolId", rolId);

                        command.ExecuteNonQuery();
                    }

                    String sqlSelectDatosBasicos = "SELECT TOP 1 idDatosBasicos FROM DatosBasicos ORDER BY idDatosBasicos DESC";

                    using (SqlCommand command2 = new SqlCommand(sqlSelectDatosBasicos, connection))
                    {
                        using (SqlDataReader reader = command2.ExecuteReader())
                        {
                            // Validar si hay datos
                            if (reader.Read())
                            {
                                datosBasicos.idDatosBasicos = reader.GetInt32(0).ToString();
                            }
                        }
                    }
                    
                    String sqlInsertUsuario = "INSERT INTO usuarios (idDatosBasicos, idRol)" +
                            "VALUES (@datosBasicos, @rol);";

                    using (SqlCommand command2 = new SqlCommand(sqlInsertUsuario, connection))
                    {
                        command2.Parameters.AddWithValue("@datosBasicos", datosBasicos.idDatosBasicos);
                        command2.Parameters.AddWithValue("@rol", rolId);

                        command2.ExecuteNonQuery();
                    }
                }
                successMessage = "Usuario creado exitosamente";
                //Response.Redirect("/Persona/Index");
                RedirectToPage("/Usuario/Index");
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }
    }
}
