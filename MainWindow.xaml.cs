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
using UsersMvcApp.Controllers;

namespace UsersMvcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController _userController;

        public MainWindow()
        {
            InitializeComponent();

            _userController = new UserController(MainFrame);
            _userController.ShowHomeScreen();
        }
    }
}