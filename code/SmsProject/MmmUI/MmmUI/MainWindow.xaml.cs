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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Signin Signinobj = new SMSUI.Signin();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Signinobj);

        }

        private void employeesBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Employees Employeesobj = new SMSUI.Employees();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Employeesobj);

            
        }

        private void agentsBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Agents Agentsobj = new SMSUI.Agents();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Agentsobj);
        }

        private void clientsBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Clients Clientsobj = new SMSUI.Clients();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Clientsobj);
        }

        private void reportsBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Reports Reportsobj = new SMSUI.Reports();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Reportsobj);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Settings Settingsobj = new SMSUI.Settings();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Settingsobj);
        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Help Helpobj = new SMSUI.Help();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Helpobj);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
