using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryForm
{
    #region ViewModel
    #endregion
    class PersonalInformation : ViewModelBase
    {
        private string name, emailAddress, phoneNumber;
        int age;
        bool isProgrammer;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { SetProperty(ref emailAddress, value); }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetProperty(ref phoneNumber, value); }
        }

        public int Age
        {
            get { return age; }
            set { SetProperty(ref age, value); }
        }
        public bool IsProgrammer { get { return isProgrammer; } set { SetProperty(ref isProgrammer, value); } }
    }
}
