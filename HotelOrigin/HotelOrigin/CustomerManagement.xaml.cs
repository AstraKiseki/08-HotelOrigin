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
using System.Collections.ObjectModel;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        public CustomerManagement()
        {
            InitializeComponent();
            dataGrid.ItemsSource = CustomerManagement.GetAll();
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
