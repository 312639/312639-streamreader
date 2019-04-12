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

namespace _312639Reader_Challange
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

        
        List<string> month2017 = new List<string>();

        private void Seventeen_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("2017.txt");

            while (!streamReader.EndOfStream)
            {
                month2017.Add(streamReader.ReadLine());
            }

            if ((bool)Jan.IsChecked) { lblOutput.Content = month2017.ToString()[1]; }
            else if ((bool)Feb.IsChecked) { lblOutput.Content = month2017.ToString()[2]; }
            else if ((bool)Mar.IsChecked) { lblOutput.Content = month2017.ToString()[3]; }
            else if ((bool)Apr.IsChecked) { lblOutput.Content = month2017.ToString()[4]; }
            else if ((bool)May.IsChecked) { lblOutput.Content = month2017.ToString()[5]; }
            else if ((bool)Jun.IsChecked) { lblOutput.Content = month2017.ToString()[6]; }
            else if ((bool)Jul.IsChecked) { lblOutput.Content = month2017.ToString()[7]; }
            else if ((bool)Aug.IsChecked) { lblOutput.Content = month2017.ToString()[8]; }
            else if ((bool)Sep.IsChecked) { lblOutput.Content = month2017.ToString()[9]; }
            else if ((bool)Oct.IsChecked) { lblOutput.Content = month2017.ToString()[10]; }
            else if ((bool)Nov.IsChecked) { lblOutput.Content = month2017.ToString()[11]; }
            else if ((bool)Dec.IsChecked) { lblOutput.Content = month2017.ToString()[12]; }


            
        }

        List<string> month2018 = new List<string>();

        private void Eighteen_Click(object sender, RoutedEventArgs e)
        {

            System.IO.StreamReader streamReader = new System.IO.StreamReader("2018.txt");

            while (!streamReader.EndOfStream)
            {
                month2018.Add(streamReader.ReadLine());
            }

            if ((bool)Jan.IsChecked) { lblOutput.Content = month2018.ToString()[1] ; }
            else if ((bool)Feb.IsChecked) { lblOutput.Content = month2018.ToString()[2]; }
            else if ((bool)Mar.IsChecked) { lblOutput.Content = month2018.ToString()[3]; }
            else if ((bool)Apr.IsChecked) { lblOutput.Content = month2018.ToString()[4]; }
            else if ((bool)May.IsChecked) { lblOutput.Content = month2018.ToString()[5]; }
            else if ((bool)Jun.IsChecked) { lblOutput.Content = month2018.ToString()[6]; }
            else if ((bool)Jul.IsChecked) { lblOutput.Content = month2018.ToString()[7]; }
            else if ((bool)Aug.IsChecked) { lblOutput.Content = month2018.ToString()[8]; }
            else if ((bool)Sep.IsChecked) { lblOutput.Content = month2018.ToString()[9]; }
            else if ((bool)Oct.IsChecked) { lblOutput.Content = month2018.ToString()[10]; }
            else if ((bool)Nov.IsChecked) { lblOutput.Content = month2018.ToString()[11]; }
            else if ((bool)Dec.IsChecked) { lblOutput.Content = month2018.ToString()[12]; }

            
        }
    
    }
}
