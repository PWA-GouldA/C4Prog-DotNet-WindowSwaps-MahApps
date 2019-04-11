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

namespace SwapWindows
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

        private void ButtonSecondCM_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of window and show it to the user
            SecondWindowMainClosed winCM = new SecondWindowMainClosed();
            winCM.Show();
            winCM.Title = "Main Closed";

            // Close this window! (Main, Main no longer executing)
            this.Close();
        }



        private void ButtonSecondHM_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of window and show it to the user
            SecondWindowMainHidden winHM = new SecondWindowMainHidden();
            winHM.Show();
            winHM.Title = "Main Hidden";
            // Let the second window know it is OWNED by the Main
            winHM.Owner = this;

            // Hide this window! (Main, Main is still active!)
            this.Hide();
        }



        private void ButtonSecondDB_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of window and show it to the user
            SecondWindowDialogMainShown winDB = new SecondWindowDialogMainShown();
            winDB.ShowDialog();
            winDB.Title = "DIALOG BOX, Main Shown";
        }

        private void ButtonSecondDBHM_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();

            // Create instance of window and show it to the user
            SecondWindowDialogMainHidden winDBHM = new SecondWindowDialogMainHidden();
            winDBHM.Title = "DIALOG BOX, Main Hidden";
            // Let the second window know it is OWNED by the Main
            winDBHM.Owner = this;
            winDBHM.ShowDialog();

        }

        private void ButtonShowCentre_Click(object sender, RoutedEventArgs e)
        {
            SecondWindowCentre winCent = new SecondWindowCentre();
            winCent.Owner = this;
            winCent.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            winCent.Show();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ButtonShowCentre_Click(sender, e);
        }
    }
}
