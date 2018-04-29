using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Wpflogin1
{
    /// <summary>
    /// Interaction logic for Screen2.xaml
    /// </summary>
    public partial class Screen2 : Window
    {
        public Screen2()
        {
            InitializeComponent();
          
        }

      
        private void btnprofile_Click(object sender, RoutedEventArgs e)
        {
            profile scprofile = new profile();
            scprofile.Show();
            this.Close();
        }

        private void btnmap_Click(object sender, RoutedEventArgs e)
        {
             map scmap = new map();
            scmap.Show();
            this.Close();
        }
    }
}
