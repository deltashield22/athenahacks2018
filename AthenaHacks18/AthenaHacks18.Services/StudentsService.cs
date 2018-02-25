using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenaHacks18.Models.Domain;
using AthenaHacks18.Models.Request;
using AthenaHacks18.Data.Providers;

namespace AthenaHacks18.Services
{
    public class StudentsService : IStudentsService
    {
        readonly IDataProvider dataProvider;
        private readonly object BCr;

        public StudentsService(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        //get all
        public List<Student> GetAll()
        {
            List<Student> students = null;

            dataProvider.ExecuteCmd(
                "students_getAll",
                null,
                delegate (IDataReader reader, short resultSetIndex)
                {
                    int col = 0;

                    Student student = new Student();

                    student.Id = reader.GetInt32(col++);
                    student.FirstName = reader.GetString(col++);
                    student.LastName = reader.GetString(col++);
                    student.Grade = reader.GetInt32(col++);
                    student.Email = reader.GetString(col++);
                    student.Username = reader.GetString(col++);
                    student.DateCreated = reader.GetDateTime(col++);
                    student.DateModified = reader.GetDateTime(col++);

                    if (students == null)
                        students = new List<Student>();

                    students.Add(student);
                });

            return students;
        }

        //get by id
        public Student GetById(int id)
        {
            Student student = null;

            dataProvider.ExecuteCmd(
                "Student_getById",
                delegate (SqlParameterCollection parameter)
                {
                    parameter.AddWithValue("@id", id);
                },
                delegate (IDataReader reader, short resultSetIndex)
                {
                    int col = 0;

                    student = new Student();

                    student.Id = reader.GetInt32(col++);
                    student.FirstName = reader.GetString(col++);
                    student.LastName = reader.GetString(col++);
                    student.Grade = reader.GetInt32(col++);
                    student.Email = reader.GetString(col++);
                    student.Username = reader.GetString(col++);
                    student.DateCreated = reader.GetDateTime(col++);
                    student.DateModified = reader.GetDateTime(col++);
                });

            return student;
        }

        //insert
        public int Insert(StudentCreateRequest req)
        {
            int newId = 0;
            dataProvider.ExecuteNonQuery(
                "Student_insert",
                delegate (SqlParameterCollection parameters)
                {
                    parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    parameters.AddWithValue("@firstName", req.FirstName);
                    parameters.AddWithValue("@lastName", req.LastName);
                    parameters.AddWithValue("@grade", req.Grade);
                    parameters.AddWithValue("@email", req.Email);
                    parameters.AddWithValue("@username", req.Username);
                    //string passwordHash = BCr.BCrypt.HashPassword(req.Password);
                },
                delegate (SqlParameterCollection returnParam)
                {
                    newId = (int)returnParam["@id"].Value;
                });

            return newId;
        }

        //update
        public void Update(int id, StudentUpdateRequest req)
        {
            dataProvider.ExecuteNonQuery(
                "Student_update",
                delegate (SqlParameterCollection parameters)
                {
                    parameters.AddWithValue("@id", req.Id);
                    parameters.AddWithValue("@firstName", req.FirstName);
                    parameters.AddWithValue("@lastName", req.LastName);
                    parameters.AddWithValue("@grade", req.Grade);
                    parameters.AddWithValue("@email", req.Email);
                    parameters.AddWithValue("@username", req.Username);
                    parameters.AddWithValue("@password", req.Password);
                });
        }


        //delete
        public void Delete(int id)
        {
            dataProvider.ExecuteNonQuery(
                "Student_delete",
                delegate (SqlParameterCollection parameter)
                {
                    parameter.AddWithValue("@id", id);
                });
        }

    }
}
