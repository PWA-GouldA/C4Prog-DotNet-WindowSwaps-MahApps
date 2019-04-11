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
using MahApps;
using MahApps.Metro;

namespace SwapWindows
{
    /// <summary>
    /// Interaction logic for SecondWindowCentre.xaml
    /// </summary>
    public partial class SecondWindowCentre
    {
        public SecondWindowCentre()
        {
            InitializeComponent();
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
