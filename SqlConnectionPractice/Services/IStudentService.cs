using SqlConnectionPractice.Models;
using System.Data.SqlClient;

namespace SqlConnectionPractice.Services
{
    internal interface IStudentService
    {
        void Create(Student student);
        void Delete(int? id);
        List<Student> GetAll();
        List<Student> GetAllFromView();
        Student GetById(int? id);
        int GetDataCount();
        void GetDataWithAge(int age);
        string GetNameFromView();
        void Update(int? id, Student student);
        SqlConnection  GetConnection(string connectionStr);
    }
}