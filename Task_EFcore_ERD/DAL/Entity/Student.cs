using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_EFcore_ERD.DAL.Entity
{
    public class Student:important_feld
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }


        public List<Course> courses { get; set; }



        /*[ForeignKey("departments")]
        public int IDdep { get; set; }*/
        public List<Department> departments { get; set; }


    }
}
