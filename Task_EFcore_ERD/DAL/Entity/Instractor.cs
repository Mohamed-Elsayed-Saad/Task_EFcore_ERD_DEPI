using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_EFcore_ERD.DAL.Entity
{
    public class Instractor:important_feld
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Bonus { get; set; }
        public decimal Salray { get; set; }
        public double Hour_Rate { get; set; }
        public string Address { get; set; }


        public List<Course> courses { get; set; }

        /*[ForeignKey("departments")]
        public int IDdep { get; set; }*/
        public List<Department> departments { get; set; }
    }
}
