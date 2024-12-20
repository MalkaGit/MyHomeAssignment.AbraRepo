using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer(int id, DateTime birthDate)
        {
            Id = id;
            BirthDate = birthDate;
        }
    }
}
