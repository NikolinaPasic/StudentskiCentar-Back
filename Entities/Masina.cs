using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Masina
    {
        public int MasinaId { get; set; }
        public string Kapacitet { get; set; }
        public StudentskiCentar StudentskiCentar { get; set; }

        public int StudentskiCentarId { get; set; }

        public StudentskiDom StudentskiDom{ get; set; }
        public int StudentskiDomId { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }

    }
}
