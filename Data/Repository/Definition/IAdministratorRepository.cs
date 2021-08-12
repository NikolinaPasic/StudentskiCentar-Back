using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Definition
{
    public interface IAdministratorRepository : IRepository<Administrator>
    {
        ActionResult GetByUsernameAndPassword(Administrator admin);
    }
}
