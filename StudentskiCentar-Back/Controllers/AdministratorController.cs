using Data.Repository.Definition;
using Entities;
using Microsoft.AspNetCore.Mvc;
using StudentskiCentar_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiCentar_Back.Controllers
{
    
    public class AdministratorController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
     
        public AdministratorController(IUnitOfWork uow)
        {
            this._unitOfWork = uow;
        }

        [HttpPost]
        [Route("/admin-login")]
        public ActionResult Login([FromBody] AdministratorLoginModel admin)
        {
            Console.WriteLine(admin.Username);
            try
            {
                Administrator a = new Administrator { Password = admin.Password, Username = admin.Username };
               return Ok( _unitOfWork.Administrator.GetByUsernameAndPassword(a));
                

            }
            catch (Exception e)
            {
                return NotFound("Nalog nije pronadjen.");
                throw;
            }
        }
    }
}
