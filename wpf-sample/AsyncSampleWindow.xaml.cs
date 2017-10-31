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
    /// Interaction logic for AsyncSampleWindow.xaml
    /// </summary>
    public partial class AsyncSampleWindow : Window
    {
        public AsyncSampleWindow()
        {
            InitializeComponent();
            DoLengthyStuffAsync();
        }

        private async void DoLengthyStuffAsync()
        {
            int baseValue = 0;
            Message.Text = "Computing...";

            while (true)
            {
                double sum = 0.0f;    

                await Task.Run(() =>
                {
                    for (int i = baseValue; i < 200000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                Message.Text = "Sum = " + sum;
                baseValue++;
            }
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked");
        }
    }
}
