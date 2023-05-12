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

namespace Forum
{
    public partial class MainWindow : Window
    {
        public static string Ipi;
         public MainWindow()
        {
            InitializeComponent();
        }


            private void Join_Click(object sender, RoutedEventArgs e)
        {
                if (Ipi != null)
                {
                    Ipi = IpAdress.Text;
                    MainComment server = new MainComment();
                    server.Show();
                    Close();
                }


                else
                {
                    MessageBox.Show("Введите IP форума");
                }
            }

        private void IpAdress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
