using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewClient ViewClientobj = new SMSUI.ViewClient();

            clientMainUG.Children.Clear();
            clientMainUG.Children.Add(ViewClientobj);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SMSUI.AddClient AddClientobj = new SMSUI.AddClient();

            clientMainUG.Children.Clear();
            clientMainUG.Children.Add(AddClientobj);
        }
    }
}
