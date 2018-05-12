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

namespace WPF_Bustrack
{
    /// <summary>
    /// Interaction logic for gpsmap.xaml
    /// </summary>
    public partial class gpsmap : Window
    {
        public gpsmap()
        {
            InitializeComponent();
            
        }


        private void btndriver1_Click(object sender, RoutedEventArgs e)
        {
            profdriver1 scprofdriver1 = new profdriver1();
            scprofdriver1.Show();
            this.Close();
        }

        private void btndriver2_Click(object sender, RoutedEventArgs e)
        {
            driverprof2 scdriverprof2 = new driverprof2();
            scdriverprof2.Show();
            this.Close();
        }
    }
}
