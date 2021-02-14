using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetMVC.Models
{
    public class ViewModel
    {
        public List<Account> accounts { get; set; }
        public List<Employee> employees { get; set; }
        public List<Division> divisions { get; set; }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
    }
}