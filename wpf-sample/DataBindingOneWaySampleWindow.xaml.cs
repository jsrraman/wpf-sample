using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpf_sample
{
    /// <summary>
    /// Interaction logic for DataBindingOneWaySample.xaml
    /// </summary>
    public partial class DataBindingOneWaySampleWindow : Window
    {
        private Employee emp;
        public DataBindingOneWaySampleWindow()
        {
            InitializeComponent();

            emp = new Employee()
            {
                Name = "Rajaraman",
                Title = "Developer"
            };

            DataContext = emp;
        }

        private void OnChangeEmployeeDataBindingClick(object sender, RoutedEventArgs e)
        {
            emp.Name = "Rajaraman Subramanian";
            emp.Title = "Senior Developer";
        }
    }
}
