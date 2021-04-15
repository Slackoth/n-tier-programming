using System;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DPerson
    {
        // Gets all records
        public DataTable List()
        {
            SqlDataReader response;
            DataTable table = new();
            SqlConnection connection = new();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("list_person", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                response = command.ExecuteReader();
                
                table.Load(response);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Inserts one record
        public string Insert(Person person)
        {
            string response = "";
            SqlConnection connection = new();
            
            // Parameters for SQL procedure 
            SqlParameter[] parameters =
            {
                new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = person.Name,
                    SqlDbType = SqlDbType.VarChar
                },
                new SqlParameter()
                {
                    ParameterName = "@lastname",
                    Value = person.Lastname,
                    SqlDbType = SqlDbType.VarChar
                },
                new SqlParameter()
                {
                    ParameterName = "@age",
                    Value = person.Age,
                    SqlDbType = SqlDbType.Int
                },
                new SqlParameter()
                {
                    ParameterName = "@phone",
                    Value = person.Phone,
                    SqlDbType = SqlDbType.VarChar
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("insert_person", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(parameters);
                connection.Open();

                response = command.ExecuteNonQuery() == 1 ? "Person inserted" : "Person not inserted";
            }
            catch (Exception e)
            {
                response = "Exception: " + e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return response;
        }
    }
}
