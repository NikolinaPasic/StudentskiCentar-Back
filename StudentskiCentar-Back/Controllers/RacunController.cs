using Data.Repository.Definition;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiCentar_Back.Controllers
{

    public class RacunController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public RacunController(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpPatch]
        [Route("transfer-money")]
        public ActionResult TransferMoney([FromBody] Student student, double iznos)
        {
            try
            {
                _unitOfWork.Student.TransferMoney(student, iznos);
                return Ok("Uspesno izvrsena transakcija.");
            }
            catch (Exception)
            {
                return NotFound("Doslo je do greske!");
                throw;
            }
        }
    }
}
