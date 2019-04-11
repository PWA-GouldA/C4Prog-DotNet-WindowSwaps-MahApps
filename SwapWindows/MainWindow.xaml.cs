using System.Threading.Tasks;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Media;

namespace SwapWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSecondCM_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of window and show it to the user
            SecondWindowMainClosed winCM = new SecondWindowMainClosed()
            {
                Title = "Main Closed",
                ShowTitleBar = false,
                GlowBrush = new SolidColorBrush(Colors.DodgerBlue),
                ResizeMode = ResizeMode.CanResize,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            winCM.Show();

            // Close this window! (Main, Main no longer executing)
            this.Close();
        }



        private void ButtonSecondHM_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of window and show it to the user
            SecondWindowMainHidden winHM = new SecondWindowMainHidden()
            {
                Title = "Main Hidden",
                ShowTitleBar = true,
                GlowBrush = new SolidColorBrush(Colors.DodgerBlue),
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            winHM.Show();

            // Let the second window know it is OWNED by the Main
            winHM.Owner = this;

            // Hide this window! (Main, Main is still active!)
            this.Hide();
        }



        private void ButtonSecondDB_Click(object sender, RoutedEventArgs e)
        {
            // Create instance of window and show it to the user
            SecondWindowDialogMainShown winDB = new SecondWindowDialogMainShown()
            {
                Title = "DIALOG BOX, Main Shown",
                ShowTitleBar = true,
                GlowBrush = new SolidColorBrush(Colors.DodgerBlue),
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            winDB.ShowDialog();
        }

        private void ButtonSecondDBHM_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            // Create instance of window and show it to the user
            SecondWindowDialogMainHidden winDBHM = new SecondWindowDialogMainHidden()
            {
                Title = "DIALOG BOX, Main Hidden",
                ShowTitleBar = true,
                GlowBrush = new SolidColorBrush(Colors.DodgerBlue),
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
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

        private async void MenuMessageBox_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("This is the title", "Some message");
        }
        private async void MenuProgress_Click(object sender, RoutedEventArgs e)
        {
            var controller = await this.ShowProgressAsync("Please wait...", "Progress message");
            controller.SetIndeterminate();
            await Task.Delay(5000);

            await controller.CloseAsync();
        }
    }
}
