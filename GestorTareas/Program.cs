using Microsoft.Data.SqlClient;

string connectionString = "Server=.\\SQLEXPRESS01;Database=GestorTareas;Integrated Security=True;TrustServerCertificate=True;";

bool salir = false;

while (!salir)
{
    Console.WriteLine("===GESTOR DE TAREAS===");
    Console.WriteLine("1. Agregar tarea");
    Console.WriteLine("2. Ver tareas");
    Console.WriteLine("3. Completar tarea");
    Console.WriteLine("4. Eliminar tarea");
    Console.WriteLine("5. Salir");
    Console.Write("Elegí una opción: ");
    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        Console.Write("Titulo de tarea: ");
        string titulo = Console.ReadLine();
        Console.Write("Descripcion: ");
        string descripcion = Console.ReadLine();

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "INSERT INTO Tareas (Titulo, Descripcion) VALUES (@titulo,@descripcion)";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@titulo", titulo);
        cmd.Parameters.AddWithValue("@descripcion", descripcion);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Tarea agregada correctamente.");

    }
    else if(opcion == "2"){
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "SELECT Id, Titulo, Descripcion, Completada FROM Tareas";
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine("\n--- TUS TAREAS ---");
        while(reader.Read())
        {
            string estado = (bool) reader["completada"] ? "✓" : "✗";
            Console.WriteLine(estado + " [" + reader["Id"] + "] " + reader["Titulo"] + "-" + reader["Descripcion"]);
        }
        Console.WriteLine("---------------");
    }
    else if (opcion == "3")
    {
        Console.Write("Ingrese el ID de la tarea a completar: ");
        int id = int.Parse(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "UPDATE Tareas SET Completada = 1 WHERE Id = @id";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Tarea marcada como completada.");
    }
    else if(opcion == "4")
    {
        Console.Write("Ingresa el ID de la tarea a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "DELETE FROM Tareas WHERE Id = @id";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Tarea eliminada correctamente.");
        
    }
    else if (opcion == "5")
    {
        salir = true;
    }
}