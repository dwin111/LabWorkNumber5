using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkNumber5
{
    internal class Organization : PhoneDirectory
    {
        private string _fax;
        private Person _contactPerson;
        public Organization(string name, string adress, string phoneNumber, string fax, Person contactPerson)
        {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            _fax = fax;
            _contactPerson = contactPerson;
        }
        public override string InformationOuntput()
        {
            return "Організація " + $"{Name} находиться за адресою {Adress} номер телефону {PhoneNumber}" 
                + "факс " + _fax + " контактна особа " + _contactPerson.Name;
        }
        public override bool CheckingForAMatch(string text)
        {
            if (base.CheckingForAMatch(text) == false)
            {
                if (text.Equals(_fax.ToLower()) || text.Equals(_contactPerson.Name.ToLower()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
    }
}
