using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Uplata
    {
        public int UplataId { get; set; }
        public string SvrhaUplate { get; set; }
        public double Iznos { get; set; }
        public Administrator Administrator { get; set; }
        public int AdministratorId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }

    }
}
