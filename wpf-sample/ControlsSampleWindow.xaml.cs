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
    /// Interaction logic for ControlsSample.xaml
    /// </summary>
    public partial class ControlsSampleWindow : Window
    {
        public ControlsSampleWindow()
        {
            InitializeComponent();
        }

        private string GetComputerType()
        {
            if ((bool)Desktop.IsChecked)
            {
                return "Desktop";
            }
            else if ((bool)Laptop.IsChecked)
            {
                return "Laptop";
            }
            else if ((bool)Table.IsChecked)
            {
                return "Table";
            }
            else
            {
                return "";
            }
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.Append(FullName.Text + "\n");
            sb.Append("Sex: ");
            sb.Append((bool)Male.IsChecked ? "Male" : "Female");
            sb.Append("\n");
            sb.Append("Computer: ");
            sb.Append(GetComputerType() + "\n");
            sb.Append("Your Job: ");
            sb.Append(Job.SelectedItem.ToString() + "\n");
            sb.Append("Delivery Date: ");
            sb.Append(DeliveryDate.SelectedDate.ToString() + "\n");

            MessageBox.Show(sb.ToString());
        }

        private void OnJobSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }
    }
}
