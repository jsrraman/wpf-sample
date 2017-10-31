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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnGridSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new GridSampleWindow();
            window.Show();
        }

        private void OnStackPanelSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new StackPanelSampleWindow();
            window.Show();
        }

        private void OnWrapPanelSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new WrapPanelSampleWindow();
            window.Show();
        }

        private void OnDockPanelSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new DockPanelSampleWindow();
            window.Show();
        }

        private void OnControlsSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new ControlsSampleWindow();
            window.Show();
        }

        private void OnCanvasSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new CanvasSampleWindow();
            window.Show();
        }

        private void OnDataBindingOneWaySampleClick(object sender, RoutedEventArgs e)
        {
            var window = new DataBindingOneWaySampleWindow();
            window.Show();
        }

        private void OnDataBindingTwoWaySampleClick(object sender, RoutedEventArgs e)
        {
            var window = new DataBindingTwoWaySampleWindow();
            window.Show();
        }

        private void OnDataBindingListsSampleClick(object sender, RoutedEventArgs e)
        {
            var window = new DataBindingListsSampleWindow();
            window.Show();
        }
    }
}
