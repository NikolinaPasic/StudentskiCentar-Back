using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rezervacija
    {
        [Key]
        public DateTime Termin { get; set; }
        public Student Student{ get; set; }
        public int StudentId { get; set; }
        public Masina Masina { get; set; }
        public int MasinaId { get; set; }
    }
}
