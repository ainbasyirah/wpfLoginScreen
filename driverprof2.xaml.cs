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
    /// Interaction logic for driverprof2.xaml
    /// </summary>
    public partial class driverprof2 : Window
    {
        public driverprof2()
        {
            InitializeComponent();
            binddatagrid();
    }

    private void binddatagrid()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["connprofile"].ConnectionString;
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from [tblprofile2] ";
        cmd.Connection = con;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable("tblprofile2");
        sda.Fill(dt);

        g2.ItemsSource = dt.DefaultView;
        }

        private void btngps_Click(object sender, RoutedEventArgs e)
        {
            gpsmap scgpsmap = new gpsmap();
            scgpsmap.Show();
            this.Close();
        }

        private void btncamera_Click(object sender, RoutedEventArgs e)
        {
            camera sccamera = new camera();
            sccamera.Show();
            this.Close();
        }
    }
}
