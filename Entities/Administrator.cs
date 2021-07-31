using System;
using System.Collections.Generic;

namespace Entities
{
    public class Administrator
    {
        public int AdministratorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DatumZaposlenja { get; set; }

        public StudentskiCentar StudentskiCentar { get; set; }
        public int StudentskiCentarId { get; set; }

        public List<Uplata> Uplate_admin { get; set; }

    }
}
