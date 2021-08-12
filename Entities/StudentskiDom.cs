using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentskiDom
    {
        public int StudentskiDomId { get; set; }
        public string Naziv { get; set; }

        public StudentskiCentar StudentskiCentar { get; set; }
        public int StudentskiCentarId { get; set; }

        public List<Blok> Blokovi { get; set; }
        
        public List<Masina> Masine { get; set; }

        public List<Student> Studenti { get; set; }


    }
}
