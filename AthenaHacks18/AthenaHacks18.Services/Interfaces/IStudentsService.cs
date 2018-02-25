using System.Collections.Generic;
using AthenaHacks18.Models.Domain;
using AthenaHacks18.Models.Request;

namespace AthenaHacks18.Services
{
    public interface IStudentsService
    {
        void Delete(int id);
        List<Student> GetAll();
        Student GetById(int id);
        int Insert(StudentCreateRequest req);
        void Update(int id, StudentUpdateRequest req);
    }
}