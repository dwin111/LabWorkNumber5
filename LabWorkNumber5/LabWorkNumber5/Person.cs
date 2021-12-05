using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkNumber5
{
    internal class Person : PhoneDirectory
    {
        public Person(string name, string adress, string phoneNumber) 
        { 
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }
        

    }
}
