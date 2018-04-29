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

namespace Wpflogin1
{
    /// <summary>
    /// Interaction logic for map.xaml
    /// </summary>
    public partial class map : Window
    {
        public map()
        {
            InitializeComponent();
        }

        private void btnback2_Click(object sender, RoutedEventArgs e)
        {
            Screen2 sc2 = new Screen2();
            sc2.Show();
            this.Close();
        }
    }
}
