using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_EFcore_ERD.DAL.Entity
{
    public class Course:important_feld
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string? Descrption { get; set; }

        public  double Duration { get; set; }// مده الكورس 

        /*[ForeignKey("topics")]
        public int IDtop { get; set; }
        */
        public List<Topic> topics { get; set; }


        // mine to mine 
        public List<Instractor> inners { get; set; }

        public List<Student> students { get; set; }
    }
}
