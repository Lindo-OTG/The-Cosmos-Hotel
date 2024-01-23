using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCosmosHotel
{
    class Customer
    {
        private int customerID;
        private string firstname;
        private string lastname;
        private string gender;
        private string dateOfBirth;
        private string nationality;
        private string phonenumber;
        private string email;
        private string creditrating;
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return phonenumber;
            }

            set
            {
                phonenumber = value;
            }
        }

        public string Creditrating
        {
            get
            {
                return creditrating;
            }

            set
            {
                creditrating = value;
            }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public Customer()
        {

        }

        public Customer(int customerID, string firstname, string lastname, string gender, string dateOfBirth, string nationality, string phonenumber, string email, string creditrating)
        {
            this.customerID = customerID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.nationality = nationality;
            this.phonenumber = phonenumber;
            this.email = email;
            this.creditrating = creditrating;
        }
        public Customer(string firstname, string lastname, string gender, string dateOfBirth, string nationality, string phonenumber, string email, string creditrating)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.nationality = nationality;
            this.phonenumber = phonenumber;
            this.email = email;
            this.creditrating = creditrating;
        }
    }
}
