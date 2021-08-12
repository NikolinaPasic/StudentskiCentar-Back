using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentskiCentar
    {
        public int StudentskiCentarId { get; set; }
        public string Naziv { get; set; }

        public List<StudentskiDom> Domovi { get; set; }
      

        public List<Administrator> Administratori { get; set; }

        public List<Student> Studenti { get; set; }

    }
}
