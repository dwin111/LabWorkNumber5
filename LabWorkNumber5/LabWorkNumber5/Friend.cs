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
            return "Друг "+ $"{Name} живе за адресою {Adress} номер телефону {PhoneNumber}" 
                + " дата народження " + _birthday;
        }
        public override bool CheckingForAMatch(string text)
        {
            if (base.CheckingForAMatch(text) == false)
            {
                if (text.Equals(_birthday.ToLower()))
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
