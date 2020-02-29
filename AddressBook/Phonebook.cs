using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Phonebook
    {
        //phonebook class to provide functionality to our view using Contact class
        private List<Contact> cList = new List<Contact>();
        public List<Contact> searchList = new List<Contact>();

        //add a new contact to the addressbook
        public void addContact(Contact contact)
        {
            cList.Add(contact);
        }

        //get all data of the contacts list
        public List<Contact> getAll()
        {
            return this.cList;
        }

        //search for a particular contacts in the list and add them to seperate list and return the list
        public List<Contact> getSearchList(string Name)
        {
            searchList = new List<Contact>();
            foreach (var item in cList)
            {
                if (item.firstName.StartsWith(Name, StringComparison.OrdinalIgnoreCase))
                    searchList.Add(item);
            }
            return searchList;
        }

        //delete contact from the list
        public void deleteContact(Contact contact)
        {
            cList.Remove(contact);
        }

        //get single contact based on index value
        public Contact getContact(int index)
        {
            return cList[index];
        }

        //class indexer to use index with class object directly
        public Contact this[int index]
        {
            get
            {
                return this.cList[index];
            }
            set
            {
                this.cList[index] = value;
            }
        }

        //string indexer to find if the contact exists of the same first name as the argument string
        public Contact this[string Name]
        {
            get
            {
                foreach (var item in cList)
                {
                    if (item.firstName.StartsWith(Name))
                        return item;
                }
                return null;
            }
            set
            {
                foreach (var item in cList)
                {
                    if (item.firstName.StartsWith(Name))
                        item.firstName = Name;
                }
            }
            // TODO: Write set part of indexer. It searches for name and replaces contact
        }

        //public Contact this[string Number, ContactType contactType]
        //{
        //    get
        //    {
        //        return this.cList.Find(x => x.Number.StartsWith(Number));
        //    }
        //    //TODO: Convert this indexer as generic indexer which works with Name and Number
        //    // Based on user selection of ContactType
        //}
    }
}
