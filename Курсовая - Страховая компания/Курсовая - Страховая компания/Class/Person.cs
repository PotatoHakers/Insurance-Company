using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Class
{
    public class Person
    {
        //Класс, который наследуют работаники, физические и юридические лица
        public string Name { get; set; }
        
        public Person(string name)
        {
            Name = name;
            
        }
    }
}
