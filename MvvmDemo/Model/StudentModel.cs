using System.ComponentModel;
using MvvmDemo.Annotations;

namespace MvvmDemo.Model
{
    public class StudentModel
    {
    }

    public class Student : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                }

            }
        }

        public string LastName
        {
            get { return _lastName; }

            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
