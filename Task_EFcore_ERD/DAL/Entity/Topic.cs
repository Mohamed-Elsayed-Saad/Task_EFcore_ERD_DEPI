using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task_EFcore_ERD.DAL.Entity
{
   // [PrimaryKey("TID")]
    public class Topic
    {
        [Key]
        public int TID { get; set; }
        public string TName { get; set; }
    }
}
