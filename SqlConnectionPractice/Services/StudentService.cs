using SqlConnectionPractice.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionPractice.Services
{
    internal class StudentService : IStudentService
    {
        public const string ConnectionString = "Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB502;Trusted_Connection=True;";
        public void Create(Student student)
        {
            using var sqlConnection = GetConnection(ConnectionString);

            string query = "INSERT INTO Students VALUES (@Name,@Age)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", student.Name);
            sqlCommand.Parameters.AddWithValue("@Age", student.Age);
            sqlCommand.ExecuteNonQuery();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            using SqlConnection sqlConnection = GetConnection(ConnectionString);
        

            string query = "SELECT * FROM Students";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);
                    int age = (int)reader.GetValue(2);
                    students.Add(new() { Id = id, Name = name, Age = age });

                }
                return students;
            }

            return students;

        }
        public Student GetById(int? id)
        {
            using var sqlConnection = GetConnection(ConnectionString);
            string query = "SELECT * FROM Students WHERE Id=@id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Student student = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int stuId = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);
                    int age = (int)reader.GetValue(2);
                    student = new Student() { Id = stuId, Name = name, Age = age };

                }
                return student;
            }

            return student;

        }
        public void Delete(int? id)
        {
            using var sqlConnection = GetConnection(ConnectionString);

            string query = "DELETE FROM Students WHERE Id=@id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            if (sqlCommand.ExecuteNonQuery() > 0)
                Console.WriteLine("deleted");
            else
                Console.WriteLine("something went wrong");


        }
        public void Update(int? id, Student student)
        {
            using var sqlConnection = GetConnection(ConnectionString);

            string query = "UPDATE Students SET Name=@name, Age=@age WHERE Id=@id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", student.Name);
            sqlCommand.Parameters.AddWithValue("@Age", student.Age);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            if (sqlCommand.ExecuteNonQuery() > 0)
                Console.WriteLine("updated");
            else
                Console.WriteLine("something went wrong");
        }
        public List<Student> GetAllFromView()
        {

            List<Student> students = new List<Student>();
            using var sqlConnection = GetConnection(ConnectionString);

            string query = "SELECT * FROM GetAll";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);
                    int age = (int)reader.GetValue(2);
                    students.Add(new() { Id = id, Name = name, Age = age });

                }
                return students;
            }

            return students;
        }

        public string GetNameFromView()
        {

            string connectionString = "Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB502;Trusted_Connection=True;";

            using SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string query = "SELECT * FROM GetName";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                string name = default;
                while (reader.Read())
                {
                    name = (string)reader.GetValue(0);
                }
                return name;
            }

            return null;
        }

        public int GetDataCount()
        {
            string connectionString = "Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB502;Trusted_Connection=True;";

            using SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string query = "SELECT dbo.GetCount()";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int result = (int)sqlCommand.ExecuteScalar();
            return result;
        }
        public void GetDataWithAge(int age)
        {
            using var sqlConnection = GetConnection(ConnectionString);
            string query = "GetData";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@age", age);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);

                }
            }

        }

        public SqlConnection GetConnection(string connectionStr)
        {
            var connection= new SqlConnection(connectionStr);
            connection.Open();
            return connection;
        }
    }
}
