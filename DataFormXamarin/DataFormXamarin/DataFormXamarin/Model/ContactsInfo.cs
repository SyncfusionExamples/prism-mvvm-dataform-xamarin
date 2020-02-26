using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class ContactsInfo : INotifyPropertyChanged
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string contactNo;
        private string email;
        private string address;
        private DateTime? birthDate;
        private string groupName;

        public ContactsInfo()
        {

        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
                this.RaiseOnPropertyChanged("FirstName");
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                this.middleName = value;
                this.RaiseOnPropertyChanged("MiddleName");
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
                this.RaiseOnPropertyChanged("LastName");
            }
        }

        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
                this.RaiseOnPropertyChanged("ContactNumber");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.RaiseOnPropertyChanged("Email");
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                this.RaiseOnPropertyChanged("Address");
            }
        }

        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                this.RaiseOnPropertyChanged("BirthDate");
            }
        }

        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
                this.RaiseOnPropertyChanged("GroupName");
            }
        }


        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke method when property changed.
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
