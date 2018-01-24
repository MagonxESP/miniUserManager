using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace AgoraUsuarios
{
    public class Usuario
    {
        public int Id;
        public string Nombre;
        public string Password;
        private SqlConnection Conexion;

        public Usuario() { }

        public Usuario(int id, string nombre, string password)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Password = password;
        }
        
        public void Prepare(string ConnectionString)
        {
            this.Conexion = new SqlConnection();
            this.Conexion.ConnectionString = ConnectionString;
        }

        public bool Create()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = this.Conexion;
                command.CommandType = CommandType.Text;

                this.Conexion.Open();

                command.CommandText = "INSERT INTO [User] (Name, Password, ShowInPos, ProfileId, StyleText, StyleBackColor, StyleImageId, IsTrainee) " +
                    "OUTPUT INSERTED.ID " +
                    "VALUES (@nombre, @password, 1, 1, @nombre, '0xFF400040', @styleimage, 0)";

                command.Parameters.AddWithValue("@nombre", this.Nombre);
                command.Parameters.AddWithValue("@password", this.Password);

                Guid uniqueid = new Guid("00000000-0000-0000-0000-000000000000");
                command.Parameters.AddWithValue("@styleimage", uniqueid);

                this.Id = (int) command.ExecuteScalar();

                this.Conexion.Close();
                return true;
            }
            catch(SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                return false;
            }
        }

        public bool UpdateNombre(string newNombre)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = this.Conexion;
                command.CommandType = CommandType.Text;

                this.Conexion.Open();


                command.CommandText = "UPDATE [User] SET Name = @nombre, StyleText = @nombre WHERE Id = @id";
                command.Parameters.AddWithValue("@nombre", newNombre);
                command.Parameters.AddWithValue("@id", this.Id);
                command.ExecuteNonQuery();

                this.Conexion.Close();

                this.Nombre = newNombre;

                return true;
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                return false;
            }
        }

        public bool UpdatePassword(string newPassword)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = this.Conexion;
                command.CommandType = CommandType.Text;

                this.Conexion.Open();


                command.CommandText = "UPDATE [User] SET Password = @password WHERE Id = @id";
                command.Parameters.AddWithValue("@password", newPassword);
                command.Parameters.AddWithValue("@id", this.Id);
                command.ExecuteNonQuery();

                this.Conexion.Close();

                this.Password = newPassword;

                return true;
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = this.Conexion;
                command.CommandType = CommandType.Text;

                this.Conexion.Open();

                command.CommandText = "DELETE FROM [User] WHERE Id = @id";
                command.Parameters.AddWithValue("@id", this.Id);
                command.ExecuteNonQuery();

                this.Conexion.Close();
                return true;
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                return false;
            }
        }

        public List<Usuario> GetUsers()
        {
            List<Usuario> users = new List<Usuario>();

            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;

                command.Connection = this.Conexion;
                command.CommandType = CommandType.Text;

                this.Conexion.Open();

                command.CommandText = "SELECT Id, Name, Password FROM [User]";
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int id = 0;
                    string nombre = "";
                    string password = "";

                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        switch(reader.GetName(i))
                        {
                            case "Id":
                                id = (int) reader[i];
                                break;
                            case "Name":
                                nombre = (string) reader[i];
                                break;
                            case "Password":
                                password = (string)reader[i];
                                break;
                        }
                    }

                    Usuario u = new Usuario(id, nombre, password);
                    users.Add(u);
                }

                this.Conexion.Close();

                return users;
            }
            catch(SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                return null;
            }
        }

        public bool TestConnection()
        {
            try
            {
                this.Conexion.Open();
                this.Conexion.Close();
                return true;
            }
            catch(SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                return false;
            }
        }
    }
}
