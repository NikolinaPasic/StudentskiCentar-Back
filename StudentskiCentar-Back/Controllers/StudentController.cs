using Data.Repository.Definition;
using Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentskiCentar_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiCentar_Back.Controllers
{
    

    public class StudentController : ControllerBase
    {
        private  IUnitOfWork _unitOfWork;
        

        public StudentController(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }
        

        [HttpGet]
        [Route("/students")]
        public async Task<List<Student>> GetStudents()
        {
            return await _unitOfWork.Student.GetAllAsync();
        }
        [HttpGet]
        [Route("/student/{id}")]
        public async Task<Student> GetStudentById(int id)
        {
            return await _unitOfWork.Student.GetStudent(id);
        }

        [HttpPost]
        [Route("/login")]
        public async Task<ActionResult<Student>> Login([FromBody] StudentLoginModel student)
        
        {

                Student s = new Student { Password = student.Password, Username = student.Username };
                var student1= await _unitOfWork.Student.GetByUsernameAndPassword(s);
                if (student1 != null) return Ok(student1);
                return NotFound("Neuspesna prijava");

        }

        [HttpPatch]
        [Route("password-change")]
        public ActionResult ChangePassword([FromBody] Student student)
        {
            try
            {
                _unitOfWork.Student.ChangePassword(student);
                return Ok("Lozinka je uspesno promenjena.");
            }
            catch (Exception)
            {
                return NotFound("Doslo je do greske!");
                throw;
            }
        }
        [HttpPatch]
        [Route("buy")]
        public async Task<ActionResult> BuyMeals([FromBody]Student student)
        {
            try
            {
                var student1 = await _unitOfWork.Student.BuyMeals(student);
                return Ok(student1);
            }
            catch (Exception)
            {
                return NotFound("Doslo je do greske!");
                throw;
            }
        }


    }
}
