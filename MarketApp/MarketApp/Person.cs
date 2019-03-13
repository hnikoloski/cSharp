using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        private string SSN { get; set; }
        public bool isLoyal { get; set; }

        public void setSSN(string social)
        {
            SSN = social;
        }

    }
}
