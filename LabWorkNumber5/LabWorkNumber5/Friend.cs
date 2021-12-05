using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkNumber5
{
    internal class Friend : PhoneDirectory
    {
        private string _birthday;
        public Friend(string name, string adress, string phoneNumber, string birthday)
        {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            _birthday = birthday;
        }
        public override string InformationOuntput()
        {
            return "Друг "+ base.InformationOuntput() + " адреса проживання " + _birthday;
        }
    }
}
