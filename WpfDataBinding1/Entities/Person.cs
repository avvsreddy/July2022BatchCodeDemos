using System.ComponentModel;

namespace WpfDataBinding1.Entities
{
    internal class Person : INotifyPropertyChanged
    {

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string mname;

        public string MiddleName
        {
            get { return mname; }
            set
            {
                mname = value;
                OnPropertyChanged("MiddleName");
            }
        }

        //public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Photo { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
