using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_10.Models;
using Day_10.Repository;

namespace Day_10.Services
{
    public class StudentServices : IStudent
    {
        private readonly IStudentRepository _studentRepository;
        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public void Create (Student student){
            _studentRepository.Create(student);
        }

        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }
        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }
    }
}