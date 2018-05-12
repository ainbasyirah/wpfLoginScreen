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

namespace WPF_Bustrack
{
    /// <summary>
    /// Interaction logic for camera.xaml
    /// </summary>
    public partial class camera : Window
    {
        public camera()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            gpsmap scgpsmap = new gpsmap();
            scgpsmap.Show();
            this.Close();
        }
    }
}
