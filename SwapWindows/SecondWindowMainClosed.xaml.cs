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
    /// Interaction logic for SecondWindowMainClosed.xaml
    /// </summary>
    public partial class SecondWindowMainClosed
    {
        public SecondWindowMainClosed()
        {
            InitializeComponent();
        }

        private void ButtonReturnCM_Click(object sender, RoutedEventArgs e)
        {
            // If you close the main window then create a new copy
            // so it can be shown to the user
            MainWindow main = new MainWindow();
            main.Show();
            // close this secondary window
            this.Close();
        }

    }
}
