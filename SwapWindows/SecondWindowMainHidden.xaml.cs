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

namespace SwapWindows
{
    /// <summary>
    /// Interaction logic for SecondWindowMainHidden.xaml
    /// </summary>
    public partial class SecondWindowMainHidden : Window
    {
        public SecondWindowMainHidden()
        {
            InitializeComponent();
        }

        private void ButtonReturnHM_Click(object sender, RoutedEventArgs e)
        {
            // Because Main window (the owner) is hidden, Show the owner!
            this.Owner.Show();
            // close this window
            this.Close();
        }
    }
}
