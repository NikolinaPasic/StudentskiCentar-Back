using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string BrojIndeksa { get; set; }
        public string PozivNaBroj { get; set; }
        public int BrojDorucaka { get; set; }
        public int BrojRucaka { get; set; }
        public int BrojVecera { get; set; }
        public string Finansiranje { get; set; }
        public double StanjeNaRacunu { get; set; }
        public Soba Soba { get; set; }
        [ForeignKey("Soba")]
        public int BrojSobe { get; set; }
        public StudentskiCentar StudentskiCentar { get; set; }
        public StudentskiDom StudentskiDom { get; set; }
      
        public int StudentskiCentarId { get; set; }
       
        public int StudentskiDomId { get; set; }
        public Blok Blok { get; set; }
       
        public int BlokId { get; set; }
        public List<UplataStanarine> Uplate { get; set; }
        public List<Uplata> Uplate_admin { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }

    }
}
