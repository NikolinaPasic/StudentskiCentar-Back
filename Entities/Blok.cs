using System;
using System.Collections.Generic;

namespace Entities
{
    public class Blok
    {
        public int BlokId { get; set; }
        public string Naziv { get; set; }

        public StudentskiCentar StudentskiCentar { get; set; }
        public StudentskiDom StudentskiDom { get; set; }
        public int StudentskiCentarId { get; set; }
        public int StudentskiDomId { get; set; }
        public List<Soba> Sobe { get; set; }
        public List<Student> Studenti { get; set; }



    }
}
