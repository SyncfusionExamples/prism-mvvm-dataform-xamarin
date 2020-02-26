using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormViewModel
    {
        private ContactsInfo contactsInfo;
        public ContactsInfo ContactsInfo
        {
            get { return this.contactsInfo; }
            set { this.contactsInfo = value; }
        }
        public DataFormViewModel()
        {
            this.contactsInfo = new ContactsInfo();
        }
    }
}
