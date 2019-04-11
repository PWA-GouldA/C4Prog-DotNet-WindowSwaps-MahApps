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
    /// Interaction logic for SecondWindowDialogMainHidden.xaml
    /// </summary>
    public partial class SecondWindowDialogMainHidden
    {
        public SecondWindowDialogMainHidden()
        {
            InitializeComponent();
        }

        private void ButtonReturnDB_Click(object sender, RoutedEventArgs e)
        {
            // SHOW THE MAIN WINDOW before closing this one!
            this.Owner.Show();
            this.Close();
       
        }
    }
}
