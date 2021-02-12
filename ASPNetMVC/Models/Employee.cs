﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNetMVC.Models
{ 
    [Table("Tb_M_Employee")]
    public class Employee
    {
        [Key]
        public int Id
        {
            get; set;
        }
        
        public string Name
        {
            get; set;
        }
        
        public DateTime BirthDay
        {
            get; set;
        }
        
        public string Address
        {
            get; set;
        }
        
        public string Email
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }
    }
}