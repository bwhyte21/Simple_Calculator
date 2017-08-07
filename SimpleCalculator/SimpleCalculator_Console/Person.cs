using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_Console
{
    public class Person
    {
        private int n_age = 26;
        public int getAge()
        {
            return n_age;
        }
        public void setAge(int n_newAge)
        {
            n_age = n_newAge;
        }
    }
}
