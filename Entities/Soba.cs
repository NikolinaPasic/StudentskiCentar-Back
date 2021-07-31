
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Soba
    {
        [Key]
        public int BrojSobe { get; set; }
        public string Kategorija { get; set; }
        public StudentskiCentar StudentskiCentar { get; set; }
        public StudentskiDom StudentskiDom { get; set; }
        public int StudentskiCentarId { get; set; }
        public int StudentskiDomId { get; set; }
        public Blok Blok { get; set; }
        public int BlokId { get; set; }
        public List<UplataStanarine> Uplate { get; set; }
        public List<Student> Studenti{ get; set; }
    }
}
