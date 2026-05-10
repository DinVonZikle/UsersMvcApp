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
    /// Interaction logic for EditUserScreen.xaml
    /// </summary>
    public partial class EditUserScreen : Page
    {
        private readonly UserController _controller;
        private readonly User _user;

        public EditUserScreen(UserController controller, User user)
        {
            InitializeComponent();

            _controller = controller;
            _user = user;

            NameTextBox.Text = _user.Name;
            LastNameTextBox.Text = _user.LastName;
            AgeTextBox.Text = _user.Age.ToString();

            SaveButton.Click += SaveButton_Click;
            CancelButton.Click += CancelButton_Click;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                MessageBox.Show("Вік має бути числом");
                return;
            }

            User updatedUser = new User(
                _user.Id,
                NameTextBox.Text,
                LastNameTextBox.Text,
                age
            );

            _controller.UpdateUser(updatedUser);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            _controller.ShowDetailsScreen(_user);
        }
    }
}
