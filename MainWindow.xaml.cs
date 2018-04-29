using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpflogin1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*string username, password;
            username = Console.ReadLine();
            password = Console.ReadLine();*/
        }


        private void InitializeMyButton()
        {
            // Create and initialize a Button.
            Button Btnlogin = new Button();
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {
            string user, password;
            user = txtUsername.Text;
            password = txtPassword.Password;
            user = Console.ReadLine();
            password = Console.ReadLine();

            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-K2AV9JKV\SQLEXPRESS; Initial Catalog=LoginDB; Integrated Security=True");
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT * FROM tblUser WHERE username=@Username AND password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon)
                {
                    CommandType = System.Data.CommandType.Text
                };
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                //int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                //sqlCon.Open();

                SqlDataReader sdr = sqlCmd.ExecuteReader();

                if ((sdr.Read() == true))

                {
                    sdr.Read();
                    //user = sdr.GetString(1);  // Name string
                    //password = sdr.GetString(2); // Password string
                    Screen2 sc2 = new Screen2();
                    sc2.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }     
        }
    }
}

