using System;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace Data
{
    public class DCategory
    {
        public DataTable List()
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("list_category", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                result = command.ExecuteReader();

                table.Load(result);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                if(connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable Search(string value)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("search_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@value", SqlDbType.VarChar).Value = value;

                connection.Open();

                result = command.ExecuteReader();

                table.Load(result);
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

        public string Insert(Category obj)
        {
            string response = "";
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters = {
                new SqlParameter("@name", SqlDbType.VarChar) {
                    Value = obj.Name
                },
                new SqlParameter("@description", SqlDbType.VarChar) {
                    Value = obj.Description
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("insert_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);

                connection.Open();

                response = command.ExecuteNonQuery() == 1 ? "Record inserted" : "Record not inserted.";
            }
            catch (Exception e)
            {
                response = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return response;
        }

        public string Update(Category obj)
        {
            string response = "";
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters = {
                new SqlParameter("@id", SqlDbType.Int) {
                    Value = obj.CategoryId
                },
                new SqlParameter("@name", SqlDbType.VarChar) {
                    Value = obj.Name
                },
                new SqlParameter("@description", SqlDbType.VarChar) {
                    Value = obj.Description
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("update_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);

                connection.Open();

                response = command.ExecuteNonQuery() == 1 ? "Record updated" : "Record not updated.";
            }
            catch (Exception e)
            {
                response = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return response;
        }

        public string Delete(int id)
        {
            string response = "";
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("delete_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.Open();

                response = command.ExecuteNonQuery() == 1 ? "Record deleted" : "Record not deleted.";
            }
            catch (Exception e)
            {
                response = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return response;
        }

        public string Activate(int id)
        {
            string response = "";
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("activate_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.Open();

                response = command.ExecuteNonQuery() == 1 ? "Record activated" : "Record not activated.";
            }
            catch (Exception e)
            {
                response = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return response;
        }

        public string Deactivate(int id)
        {
            string response = "";
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("deactivate_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.Open();

                response = command.ExecuteNonQuery() == 1 ? "Record deactivated" : "Record not deactivated.";
            }
            catch (Exception e)
            {
                response = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return response;
        }

        public static string Exists(string value)
        {
            string response = "";
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters = {
                new SqlParameter("@name", SqlDbType.VarChar) {
                    Value = value
                },
                new SqlParameter("@exists", SqlDbType.Int) {
                    Direction = ParameterDirection.Output
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("insert_category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);

                connection.Open();
                command.ExecuteNonQuery();

                response = Convert.ToString(parameters[1].Value);
            }
            catch (Exception e)
            {
                response = e.Message;
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
