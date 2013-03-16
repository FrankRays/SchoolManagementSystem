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
    /// Interaction logic for Agents.xaml
    /// </summary>
    public partial class Agents : UserControl
    {
        public Agents()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewAgent ViewAgentobj = new SMSUI.ViewAgent();

            mainAgentUniGrid.Children.Clear();
            mainAgentUniGrid.Children.Add(ViewAgentobj);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SMSUI.AddAgent AddAgentobj = new SMSUI.AddAgent();

            mainAgentUniGrid.Children.Clear();
            mainAgentUniGrid.Children.Add(AddAgentobj);
        }

        
    }
}
