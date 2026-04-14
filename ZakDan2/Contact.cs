using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakDan2
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private DateTime birthDate;
        private string category;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Email { get { return email; } set { email = value; } }    
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public string Category { get { return category; } set { category = value; } }

        public override string ToString()
        {
            return $"{lastName} {firstName} - {phoneNumber}";
        }

        public Contact()
        {
            BirthDate = DateTime.Now.AddYears(-30);
            Category = "Знакомые";
        }
       
    }
}
