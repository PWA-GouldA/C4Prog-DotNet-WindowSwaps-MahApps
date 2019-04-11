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
    /// Interaction logic for SecondWindowDialogMainShown.xaml
    /// </summary>
    public partial class SecondWindowDialogMainShown : Window
    {
        public SecondWindowDialogMainShown()
        {
            InitializeComponent();
        }

        private void ButtonReturnDB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
