using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Day_10.Models;
using Day_10.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day_10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController
    {
        private IStudent _studentServices;
        public StudentController(IStudent studentServices)
        {
            _studentServices = studentServices;
        }
        [HttpGet]
        public List<Student> GetAll(){
            return _studentServices.GetAll();
        }

        [HttpPost]
        public HttpStatusCode Create(Student student){
            _studentServices.Create(student);
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Update(Student student){
            _studentServices.Update(student);
            return HttpStatusCode.OK;
        }
        [HttpDelete]
        public HttpStatusCode Delete(int id){
            _studentServices.Delete(id);
            return HttpStatusCode.OK;
        }
    }
}