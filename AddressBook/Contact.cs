using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        //properties of the contact - the data of each contact
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string countryCode { get; set; }
        public string phoneNo { get; set; }
        public string photoAddress { get; set; }
        public string Company { get; set; }
        public string jobTitle { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        //to concatenate first name and last name to return full name
        public string Fullname
        {
            get
            {
                return firstName + " " + lastName;
            }
        }


        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

    }
}
