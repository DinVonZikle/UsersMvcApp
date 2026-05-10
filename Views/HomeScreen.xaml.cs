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
using UsersMvcApp.Controllers;
using UsersMvcApp.Models;

namespace UsersMvcApp.Views
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Page
    {
        private readonly UserController _controller;

        public HomeScreen(UserController controller, List<User> users)
        {
            InitializeComponent();

            _controller = controller;
            UsersListBox.ItemsSource = users;

            UsersListBox.SelectionChanged += UsersListBox_SelectionChanged;
        }

        private void UsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsersListBox.SelectedItem is User selectedUser)
            {
                _controller.ShowDetailsScreen(selectedUser);
            }
        }
    }
}
