using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UplataStanarine
    {
        [Key]
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Soba Soba { get; set; }
        [ForeignKey ("Soba")]
        public int BrojSobe { get; set; }
        public StudentskiCentar StudentskiCentar { get; set; }
        public StudentskiDom StudentskiDom { get; set; }
        public int StudentskiCentarId { get; set; }
        public int StudentskiDomId { get; set; }
        public Blok Blok { get; set; }
        public int BlokId { get; set; }

    }
}
