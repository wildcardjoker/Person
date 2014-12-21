// Created: 2014-12-21
// Last Modified: 2014-12-21-9:39 PM

#region Using Directives

using System.ComponentModel;
using System.Runtime.CompilerServices;
using Person.Annotations;

#endregion

namespace Person
{
    public class Person : INotifyPropertyChanged
    {
        #region Fields

        private string _firstName;
        private string _homePhone;
        private string _lastName;
        private string _mobilePhone;
        private string _title;

        #endregion

        #region Properties

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string HomePhone
        {
            get { return _homePhone; }
            set
            {
                _homePhone = value;
                OnPropertyChanged("HomePhone");
            }
        }

        public string MobilePhone
        {
            get { return _mobilePhone; }
            set
            {
                _mobilePhone = value;
                OnPropertyChanged("MobilePhone");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}