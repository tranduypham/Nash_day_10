using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_10.Models;

namespace Day_10.Services
{
    public interface IStudent
    {
        public List<Student> GetAll();
        public void Create (Student student);
        public void Update (Student student);
        public void Delete (int id);
    }
}