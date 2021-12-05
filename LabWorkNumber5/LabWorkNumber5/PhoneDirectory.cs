using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkNumber5
{
    internal abstract class PhoneDirectory
    {
        public string Name { get; set; }
        public string Adress { get; set;}
        public string PhoneNumber { get; set;}

        public virtual string InformationOuntput()
        {
            return $"{Name} живе по адресі {Adress} номер телефону {PhoneNumber}";
        }

        public virtual bool CheckingForAMatch(string text)
        {
            bool answer;
            if (text.Equals(Name.ToLower()) || text.Equals(Adress.ToLower()) || text.Equals(PhoneNumber.ToLower()))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

    }
}
