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
    /// Interaction logic for DataConvertorSampleWindow.xaml
    /// </summary>
    public partial class DataConvertorSampleWindow : Window
    {
        public DataConvertorSampleWindow()
        {
            InitializeComponent();
            DataContext = new Employee("Rajaraman", "Developer", new DateTime(2017, 1, 1));
        }
    }
}
