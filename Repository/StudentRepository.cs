using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_10.Models;

namespace Day_10.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDbContext _studentDbContext;
        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public List<Student> GetAll(){
            return _studentDbContext.Students.ToList();
        }
        public void Create(Student student){
            _studentDbContext.Students.Add(student);
            _studentDbContext.SaveChanges();
        }

        public void Update(Student student){
            var updateStudent = _studentDbContext.Students.Find(student.StudentId);
            if(updateStudent != null) {
                updateStudent.City = student.City;
                updateStudent.State = student.State;
                updateStudent.FirstName = student.FirstName;
                updateStudent.LastName = student.LastName;

                _studentDbContext.SaveChanges();
            }
        }

        public void Delete(int id){
            var deleteStudent = _studentDbContext.Students.Find(id);
            if(deleteStudent != null){
                _studentDbContext.Remove(deleteStudent);
                _studentDbContext.SaveChanges();
            }
        }
    }
}