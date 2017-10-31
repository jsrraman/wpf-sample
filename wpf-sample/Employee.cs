using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf_sample
{
    public class Employee : INotifyPropertyChanged
    {
        public Employee()
        {

        }

        public Employee(string name, string title, DateTime startDate)
        {
            _name = name;
            _title = title;
            _startDate = startDate;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public static Employee GetEmployee()
        {
            var emp = new Employee()
            {
                Name = "Rajaraman",
                Title = "Developer"
            };

            return emp;
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();

            employees.Add(new Employee() { Name = "Rama", Title = "Developer" });
            employees.Add(new Employee() { Name = "Krishna", Title = "Senior Developer" });
            employees.Add(new Employee() { Name = "Govinda", Title = "Chief Developer" });

            return employees;
        }
    }
}
